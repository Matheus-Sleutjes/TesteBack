using System.Collections.Generic;
using TesteBack.Model;
using TesteBack.Service.Interface;
using System.Text.Json;
using System.IO;

namespace TesteBack.Service
{
    public class Converter : IConverter
    {
        public string ConverteObjectParaJSon<T>(T obj)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                var retorno = JsonSerializer.Serialize(obj, options);
                return retorno;
            }
            catch
            {
                throw;
            }
        }
        public List<PesquisaModel> ConverteJSonParaObject(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);

                if(jsonString == "")
                    return new List<PesquisaModel>();

                return JsonSerializer.Deserialize<List<PesquisaModel>>(jsonString);
            }
            catch
            {
                throw;
            }
        }
    }
}
