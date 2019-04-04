using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatos
{
    public class Lista : ILista
    {
        public Object[] item;
        private int primeiro, ultimo, pos;

        //cria lista vazia
        public void CriaListaVazia(int maxTam)
        {
            item = new Object[maxTam];
            pos = -1;
            primeiro = 0;
            ultimo = primeiro;
        }


        #region [Atividade 1] - Métodos herdados da interface base
        public object Pesquisa(object chave)
        {
            if (IsListaVazia() || chave == null)
                return null;

            for (int p = 0; p < ultimo; p++) //percorre a lista
            {
                if (item[p].Equals(chave))
                    return item[p]; //retorna o item encontrado
            }
            return null;
        }

        public void Insere(Object chave)
        {
            try
            {
                //////////-------------------CONFERIR COMO VOU PASSAR O TAMANHO DA LISTA
                if (ultimo >= item.Length)
                    throw new Exception("Erro: A lista está cheia.");
                else
                {
                    item[ultimo] = chave;
                    ultimo = ultimo + 1;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public object Retira(object chave)
        {
            if (IsListaVazia() || chave == null)
                throw new Exception("Erro : A lista esta vazia");

            int p = 0;
            while (p < ultimo && !this.item[p].Equals(chave))
                p++;

            if (p >= ultimo)
                return null;

            Object item = this.item[p];
            ultimo = ultimo - 1;

            for (int aux = p; aux < ultimo; aux++)
                this.item[aux] = this.item[aux + 1];

            return item;

        }

        public object RetiraPrimeiro()
        {
            if (IsListaVazia())
                throw new Exception("Erro : A lista esta vazia");

            Object item = this.item[0];
            ultimo = ultimo - 1;

            for (int aux = 0; aux < ultimo; aux++)
                this.item[aux] = this.item[aux + 1];

            return item;
        }

        public object Primeiro()
        {
            pos = -1;
            return Proximo(); 
        }

        public bool IsListaVazia()
        {
            return (primeiro == ultimo);
        }
        #endregion

        #region Outros métodos que não estão na interface
        //completando com outros métodos
        public object Proximo()
        {
            pos++;
            if (pos >= ultimo)
                return null;
            else
                return item[pos];
        }

        public void Imprime()
        {
            for (int aux = primeiro; aux < ultimo; aux++)
                Console.WriteLine(item[aux].ToString());
        }


        #region [Atividade 3]
        public object RetiraUltimo()
        {
            if (IsListaVazia())
                throw new Exception("Erro: Lista Vazia.");
            ultimo--;
            return null;
        }

        public int Ultimo()
        {
            return ultimo;
        }

        public int TamanhoLista()
        {
            return item.Length;
        }

        public void Insere(Object x, Object chave)
        {
            //Object objetoAux = null;
            if(ultimo >= item.Length)
                Console.WriteLine("Lista cheia!");
            else
            {
                for (int chaveAux = ultimo; chaveAux > Convert.ToInt32(chave); chaveAux--)
                    item[chaveAux] = item[chaveAux - 1];

                item[Convert.ToInt32(chave)] = x;
                ultimo = ultimo + 1;
            }
        }

        public object Concatenar(Object[] objA, Object[] objB)
        {
            Object[] objConcat = new Object[objA.Length + objB.Length];

            for (int i = 0; i < objA.Length; i++)
                objConcat[i] = objA[i];
            for (int j = objA.Length; j < objConcat.Length; j++)
                objConcat[j] = objB[j];

            return objConcat;
        }

        public void Copia(Object [] obj) //CONFERIR COMO SERIA ESSA COPIA
        {
            Object[] objCopiado = new Object[item.Length];
            for (int i = 0; i > obj.Length; i++)
                objCopiado[i] = obj; 
        } 
        #endregion
        #endregion
    }
}