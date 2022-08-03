using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PocGetDnsRequest.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET: api/<HomeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { Newtonsoft.Json.JsonConvert.SerializeObject(Request.Host) };
        }
    }
}
