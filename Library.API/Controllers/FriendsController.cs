using Library.API.Entities;
using Library.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Controllers
{
    [Route("api/friends")]
    [ApiController]
    public class FriendsController : Controller
    {
        private readonly ILibraryRepository _repository;

        public FriendsController(ILibraryRepository repository)
        {
            _repository = repository;
        }

        // GET api/friends
        [HttpGet]
        public IActionResult GetFriends()
        {
            var FriendsFromRepo = _repository.GetAllConnections();
            return Ok(FriendsFromRepo);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}
