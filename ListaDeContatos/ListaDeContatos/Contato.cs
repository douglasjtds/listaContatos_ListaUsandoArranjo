using System;

namespace ListaDeContatos
{
    public class Contato
    {
        public Guid ID_Contato { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
    }
}