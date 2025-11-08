using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    //home
    [ApiController]
    [Route("[controller]")]
    public class apaController : Controller
    {
        [HttpGet("apa")]
        public string Apa()
        {
            return "Apa kabar?";
        }

        [HttpGet("hai")]
        public string Hai([FromQuery] string nama)
        {
            return "Hello, " + nama + "!";
        }
    }
}
