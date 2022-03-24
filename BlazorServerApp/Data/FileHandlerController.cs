using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorServerApp.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileHandlerController : ControllerBase
    {
        // GET: api/<FileHandlerController>
        [HttpGet]
        public string Get()
        {
            return System.IO.File.ReadAllText(@"C:\test\Test.txt");
        }
    }
}
