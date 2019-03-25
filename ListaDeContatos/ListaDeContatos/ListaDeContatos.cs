using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatos
{
    public class ListaDeContatos : ILista
    {
        #region Métodos herdados da interface base
        public void Pesquisa(object chave)
        {
            throw new NotImplementedException();
        }

        public void Insere(object x)
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

        public object Primeiro()
        {
            throw new NotImplementedException();
        }

        public bool IsListaVazia()
        {
            throw new NotImplementedException();
        } 
        #endregion

        #region Outros métodos que não estão na interface
        //completando com outros métodos 
        public object RetiraUltimo()
        {
            throw new NotImplementedException();
        }

        public object Ultimo()
        {
            throw new NotImplementedException();
        }

        public object TamanhoLista()
        {
            throw new NotImplementedException();
        }

        public object Insere(Object x, Object chave)
        {
            throw new NotImplementedException();
        }

        public object Concatenar(Object[] itens)
        {
            throw new NotImplementedException();
        }

        public object Copia(Object item)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
