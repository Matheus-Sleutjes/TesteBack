using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteBack.Model;
using TesteBack.Service.Interface;

namespace TesteBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoedaController : ControllerBase
    {
        readonly IMoedaService _moedaService;
        public MoedaController(IMoedaService moedaService)
        {
            _moedaService = moedaService;
        }

        [HttpGet("GetItemFila")]
        public IActionResult GetItemFila()
        {
            var lista = _moedaService.GetItemFile();
            
            if(lista == null)
                return NotFound();  

            return Ok(lista);
        }

        [HttpPost("AddItemFila")]
        public IActionResult AddItemFila([FromBody] PesquisaModel pesquisa)
        {
            var acao = _moedaService.AdditemFila(pesquisa);

            if (!acao)
                return NotFound();

            return Ok();
        }
    }
}
