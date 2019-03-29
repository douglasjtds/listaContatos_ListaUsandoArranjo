using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatos
{
    public class ListaEncadeada : IListaEncadeada  //utilizando auto-referenciamento (exemplo Aula 4)
    {
        public void Insere(object x)
        {
            throw new NotImplementedException();
        }

        public bool IsListaVazia()
        {
            throw new NotImplementedException();
        }

        public void Pesquisa(object chave)
        {
            throw new NotImplementedException();
        }

        public object Primeiro()
        {
            throw new NotImplementedException();
        }

        public object Retira(object chave)
        {
            throw new NotImplementedException();
        }

        public object RetiraPrimeiro()
        {
            throw new NotImplementedException();
        }
    }
}