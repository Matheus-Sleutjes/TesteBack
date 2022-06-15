using TesteBack.Model;
using TesteBack.Repository.Interface;
using TesteBack.Service.Interface;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TesteBack.Repository
{
    public class MoedaRepository : IMoedaRepository
    {
        private readonly string filePath = @"C:\Users\Public\bd.json";
        private readonly IConverter _converter;
        public MoedaRepository(IConverter converter)
        {
            _converter = converter;
        }

        public bool AddItemLista(PesquisaModel pesquisa)
        {
            var json = _converter.ConverteObjectParaJSon(pesquisa);
            var retorno = this.SalvarItem(json);

            return retorno;
        }

        private bool SalvarItem(string json)
        {
            try
            {
                //using (var sw = new StreamWriter(this.filePath))
                //{
                //    sw.Write(json);
                //}

                using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
                {
                    var writer = new JsonTextWriter();
                }
                    return true;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        private PesquisaModel GetLista(string json)
        {
            dynamic pesquisaModel = JsonConvert.DeserializeObject(File.ReadAllText(json));
            return pesquisaModel;   
        }
    }
}
