using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatos
{
    public class ListaDeContatos : ILista
    {
        private Object[] item;
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

        public void Insere(Contato contato)
        {
            try
            {
                //////////-------------------CONFERIR COMO VOU PASSAR O TAMANHO DA LISTA
                //if (ultimo >= item.Length)
                //    throw new Exception("Erro: A lista está cheia.");
                //else
                //{
                    item[ultimo] = contato;
                    ultimo = ultimo + 1; //testar debugando se pode tirar o "this" e ter o mesmo resultado
                //}
            }
            catch (Exception e)
            {
                throw e;
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
                return null; //chave passada não foi encontrada

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
        #endregion
    }
}