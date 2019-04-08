using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatos
{
    public class ListaEncadeada : IListaEncadeada  //utilizando auto-referenciamento (exemplo Aula 4)
    {
        public class Celula
        {
            internal object primeiro;
            internal Celula pos;
            internal Object item;
            internal Celula prox;
        }
        public Celula primeiro, ultimo, pos;

        public void CriaListaVazia()
        {
            var celula = new Celula();
            celula.primeiro = null;
            celula.pos =
            primeiro = new Celula();
            pos = primeiro;
            ultimo = primeiro; primeiro.prox = null;
        }

        #region Métodos herdados da interface
        public object Pesquisa(object chave)
        {
            if (IsListaVazia() || chave == null)
                return null;

            Celula aux = primeiro;
            while (aux.prox != null)
            {
                if (((Contato)(aux.prox.item)).Nome.Equals(chave))
                    return aux.prox.item;
                aux = aux.prox;
            }
            return null;
        }

        public void Insere(object x)
        {
            this.ultimo.prox = new Celula();
            this.ultimo = this.ultimo.prox;
            this.ultimo.item = x; this.ultimo.prox = null;
        }

        public object Retira(object chave)
        {
            if (IsListaVazia() || (chave == null))
                throw new Exception
                ("Erro : Lista vazia ou chave invalida");
            Celula aux = this.primeiro;
            while (aux.prox != null && !((Contato)(aux.prox.item)).Nome.Equals(chave))
                aux = aux.prox;
            if (aux.prox == null) return null; // não encontrada
            Celula q = aux.prox;
            Object item = q.item; aux.prox = q.prox;
            if (aux.prox == null) this.ultimo = aux; return item;
        }

        public object RetiraPrimeiro()
        {
            if (IsListaVazia())
                throw new Exception("Erro : Lista vazia");
            Celula aux = primeiro; Celula q = aux.prox;
            Object item = q.item; aux.prox = q.prox;
            if (aux.prox == null)
                ultimo = aux; return item;
        }
        public object Primeiro()
        {
            pos = primeiro;
            return Proximo();
        }

        public bool IsListaVazia()
        {
            return (primeiro == ultimo);
        }
        #endregion

        public Object Proximo()
        {
            pos = pos.prox;
            if (pos == null) return null;
            else return pos.item;
        }

        public void Imprime()
        {
            Celula aux = this.primeiro.prox;
            while (aux != null)
            {
                Console.WriteLine(aux.item.ToString());
                aux = aux.prox;
            }
        }
    }
}