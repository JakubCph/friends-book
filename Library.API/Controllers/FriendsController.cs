using Library.API.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Controllers
{
    public class FriendsController : Controller
    {
        private readonly LibraryDBContext _context;

        public FriendsController(LibraryDBContext context)
        {
            _context = context;
        }
    }
}
