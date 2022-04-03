using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberMutiples.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumbersMutiplesController : ControllerBase
    {
        public NumbersMutiplesController()
        {
        }


        [HttpGet("get/{number}")]
        public JsonResult Get(int number)
        {
            var json = string.Empty;
            if (number % (5 * 3) == 0)
            {
                json = "GN";
            }
            else if (number % 3 == 0)
            {
                json = "G";
            }
            else if (number % 5 == 0)
            {
                json = "N";
            }
            else
            {
                json = number.ToString();
            }

            return new JsonResult(new {input=$"{number}",output=json });
        }
    }
}
