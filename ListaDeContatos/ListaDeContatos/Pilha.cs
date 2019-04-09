using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatos
{
    public class Pilha : IPilha
    {
        private Object[] item;
        private int topo;

        public void criaPilhaVazia(int maxTam)
        {
            this.item = new Object[maxTam];
            this.topo = 0;
        }

        #region Métodos herdados da interface base
        public void Empilha(object x)
        {
            //throw new NotImplementedException();
            if (topo == item.Length)
                throw new Exception("Erro: A pilha está cheia.");
            else
                item[topo++] = x;
        }

        public object Desempilha()
        {
            //throw new NotImplementedException();
            if (IsPilhaVazia())
                throw new Exception("Erro: A pilha está vazia.");
            return item[--topo];
        }


        public bool IsPilhaVazia()
        {
            //throw new NotImplementedException();
            return (topo == 0);
        }

        public int Tamanho()
        {
            //throw new NotImplementedException();
            return topo;
        }
        #endregion
    }
}
