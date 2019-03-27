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
            ultimo = this.primeiro;
        }


        #region Métodos herdados da interface base
        public object Pesquisa(object chave)
        {
            if (this.IsListaVazia() || chave == null)
                return null;

            for (int p = 0; p < this.ultimo; p++) //percorre a lista
            {
                if (this.item[p].Equals(chave))
                    return this.item[p]; //retorna o item encontrado
            }
            return null;
        }

        public void Insere(Contato contato)
        {
            try
            {
                if (this.ultimo >= this.item.Length)
                    throw new Exception("Erro: A lista está cheia.");
                else
                {
                    this.item[this.ultimo] = contato;
                    this.ultimo = this.ultimo + 1; //testar debugando se pode tirar o "this" e ter o mesmo resultado
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public object Retira(object chave)
        {
            if (this.IsListaVazia() || chave == null)
                throw new Exception("Erro : A lista esta vazia");

            int p = 0;
            while (p < this.ultimo && !this.item[p].Equals(chave))
                p++;

            if (p >= this.ultimo)
                return null; //chave passada não foi encontrada

            Object item = this.item[p];
            this.ultimo = this.ultimo - 1;

            for (int aux = p; aux < this.ultimo; aux++)
                this.item[aux] = this.item[aux + 1];

            return item;

        }

        public object RetiraPrimeiro()
        {
            if (this.IsListaVazia())
                throw new Exception("Erro : A lista esta vazia");

            Object item = this.item[0];
            this.ultimo = this.ultimo - 1;

            for (int aux = 0; aux < this.ultimo; aux++)
                this.item[aux] = this.item[aux + 1];

            return item;
        }

        public object Primeiro()
        {
            this.pos = -1;
            return this.Proximo();
        }

        public bool IsListaVazia()
        {
            return (this.primeiro == this.ultimo);
        }
        #endregion

        #region Outros métodos que não estão na interface
        //completando com outros métodos 
        public object Proximo()
        {
            this.pos++;
            if (this.pos >= this.ultimo)
                return null;
            else
                return this.item[this.pos];
        }

        public void Imprime()
        {
            for (int aux = this.primeiro; aux < this.ultimo; aux++)
                Console.WriteLine(this.item[aux].ToString());
        }


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