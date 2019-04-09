using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatos
{
    public class PilhaEncadeada : IPilhaEncadeada
    {
        #region Métodos herdados da interface base
        public object Desempilha()
        {
            throw new NotImplementedException();
        }

        public void Empilha(object x)
        {
            throw new NotImplementedException();
        }

        public bool IsPilhaVazia()
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
