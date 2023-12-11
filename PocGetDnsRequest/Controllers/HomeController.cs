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
        public GetResponse Get()
        {

            return new GetResponse()
            {
                MachineName = Environment.MachineName,
                OSVersion = Environment.OSVersion,
                RequestHost = Request.Host,
                WorkingSet = Environment.WorkingSet,
                ProcessorCount = Environment.ProcessorCount,
            };
        }
    }

    public class GetResponse
    {
        public HostString? RequestHost { get; set; }
        public string? MachineName { get; set; }
        public OperatingSystem? OSVersion { get; set; }
        public long WorkingSet { get; set; }
        public int ProcessorCount { get; set; }
    }

}
