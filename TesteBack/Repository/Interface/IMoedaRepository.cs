using System.Collections.Generic;
using TesteBack.Model;

namespace TesteBack.Repository.Interface
{
    public interface IMoedaRepository
    {
        bool AddItemLista(List<PesquisaModel> pesquisa);
        PesquisaModel GetItemFila();
    }
}
