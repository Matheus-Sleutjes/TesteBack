using System;
using TesteBack.Enum;

namespace TesteBack.Model
{
    public class PesquisaModel
    {
        public PesquisaModel(string moeda, DateTime datainicio, DateTime dataFim)
        {
            Moeda = moeda;
            DataInicio = datainicio;
            DataFim = dataFim;
            Excluido = false;
            DataPesquisa = DateTime.Now;
        }

        public string Moeda { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool Excluido { get; set; }
        public DateTime DataPesquisa { get; set; } 
    }
}
