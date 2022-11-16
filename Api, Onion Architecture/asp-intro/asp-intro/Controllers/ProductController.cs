using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace asp_intro.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetById(int id)
        {
            string name = "Orxan" + id;
            return Ok(name);
        
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            List<string> names = new List<string>() { "Seid", "Togrul", "Sadiq", "Esqin" };
            return Ok(names);
        }
    }
}
