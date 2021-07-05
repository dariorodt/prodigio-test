
using Microsoft.AspNetCore.Mvc;

namespace ProdigioTestBackEnd.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController: ControllerBase
    {
        [HttpGet]
        public string get()
        {
            return "Hello world!";
        }
    }
}