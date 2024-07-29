using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ControllerBasedAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody(EmptyBodyBehavior = EmptyBodyBehavior.Allow)] int? data)
        {
            return Ok();
        }
    }
}
