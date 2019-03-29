using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatos
{
    public interface ILista
    {
        void CriaListaVazia(int maxTam);
        Object Pesquisa(Object chave);
        void Insere(Contato contato);
        Object Retira(Object chave);
        Object RetiraPrimeiro();
        Object Primeiro();
        bool IsListaVazia();
    }
}