using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APITest.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class SimpleController : ControllerBase {

        private readonly ILogger<SimpleController> _logger;

        public SimpleController(ILogger<SimpleController> logger) {
            _logger = logger;
        }

        [HttpGet(Name = "SimpleGet")]
        public string Get() {
            return "hello";
        }

    }
}
