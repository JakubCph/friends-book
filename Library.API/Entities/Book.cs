using System;
using System.ComponentModel.DataAnnotations;

namespace Library.API.Entities
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }
        public Guid FriendId { get; set; }

        public string Author { get; set; }
        
        public string Title { get; set; }

    }
}