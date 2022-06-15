using System;
using System.Collections.Generic;
using TesteBack.Model;
using TesteBack.Repository.Interface;
using TesteBack.Service.Interface;

namespace TesteBack.Service
{
    public class MoedaService : IMoedaService
    {
        private readonly IMoedaRepository _moedaRepository;
        public MoedaService(IMoedaRepository moedaRepository) 
        {
            _moedaRepository = moedaRepository;
        }

        public bool AdditemFila(PesquisaModelView pesquisa)
        {
            var pesquisaFormatada = this.TransformaStringDate(pesquisa);
            var retorno = _moedaRepository.AddItemLista(pesquisaFormatada);

            return retorno;
        }

        public List<MoedaModel> GetItemFile()
        {
            return new List<MoedaModel>();
        }

        private PesquisaModel TransformaStringDate(PesquisaModelView pesquisa)
        {
            var dataInicio = DateTime.ParseExact(pesquisa.data_inicio, "yyyy-MM-dd", null);
            var dataFim = DateTime.ParseExact(pesquisa.data_fim, "yyyy-MM-dd", null);

            return new PesquisaModel(pesquisa.moeda, dataInicio, dataFim );
        }
    }
}
