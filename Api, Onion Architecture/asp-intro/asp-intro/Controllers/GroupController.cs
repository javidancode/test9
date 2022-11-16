using asp_intro.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace asp_intro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll() 
        {
            List<Group> groups= new List<Group>();

            Group group1 = new Group()
            {
                Id = 1,
                Name = "P130",
                Capasity = 10,
            };

            Group group2 = new Group()
            {
                Id = 2,
                Name = "P133",
                Capasity = 16,
            };

            Group group3 = new Group()
            {
                Id = 3,
                Name = "P136",
                Capasity = 19,
            };

            groups.Add(group1);
            groups.Add(group2);
            groups.Add(group3);

            return Ok(groups);
        }
    }
}
