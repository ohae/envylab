using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{total}")]
        public ActionResult<string> Get(int total)
        {
            var engine = new Engine();
            var result = engine.Calculate(total);
            return result;
        }

    }
}
