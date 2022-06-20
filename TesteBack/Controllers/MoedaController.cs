using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
            var item = _moedaService.GetItemFila();

            if (item == null)
                return NotFound();

            return Ok(item);
        }

        [HttpPost("AddItemFila")]
        public IActionResult AddItemFila([FromBody] List<PesquisaModelView> pesquisa)
        {
            var acao = _moedaService.AdditemFila(pesquisa);

            if(!acao)
                return BadRequest();

            return Ok();
        }
    }
}
