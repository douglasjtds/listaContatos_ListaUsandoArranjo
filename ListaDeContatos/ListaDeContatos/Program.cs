using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ListaDeContatos
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region [Estrutura de repetição para escolha da atividade a ser executada.]
            int opcao;
            do
            {
                Console.WriteLine("------[Lista de Contatos]------");
                Console.WriteLine("\n");
                Console.WriteLine("[ 1 ] Nova Lista");
                Console.WriteLine("[ 2 ] Novo Contato");
                Console.WriteLine("[ 3 ] Remover Contato");
                Console.WriteLine("[ 4 ] Editar Contato");
                Console.WriteLine("[ 5 ] Ver Contato");
                Console.WriteLine("[ 6 ] Imprimir todos os Contatos");
                Console.WriteLine("\n");

                Console.WriteLine("[ 0 ] Sair do Programa");
                Console.WriteLine("-------------------------------------");
                Console.Write("Escolha a atividade a ser executada: ");

                opcao = Int32.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        criaLista();
                        break;
                    case 2:
                        novoContato();
                        break;
                    case 3:
                        removerContato();
                        break;
                    case 4:
                        editarContato();
                        break;
                    case 5:
                        verContato();
                        break;
                    case 6:
                        imprimirTodosOsContatos();
                        break;

                    default:
                        saiPrograma();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (opcao != 0);
            #endregion
        }


        #region [Criar lista]
        /// <summary>
        /// Atividade 1: 
        /// </summary>
        private static void criaLista()
        {
            Console.Clear();
            Console.Write("[Nova Lista]");
            Console.WriteLine("\n");

            var listaDeContato = new ListaDeContatos();

            Console.WriteLine("Será criada uma nova lista de contatos...");
            Console.WriteLine("Escolha o tamanho desejado para essa lista: "); //o usuário que passa esse tamanho mesmo?
            var maxTam = Int32.Parse(Console.ReadLine());
            listaDeContato.CriaListaVazia(maxTam);

            Thread.Sleep(2000);
            Console.WriteLine("A lista de contatos foi criada, com capacidade para {0} contatos.", maxTam);
        }
        #endregion

        #region [Novo Contato]
        /// <summary>
        /// Atividade 2: 
        /// </summary>
        private static void novoContato()
        {
            Console.Clear();
            Console.Write("[Novo Contato]");
            Console.WriteLine("\n");

            var listaDeContato = new ListaDeContatos();
            var contato = new Contato();

            Console.WriteLine("Entre com os dados do novo contato a ser adicionado na lista...");
            Thread.Sleep(1000);

            Console.WriteLine("Nome: ");
            contato.Nome = Console.ReadLine();

            Console.WriteLine("Telefone: ");
            contato.Telefone = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Email: ");
            contato.Email = Console.ReadLine();

            contato.ID_Contato = Guid.NewGuid();

            listaDeContato.Insere(contato);

            //pra testar
            listaDeContato.IsListaVazia();
        }
        #endregion

        #region [Remover Contato]
        /// <summary>
        /// Atividade 3: 
        /// </summary>
        private static void removerContato()
        {
            Console.Clear();
            Console.Write("[Remover Contato]");
            Console.WriteLine("\n");

            var listaDeContato = new ListaDeContatos();
            var contato = new Contato();

            Console.WriteLine("Entre com o nome do contato que deseja remover da lista: ");
            contato.Nome = Console.ReadLine();
            listaDeContato.Retira(contato);
        }
        #endregion

        #region [Editar Contato]
        /// <summary>
        /// Atividade 4: 
        /// </summary>
        public static void editarContato()
        {
            Console.Clear();
            Console.Write("[Editar Contato]");
            Console.WriteLine("\n");


        }
        #endregion


        #region [Ver Contato]
        /// <summary>
        /// Atividade 5: 
        /// </summary>
        public static void verContato()
        {
            Console.Clear();
            Console.Write("[Ver Contato]");
            Console.WriteLine("\n");

            var listaDeContato = new ListaDeContatos();
            var contato = new Contato();

            Console.WriteLine("Entre com o nome do contato que deseja pesquisar: ");
            contato.Nome = Console.ReadLine();

            listaDeContato.Pesquisa(contato.Nome);

            Thread.Sleep(2000);

            Console.WriteLine("Nome: {0}", contato.Nome);
            Console.WriteLine("Telefone: {0}", contato.Telefone);
            Console.WriteLine("Email: {0}", contato.Email);
        }
        #endregion

        #region [Imprimir todos os Contatos]
        /// <summary>
        /// Atividade 6: 
        /// </summary>
        public static void imprimirTodosOsContatos()
        {
            Console.Clear();
            Console.Write("[Imprimir todos os Contatos]");
            Console.WriteLine("\n");

            Console.WriteLine("Lista de contatos: ");
            Console.WriteLine("\n");
        }
        #endregion

        #region para fechar o programa

        private static void saiPrograma()
        {
            Console.WriteLine();
            Console.WriteLine("Você saiu do programa. Clique qualquer tecla para fechar...");
        }
        #endregion
    }
}