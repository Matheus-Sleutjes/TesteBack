using System;
using System.Collections.Generic;
using TesteBack.Repository.Interface;

namespace TesteBack.Repository
{
    public class DominioJson<T> : IDominioJson<T>, IDisposable where T : class
    {
        public void Edicao(List<T> Listar, string nome, string webRoot)
        {
            throw new NotImplementedException();
        }

        public List<T> Listar(string nome, string webRoot)
        {
            throw new NotImplementedException();
        }

        public bool Salvar(T Objeto, string nome, string webRoot)
        {
            throw new NotImplementedException();
        }

        public bool ValidaArquivo(string nome, string webRoot)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
