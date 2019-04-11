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

        public void CriaPilhaVazia(int maxTam)
        {
            this.item = new Object[maxTam];
            this.topo = 0;
        }

        #region Métodos herdados da interface base
        public void Empilha(object x)
        {
            if (topo == item.Length)
                throw new Exception("Erro: A pilha está cheia.");
            else
                item[topo++] = x;
        }

        public object Desempilha()
        {
            if (IsPilhaVazia())
                throw new Exception("Erro: A pilha está vazia.");
            return item[--topo];
        }


        public bool IsPilhaVazia()
        {
            return (topo == 0);
        }

        public int Tamanho()
        {
            return topo;
        }
        #endregion

        public string VerificaCadeiaCaracteres(string stringInformada)
        {
            throw new NotImplementedException();
            //stringInformada.Split();
            //return null;
        }
    }
}
