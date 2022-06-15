using System.Collections.Generic;
using TesteBack.Model;

namespace TesteBack.Service.Interface
{
    public interface IMoedaService
    {
        bool AdditemFila(PesquisaModel pesquisa);
        List<MoedaModel> GetItemFile();
    }
}
