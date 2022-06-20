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

        public bool AdditemFila(List<PesquisaModelView> pesquisa)
        {
            var lista = new List<PesquisaModel>();
            foreach (var item in pesquisa)
            {
                var pesquisaFormatada = this.TransformaStringDate(item);

                if(pesquisaFormatada.DataInicio <= pesquisaFormatada.DataFim)
                    lista.Add(pesquisaFormatada);
            }

            return _moedaRepository.AddItemLista(lista);
        }

        public PesquisaModel GetItemFila()
        {
            return _moedaRepository.GetItemFila();
        }

        private PesquisaModel TransformaStringDate(PesquisaModelView pesquisa)
        {
            var dataInicio = DateTime.ParseExact(pesquisa.data_inicio, "yyyy-MM-dd", null);
            var dataFim = DateTime.ParseExact(pesquisa.data_fim, "yyyy-MM-dd", null);

            return new PesquisaModel(pesquisa.moeda, dataInicio, dataFim );
        }
    }
}
