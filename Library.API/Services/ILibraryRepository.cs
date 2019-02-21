using Library.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Services
{
    interface ILibraryRepository
    {
        IEnumerable<FriendConnection> GetAllConnections();

        FriendConnection GetFriendConnection(Guid id);

        void AddFriendConnection(FriendConnection friend);

        void DeleteFriendConnection(FriendConnection friend);

        void UpdateFriendConnection(FriendConnection friend);

        bool FriendConnectionExists(Guid id);

        IEnumerable<Book> GetAllBooksForFriendConnection(Guid id);

        Book GetBookForFriendConnection(Guid friendId, Guid bookId);

        void AddBookForFriendConnection(Guid friendId, Book book);

        void DeleteBookForFriendConnection(Guid friendId, Book book);

        void UpdateBook(Book book);

        bool FriendConnectionExists(Guid id);

        bool SaveChanges();

    }
}
