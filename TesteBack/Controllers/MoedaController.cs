using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteBack.Model;
using TesteBack.Model.Validation;
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

            Validacoes.ValidarSeNulo(lista, "Não foi encontrado nenhum item");  

            return Ok(lista);
        }

        [HttpPost("AddItemFila")]
        public IActionResult AddItemFila([FromBody] PesquisaModelView pesquisa)
        {
            Validacoes.ValidarSeNulo(pesquisa, "Preencha todos os parametros");

            var acao = _moedaService.AdditemFila(pesquisa);

            Validacoes.ValidarSeFalso(acao, "Verifique se os parametros estão preenchidos corretamente");

            return Ok();
        }
    }
}
