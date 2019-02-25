using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.API.Entities;

namespace Library.API.Services
{
    public class LibraryRepository : ILibraryRepository
    {
        private LibraryDBContext _context;

        public LibraryRepository(LibraryDBContext context)
        {
            _context = context;
        }
        public void AddBookForFriendConnection(Guid friendId, Book book)
        {
            var friend = GetFriendConnection(friendId);
            if(friend != null)
            {
                // the ID is empty (i.e. when it's not upserting)
                if(book.Id == Guid.Empty)
                {
                    book.Id = Guid.NewGuid();
                }
                friend.FavouriteReads.Add(book);

            }

        }

        public void AddFriendConnection(FriendConnection friend)
        {
            if(friend.Id == Guid.Empty)
            {
                friend.Id = Guid.NewGuid();
            }
            _context.Friends.Add(friend);
        }

        public void DeleteBookForFriendConnection(Guid friendId, Book book)
        {
            var friend = GetFriendConnection(friendId);
            if(friend != null)
            {
                friend.FavouriteReads.Remove(book);
            }
           
        }

        public void DeleteFriendConnection(FriendConnection friend)
        {
            _context.Friends.Remove(friend);
        }

        public bool FriendConnectionExists(Guid id)
        {
            return _context.Friends.Any(f => f.Id == id);
        }

        public IEnumerable<Book> GetAllBooksForFriendConnection(Guid id)
        {
            return _context.Books.Where(b => b.FriendConnectionId == id)
                                 .OrderBy(b => b.Title);
        }

        public IEnumerable<FriendConnection> GetAllConnections()
        {
            return _context.Friends.OrderBy(f => f.FirstName)
                                   .ThenBy(f => f.LastName);
        }

        public Book GetBookForFriendConnection(Guid friendId, Guid bookId)
        {
            return _context.Books.Where(b => b.FriendConnectionId == friendId && b.Id == bookId)
                                 .FirstOrDefault();
        }

        public FriendConnection GetFriendConnection(Guid id)
        {
            return _context.Friends.FirstOrDefault(f =>  f.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void UpdateFriendConnection(FriendConnection friend)
        {
            throw new NotImplementedException();
        }
    }
}
