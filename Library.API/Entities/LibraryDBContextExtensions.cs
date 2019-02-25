using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Entities
{
    public static class LibraryDBContextExtensions
    {
        public static void InitializeContext(this LibraryDBContext context)
        {
            // clear the database
            context.Friends.RemoveRange(context.Friends);
            context.SaveChanges();

            var Friends = new List<FriendConnection>()
            {
                new FriendConnection()
                {
                    Id = new Guid("10b87fe9-b5de-4ca8-917d-0ad6caffbda7"),
                    FirstName = "Karen",
                    LastName = "Jeferson",
                    Address = "USA",
                    DateOfBirth = new DateTime(1990,10,3),
                    Email = "karen@gmail.com",
                    FavouriteReads =
                    {
                        new Book()
                        {
                            Id = new Guid("a760ef86-6d8e-4832-a2e3-c12da83f361b"),
                            Author = "Steven King",
                            Title = "It"
                        },
                        new Book()
                        {
                            Id = new Guid("ea91a701-49f4-4030-b6f7-4ccfe9bf620b"),
                            Author = "Steven King",
                            Title = "Carrie"
                        },
                        new Book()
                        {
                            Id = new Guid("068f50c2-1616-49c0-9342-93088d75f1a2"),
                            Author = "Steven King",
                            Title = "Pet Cementary"
                        },
                    }
                        
                },
                new FriendConnection()
                {
                    Id = new Guid("12356f1a-8085-4251-a101-fecc0ebf5734"),
                    FirstName = "Marek",
                    LastName = "Piotrowski",
                    Address = "Polska",
                    DateOfBirth = new DateTime(1970, 12, 1),
                    Email = "marek.piotrowski@yahoo.com",
                    FavouriteReads =
                    {
                        new Book()
                        {
                            Id = new Guid("f483447d-1915-43c6-afab-de3913366bc4"),
                            Author = "J.K.Rowling",
                            Title = "The Phylosopher's Stone"
                        },
                        new Book()
                        {
                            Id = new Guid("b39e9bf6-93f7-4907-83b9-e431b13ae84d"),
                            Author = "J.K.Rowling",
                            Title = "The CHamber of the Secrets"
                        },
                        new Book()
                        {
                            Id = new Guid("90b865da-a74c-40c6-8c3b-7440ebfe7307"),
                            Author = "J.K.Rowling",
                            Title = "The Deathly Hallows"
                        },
                    }
                },
                new FriendConnection()
                {
                    Id = new Guid("88bce39a-68ea-43f3-8885-f7aec9236959"),
                    FirstName = "David",
                    LastName = "Borrow",
                    Address = "UK",
                    DateOfBirth = new DateTime(2000, 6, 8),
                    Email = "david.borrow@gmail.com",
                    FavouriteReads =
                    {
                        new Book()
                        {
                            Id = new Guid("c34477ec-f97c-48c8-82cd-8adc0ce2b78c"),
                            Author = "Lee Child",
                            Title = "Past Tense"
                        },
                        new Book()
                        {
                            Id = new Guid("8dbd32d7-b20f-457d-b4fa-bd6d213ac153"),
                            Author = "Lee Child",
                            Title = "The Midnight Line"
                        }
                    }
                }
        };
                
            //initialize database
            context.Friends.AddRange(Friends);
            context.SaveChanges();
        }
    }
}
