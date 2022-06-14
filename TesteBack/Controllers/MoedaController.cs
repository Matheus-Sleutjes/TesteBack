using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoedaController : ControllerBase
    {

        public MoedaController()
        {
        }

        [HttpGet("GetItemFila")]
        public void GetItemFila()
        {
            
        }

        [HttpPost("AddItemFila")]
        public void AddItemFila()
        {

        }
    }
}
