using System.Collections.Generic;
using System.IO;
using System.Linq;
using TesteBack.Model;
using TesteBack.Repository.Interface;
using TesteBack.Service.Interface;

namespace TesteBack.Repository
{
    public class MoedaRepository : IMoedaRepository
    {
        private readonly string filePath = "db.json";
        private readonly IConverter _converter;
        public MoedaRepository(IConverter converter)
        {
            _converter = converter;
        }

        public bool AddItemLista(List<PesquisaModel> pesquisa)
        {
            var lista = new List<PesquisaModel>(GetDB());

            foreach(var item in pesquisa)
                lista.Add(item);

            return this.SaveBD(lista);
        }

        public PesquisaModel GetItemFila()
        {
            var lista = new List<PesquisaModel>(GetDB());

            return DeleteDB(lista);
        }

        private bool SaveBD(List<PesquisaModel> lista)
        {
            try
            {
                var json = _converter.ConverteObjectParaJSon(lista);
                File.WriteAllText(this.filePath, json);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        private List<PesquisaModel> GetDB()
        {
            return _converter.ConverteJSonParaObject(this.filePath);
        }

        private PesquisaModel DeleteDB(List<PesquisaModel> lista)
        {
            var obj = lista.Where(t => !t.Excluido).LastOrDefault();

            if(obj == null)
                return null;

            lista.Remove(obj);
            obj.Excluido = true;
            lista.Add(obj);

            this.SaveBD(lista);

            return obj;
        }
    }
}
