using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatos
{
    public interface IPilhaEncadeada
    {
        void Empilha(Object x);
        Object Desempilha();
        bool IsPilhaVazia();
        //int Tamanho();
    }
}