using System.Text.Json;
using TesteBack.Service.Interface;

namespace TesteBack.Service
{
    public class Converter : IConverter
    {
        public string ConverteObjectParaJSon<T>(T obj)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                return JsonSerializer.Serialize(obj, options);
            }
            catch
            {
                throw;
            }
        }
        public T ConverteJSonParaObject<T>(string jsonString)
        {
            try
            {
                return JsonSerializer.Deserialize<T>(jsonString);
            }
            catch
            {
                throw;
            }
        }
    }
}
