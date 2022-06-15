namespace TesteBack.Service.Interface
{
    public interface IConverter
    {
        string ConverteObjectParaJSon<T>(T obj);
        T ConverteJSonParaObject<T>(string jsonString);
    }
}
