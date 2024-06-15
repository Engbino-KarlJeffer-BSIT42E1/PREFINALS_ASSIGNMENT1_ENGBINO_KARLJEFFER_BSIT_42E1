using Microsoft.AspNetCore.Mvc;
using System;


namespace ProtectedApi
{
    [ApiController]
    [Route("[controller]")]
    public class ValueController : ControllerBase
    {
        private readonly string _owner = "Karl Jeffer Engbino";
        private readonly Random _random = new Random();
        private readonly string[] _thingsAboutOwner = new[]
        {
            "I love playing Volleyball",
            "I enjoy strolling",
            "I like eating burgers",
            "Enjoying watching action movies",
            "I love reading.",
            "I like playing computer games",
            "I like to go to the park",
            "I hate bugs",
            "I like playing outside",
            "I dont like insects"
        };


        [HttpGet("about/me")]
        public IActionResult AboutMe()
        {
            var thing = _thingsAboutOwner[_random.Next(_thingsAboutOwner.Length)];
            return Ok(thing);
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            return Ok(_owner);
           
        }

        

        [HttpPost("about")]
        public IActionResult About([FromBody] NameModel model)
        {
            return Ok($"Hi {model.Name} from {_owner}");
        }
    }

    public class NameModel
    {
        public string? Name { get; set; }
    }
}