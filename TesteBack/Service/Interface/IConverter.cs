using System.Collections.Generic;
using TesteBack.Model;

namespace TesteBack.Service.Interface
{
    public interface IConverter
    {
        string ConverteObjectParaJSon<T>(T obj);
        List<PesquisaModel> ConverteJSonParaObject(string filePath);
    }
}
