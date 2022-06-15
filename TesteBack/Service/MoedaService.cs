using System.Collections.Generic;
using TesteBack.Model;
using TesteBack.Service.Interface;

namespace TesteBack.Service
{
    public class MoedaService : IMoedaService
    {
        public MoedaService() { }

        public bool AdditemFila(PesquisaModel pesquisa)
        {
            return true;
        }

        public List<MoedaModel> GetItemFile()
        {
            return new List<MoedaModel>();
        }
    }
}
