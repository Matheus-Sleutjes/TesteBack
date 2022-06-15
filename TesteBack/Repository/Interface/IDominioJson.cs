using System.Collections.Generic;

namespace TesteBack.Repository.Interface
{
    public interface IDominioJson<T> where T : class
    {
        bool ValidaArquivo(string nome, string webRoot);
        bool Salvar(T Objeto, string nome, string webRoot);
        List<T> Listar(string nome, string webRoot);
        void Edicao(List<T> Listar, string nome, string webRoot);

    }
}
