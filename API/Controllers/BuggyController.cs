using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
     [ApiController]
    [Route("api/[controller]")]
    public class BuggyController : Controller
    {
        private readonly DataContext _context;

        public BuggyController(DataContext dataContext)
        {
            _context = dataContext;
        }

        [Authorize]
        [HttpGet("auth")]
        public ActionResult<string> GetSecret()
        {
            return "secret text";
        }

        [HttpGet("not-found")]
        public ActionResult<ApplicationUser> GetNotFound()
        {
            var thing = _context.ApplicationUsers.Find(-1);
            if(thing == null){
                return NotFound();
            }
            return Ok(thing);
        }

         [HttpGet("server-error")]
        public ActionResult<string> GetServerError()
        {
            try{
                var thing = _context.ApplicationUsers.Find(-1);
                var thingToReturn = thing.ToString();
                return thingToReturn;
            }catch(Exception e){
                return StatusCode(500, "Computer says no!");
            }
        }

        [HttpGet("bad-request")]
        public ActionResult<string> GetBadRequest()
        {
            return BadRequest("this was a bad request");
        }
    }
}