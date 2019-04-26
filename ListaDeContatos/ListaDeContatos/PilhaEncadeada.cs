using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatos
{
    public class PilhaEncadeada : IPilhaEncadeada
    {
        public class Celula
        {
            internal Object item;
            internal Celula prox;
        }
        public Celula topo;
        private int tam;

        public void CriaPilhaVazia()
        {
            topo = null;
            tam = 0;
        }


        #region Métodos herdados da interface base
        public void Empilha(object x)
        {
            Celula aux = topo;
            topo = new Celula()
            {
                item = x,
                prox = aux
            };
            tam++;
        }

        public object Desempilha()
        {
            if (IsPilhaVazia())
                throw new Exception("Erro: A pilha está vazia.");
            Object item = topo.item;
            tam--;
            return item;
        }

        public bool IsPilhaVazia()
        {
            return (topo == null);
        }
        #endregion

        public int Tamanho()
        {
            return tam;
        }
    }
}
