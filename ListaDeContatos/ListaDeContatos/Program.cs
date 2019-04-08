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
        private static Lista listaDeContato;
        private static ListaEncadeada listaDeContatosEncadeada;
        //private static Contato contato;

        static void Main(string[] args)
        {
            #region [Escolha do tipo de lista a ser utilizada]
            int tipoDeLista;

            do
            {
                Console.Clear();
                Console.WriteLine("------[Trabalho de AEDs]------");
                Console.WriteLine("\n");
                Console.WriteLine("[ 1 ] Lista Comum");
                Console.WriteLine("[ 2 ] Lista Encadeada (com auto-referenciamento)");

                Console.WriteLine("\n");

                Console.WriteLine("[ 0 ] Sair do Programa");
                Console.WriteLine("-------------------------------------");
                Console.Write("Escolha o tipo de lista que deseja utilizar: ");
                tipoDeLista = Int32.Parse(Console.ReadLine());
                switch (tipoDeLista)
                {
                    case 1:
                        escolheuListaComum();
                        break;
                    case 2:
                        escolheuListaEncadeada();
                        break;
                    default:
                        saiPrograma();
                        break;
                }

            } while (tipoDeLista != 0); 
            #endregion
        }

        public static void escolheuListaComum()
        {
            #region [Estrutura de repetição para escolha da atividade a ser executada.]
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("------[Lista de Contatos]------");
                Console.WriteLine("\n");
                Console.WriteLine("[ 1 ] Nova Lista");
                Console.WriteLine("[ 2 ] Novo Contato");
                Console.WriteLine("[ 3 ] Remover Contato");
                Console.WriteLine("[ 4 ] Editar Contato");
                Console.WriteLine("[ 5 ] Ver Contato");
                Console.WriteLine("[ 6 ] Ver Lista (Imprime todos os Contatos)");
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

        public Program()
        {
            listaDeContato = new Lista();
            //contato = new Contato();
        }

        public static void escolheuListaEncadeada()
        {
            #region [Estrutura de repetição para escolha da atividade a ser executada.]
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("------[Lista de Contatos - Encadeada]------");
                Console.WriteLine("\n");
                Console.WriteLine("[ 1 ] Nova Lista Encadeada");
                Console.WriteLine("[ 2 ] Novo Contato");
                Console.WriteLine("[ 3 ] Remover Contato");
                Console.WriteLine("[ 4 ] Editar Contato");
                Console.WriteLine("[ 5 ] Ver Contato");
                Console.WriteLine("[ 6 ] Ver Lista Encadeada (Imprime todos os Contatos)");
                Console.WriteLine("\n");

                Console.WriteLine("[ 0 ] Sair do Programa");
                Console.WriteLine("-------------------------------------");
                Console.Write("Escolha a atividade a ser executada: ");

                opcao = Int32.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        criaLista_Encadeada();
                        break;
                    case 2:
                        novoContato_Encadeada();
                        break;
                    case 3:
                        removerContato_Encadeada();
                        break;
                    case 4:
                        editarContato_Encadeada();
                        break;
                    case 5:
                        verContato_Encadeada();
                        break;
                    case 6:
                        imprimirTodosOsContatos_Encadeada();
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

        //public static void escolheuPilhaComArranjo()
        //{
        //    Console.WriteLine("Ainda não implementada.");
        //}

        #region ------Lista Comum------
        #region [Criar lista]
        /// <summary>
        /// Atividade 1: 
        /// </summary>
        private static void criaLista()
        {
            Console.Clear();
            Console.Write("[Nova Lista]");
            Console.WriteLine("\n");

            listaDeContato = new Lista();

            Console.WriteLine("Será criada uma nova lista de contatos...");
            Console.WriteLine("Escolha o tamanho desejado para essa lista: ");
            var maxTam = Int32.Parse(Console.ReadLine());
            listaDeContato.CriaListaVazia(maxTam);

            Thread.Sleep(500);
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

            var contato = new Contato();

            Console.WriteLine("Entre com os dados do novo contato a ser adicionado na lista...");
            Thread.Sleep(1000);

            Console.Write("Nome: ");
            contato.Nome = Console.ReadLine();

            Console.Write("Telefone: ");
            contato.Telefone = Int32.Parse(Console.ReadLine());

            Console.Write("Email: ");
            contato.Email = Console.ReadLine();

            contato.ID_Contato = Guid.NewGuid();

            listaDeContato.Insere(contato);

            Console.WriteLine("O contato {0} foi inserido com sucesso.", contato.Nome);
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

            //var contato = new Contato();
            string nomeDoContato;

            Console.Write("Entre com o nome do contato que deseja remover da lista: ");
            //contato.Nome = Console.ReadLine();
            nomeDoContato = Console.ReadLine();
            //listaDeContato.Retira(contato);

            listaDeContato.Retira(nomeDoContato);

            Console.WriteLine("\n");
            Console.WriteLine("O contato {0} será removido.", listaDeContato.item);
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

            //var listaDeContato = new Lista();
            string nomeDoContato;
            var contato = new Contato();

            Console.Write("Entre com o nome do contato que deseja pesquisar: ");
            nomeDoContato = Console.ReadLine();

            listaDeContato.Pesquisa(nomeDoContato);

            Thread.Sleep(2000);

            Console.WriteLine("\n");

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

            while (!listaDeContato.IsListaVazia())
                listaDeContato.Imprime();
        }
        #endregion
        #endregion

        #region ------Lista Encadeada------

        #region [Criar lista Encadeada]
        /// <summary>
        /// Atividade 1: 
        /// </summary>
        private static void criaLista_Encadeada()
        {
            Console.Clear();
            Console.Write("[Nova Lista Encadeada]");
            Console.WriteLine("\n");

            listaDeContatosEncadeada = new ListaEncadeada();

            Console.WriteLine("Será criada uma nova lista encadeada de contatos...");
            //Console.WriteLine("Escolha o tamanho desejado para essa lista: ");
            //var maxTam = Int32.Parse(Console.ReadLine());
            listaDeContatosEncadeada.CriaListaVazia();

            Thread.Sleep(500);
            Console.WriteLine("A lista encadeada de contatos foi criada.");
        }
        #endregion

        #region [Novo Contato Encadeada]
        /// <summary>
        /// Atividade 2: 
        /// </summary>
        private static void novoContato_Encadeada()
        {
            Console.Clear();
            Console.Write("[Novo Contato]");
            Console.WriteLine("\n");

            var contato = new Contato();

            Console.WriteLine("Entre com os dados do novo contato a ser adicionado na lista...");
            Thread.Sleep(1000);

            Console.Write("Nome: ");
            contato.Nome = Console.ReadLine();

            Console.Write("Telefone: ");
            contato.Telefone = Int32.Parse(Console.ReadLine());

            Console.Write("Email: ");
            contato.Email = Console.ReadLine();

            contato.ID_Contato = Guid.NewGuid();

            listaDeContatosEncadeada.Insere(contato);

            Console.WriteLine("\n");
            Console.WriteLine("O contato {0} foi inserido com sucesso.", contato.Nome);
        }
        #endregion

        #region [Remover Contato Encadeada]
        /// <summary>
        /// Atividade 3: 
        /// </summary>
        private static void removerContato_Encadeada()
        {
            Console.Clear();
            Console.Write("[Remover Contato]");
            Console.WriteLine("\n");

            //var contato = new Contato();
            string nomeDoContato;

            Console.Write("Entre com o nome do contato que deseja remover da lista: ");
            //contato.Nome = Console.ReadLine();
            nomeDoContato = Console.ReadLine();
            //listaDeContato.Retira(contato);
            listaDeContatosEncadeada.Retira(nomeDoContato);

            Console.WriteLine("\n");
            Console.WriteLine("O contato {0} será removido.", listaDeContato.item);
        }
        #endregion

        #region [Editar Contato Encadeada]
        /// <summary>
        /// Atividade 4: 
        /// </summary>
        public static void editarContato_Encadeada()
        {
            Console.Clear();
            Console.Write("[Editar Contato]");
            Console.WriteLine("\n");


        }
        #endregion

        #region [Ver Contato Encadeada]
        /// <summary>
        /// Atividade 5: 
        /// </summary>
        public static void verContato_Encadeada()
        {
            Console.Clear();
            Console.Write("[Ver Contato]");
            Console.WriteLine("\n");

            //var listaDeContatoEncadeada = new Lista();
            var contato = new Contato();
            string nomeContato;

            Console.Write("Entre com o nome do contato que deseja pesquisar: ");
            nomeContato = Console.ReadLine();

            listaDeContatosEncadeada.Pesquisa(nomeContato);

            Thread.Sleep(2000);

            Console.WriteLine("Nome: {0}", contato.Nome);
            Console.WriteLine("Telefone: {0}", contato.Telefone);
            Console.WriteLine("Email: {0}", contato.Email);
        }
        #endregion

        #region [Imprimir todos os Contatos Encadeada]
        /// <summary>
        /// Atividade 6: 
        /// </summary>
        public static void imprimirTodosOsContatos_Encadeada()
        {
            Console.Clear();
            Console.Write("[Imprimir todos os Contatos]");
            Console.WriteLine("\n");

            Console.WriteLine("Lista de contatos: ");
            Console.WriteLine("\n");

            while (!listaDeContatosEncadeada.IsListaVazia())
                listaDeContatosEncadeada.Imprime();
        }
        #endregion

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