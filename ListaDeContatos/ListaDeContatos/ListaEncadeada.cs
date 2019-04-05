using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatos
{
    public class ListaEncadeada : IListaEncadeada  //utilizando auto-referenciamento (exemplo Aula 4)
    {
        //cria lista vazia
        public void CriaListaVazia()
        {
            //throw new NotImplementedException();
            //var celula = new Celula();
            //celula.primeiro = null;
            //celula.pos =
            //this.primeiro = new Celula();
            //this.pos = this.primeiro;
            //this.ultimo = this.primeiro; this.primeiro.prox = null;
        }

        #region Métodos herdados da interface
        public object Pesquisa(object chave)
        {
            //if (IsListaVazia() || chave == null)
            //    return null;

            //Celula aux = primeiro;
            //while (aux.prox)
            throw new NotImplementedException();
        }

        public void Insere(object x)
        {
            throw new NotImplementedException();
            //this.ultimo.prox = new Celula();
            //this.ultimo = this.ultimo.prox;
            //this.ultimo.item = x; this.ultimo.prox = null;
        }

        public object Retira(object chave)
        {
            throw new NotImplementedException();
            // if (this.vazia() | | (chave == null))
            //     throw new Exception
            //     ("Erro : Lista vazia ou chave invalida");
            // Celula aux = this.primeiro;
            // while (aux.prox != null && !aux.prox.item.equals(chave))
            //     aux = aux.prox;
            // if (aux.prox == null) return null; / / não encontrada
            //Celula q = aux.prox;
            // Object item = q.item; aux.prox = q.prox;
            // if (aux.prox == null) this.ultimo = aux; return item;
        }

        public object RetiraPrimeiro()
        {
            throw new NotImplementedException();
            //if (this.vazia())
            //    throw new Exception("Erro : Lista vazia");
            //Celula aux = this.primeiro; Celula q = aux.prox;
            //Object item = q.item; aux.prox = q.prox;
            //if (aux.prox == null) this.ultimo = aux; return item;
        }
        public object Primeiro()
        {
            throw new NotImplementedException();
            //this.pos = primeiro;
            //return proximo();
        }

        public bool IsListaVazia()
        {
            throw new NotImplementedException();
            //return (this.primeiro == this.ultimo);
        }
        #endregion

        public Object Proximo()
        {
            throw new NotImplementedException();
            //this.pos = this.pos.prox;
            //if (this.pos == null) return null;
            //else return this.pos.item;
        }

        public void Imprime()
        {
            //Celula aux = this.primeiro.prox;
            //while (aux != null)
            //{
            //    Console.WriteLine(aux.item.toString());
            //    aux = aux.prox;
            //}
        }
    }
}