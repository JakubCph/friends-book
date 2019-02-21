using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.API.Entities;

namespace Library.API.Services
{
    public class LibraryRepository : ILibraryRepository
    {
        public void AddBookForFriendConnection(Guid friendId, Book book)
        {
            throw new NotImplementedException();
        }

        public void AddFriendConnection(FriendConnection friend)
        {
            throw new NotImplementedException();
        }

        public void DeleteBookForFriendConnection(Guid friendId, Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteFriendConnection(FriendConnection friend)
        {
            throw new NotImplementedException();
        }

        public bool FriendConnectionExists(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooksForFriendConnection(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FriendConnection> GetAllConnections()
        {
            throw new NotImplementedException();
        }

        public Book GetBookForFriendConnection(Guid friendId, Guid bookId)
        {
            throw new NotImplementedException();
        }

        public FriendConnection GetFriendConnection(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
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
