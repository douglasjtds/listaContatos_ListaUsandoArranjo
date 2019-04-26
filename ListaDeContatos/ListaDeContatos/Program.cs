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
        private static Pilha pilhaDeContatos;
        private static PilhaEncadeada pilhaDeContatosEncadeada;
        //private static Contato contato;

        static void Main(string[] args)
        {
            #region [Escolha do tipo de estrutura de dados a ser utilizada]
            int tipoDeLista;

            do
            {
                Console.Clear();
                Console.WriteLine("------[Trabalho de AEDs]------");
                Console.WriteLine("\n");
                Console.WriteLine("[ 1 ] Lista Comum");
                Console.WriteLine("[ 2 ] Lista Encadeada (com auto-referenciamento)");
                Console.WriteLine("[ 3 ] Pilha Comum");
                Console.WriteLine("[ 4 ] Pilha Encadeada (com auto-referenciamento)");

                Console.WriteLine("\n");

                Console.WriteLine("[ 0 ] Sair do Programa");
                Console.WriteLine("-------------------------------------");
                Console.Write("Escolha o Tipo Abstrato de Dados que deseja utilizar: ");
                tipoDeLista = Int32.Parse(Console.ReadLine());
                switch (tipoDeLista)
                {
                    case 1:
                        EscolheuListaComum();
                        break;
                    case 2:
                        EscolheuListaEncadeada();
                        break;
                    case 3:
                        EscolheuPilhaComArranjo();
                        break;
                    case 4:
                        EscolheuPilhaEncadeada();
                        break;
                    default:
                        SaiPrograma();
                        break;
                }

            } while (tipoDeLista != 0);
            #endregion
        }

        public static void EscolheuListaComum()
        {
            #region [Lista Comum - Estrutura de repetição para escolha da atividade a ser executada.]
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

                Console.WriteLine("[ 0 ] Voltar para o menu anterior.");
                Console.WriteLine("-------------------------------------");
                Console.Write("Escolha a atividade a ser executada: ");

                opcao = Int32.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        CriaLista();
                        break;
                    case 2:
                        NovoContato();
                        break;
                    case 3:
                        RemoverContato();
                        break;
                    case 4:
                        EditarContato();
                        break;
                    case 5:
                        VerContato();
                        break;
                    case 6:
                        ImprimirTodosOsContatos();
                        break;

                    default:
                        SaiPrograma();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (opcao != 0);
            #endregion
        }

        public static void EscolheuListaEncadeada()
        {
            #region [Lista Encadeada - Estrutura de repetição para escolha da atividade a ser executada.]
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

                Console.WriteLine("[ 0 ] Voltar para o menu anterior.");
                Console.WriteLine("-------------------------------------");
                Console.Write("Escolha a atividade a ser executada: ");

                opcao = Int32.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        CriaLista_Encadeada();
                        break;
                    case 2:
                        NovoContato_Encadeada();
                        break;
                    case 3:
                        RemoverContato_Encadeada();
                        break;
                    case 4:
                        EditarContato_Encadeada();
                        break;
                    case 5:
                        VerContato_Encadeada();
                        break;
                    case 6:
                        ImprimirTodosOsContatos_Encadeada();
                        break;

                    default:
                        SaiPrograma();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (opcao != 0);
            #endregion
        }

        public static void EscolheuPilhaComArranjo()
        {
            #region [Pilha Comum - Estrutura de repetição para escolha da atividade a ser executada.]
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("------[Pilha de Contatos]------");
                Console.WriteLine("\n");
                Console.WriteLine("[ 1 ] Nova Pilha");
                Console.WriteLine("[ 2 ] Empilhar - Novo Contato");
                Console.WriteLine("[ 3 ] Desempilhar Contato");
                //Console.WriteLine("[ 4 ] Editar Contato");
                //Console.WriteLine("[ 5 ] Ver Contato");
                //Console.WriteLine("[ 6 ] Ver Pilha (Imprime todos os Contatos)");
                Console.WriteLine("\n");

                Console.WriteLine("[ 0 ] Voltar para o menu anterior.");
                Console.WriteLine("-------------------------------------");
                Console.Write("Escolha a atividade a ser executada: ");

                opcao = Int32.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        CriaPilha();
                        break;
                    case 2:
                        NovoContato_Pilha();
                        break;
                    case 3:
                        RemoverContato_Pilha();
                        break;
                    //case 4:
                    //    //EditarContato_Pilha();
                    //    break;
                    //case 5:
                    //    //VerContato_Pilha();
                    //    break;
                    //case 6:
                    //    //ImprimirTodosOsContatos_Pilha();
                    //    break;

                    default:
                        SaiPrograma();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (opcao != 0);
            #endregion
        }

        public static void EscolheuPilhaEncadeada()
        {
            #region [Pilha Encadeada - Estrutura de repetição para escolha da atividade a ser executada.]
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("------[Pilha Encadeada de Contatos]------");
                Console.WriteLine("\n");
                Console.WriteLine("[ 1 ] Nova Pilha Encadeada");
                Console.WriteLine("[ 2 ] Empilhar - Novo Contato");
                Console.WriteLine("[ 3 ] Desempilhar Contato");
                //Console.WriteLine("[ 4 ] Editar Contato");
                //Console.WriteLine("[ 5 ] Ver Contato");
                //Console.WriteLine("[ 6 ] Ver Pilha Encadeada (Imprime todos os Contatos)");
                Console.WriteLine("\n");

                Console.WriteLine("[ 0 ] Voltar para o menu anterior.");
                Console.WriteLine("-------------------------------------");
                Console.Write("Escolha a atividade a ser executada: ");

                opcao = Int32.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        CriaPilha_Encadeada();
                        break;
                    case 2:
                        NovoContato_Pilha_Encadeada();
                        break;
                    case 3:
                        RemoverContato_Pilha_Encadeada();
                        break;
                    //case 4:
                    //    //EditarContato_Pilha_Encadeada();
                    //    break;
                    //case 5:
                    //    //VerContato_Pilha_Encadeada();
                    //    break;
                    //case 6:
                    //    //ImprimirTodosOsContatos_Pilha_Encadeada();
                    //    break;

                    default:
                        SaiPrograma();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (opcao != 0);
            #endregion
        }

        #region ------Lista Comum------
        #region [Criar lista]
        private static void CriaLista()
        {
            Console.Clear();
            Console.Write("[Nova Lista]");
            Console.WriteLine("\n");

            listaDeContato = new Lista();

            Console.WriteLine("Será criada uma nova lista de contatos...");
            Console.Write("Escolha o tamanho desejado para essa lista: ");
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
        private static void NovoContato()
        {
            Console.Clear();
            Console.Write("[Novo Contato]");
            Console.WriteLine("\n");

            var contato = new Contato();

            Console.WriteLine("Entre com os dados do novo contato a ser adicionado na lista...");
            Thread.Sleep(500);

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
        private static void RemoverContato()
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
        public static void EditarContato()
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
        public static void VerContato()
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

            Thread.Sleep(500);

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
        public static void ImprimirTodosOsContatos()
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
        private static void CriaLista_Encadeada()
        {
            Console.Clear();
            Console.Write("[Nova Lista Encadeada]");
            Console.WriteLine("\n");

            listaDeContatosEncadeada = new ListaEncadeada();

            Console.WriteLine("Será criada uma nova lista encadeada de contatos...");
            //Console.Write("Escolha o tamanho desejado para essa lista: ");
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
        private static void NovoContato_Encadeada()
        {
            Console.Clear();
            Console.Write("[Novo Contato]");
            Console.WriteLine("\n");

            var contato = new Contato();

            Console.WriteLine("Entre com os dados do novo contato a ser adicionado na lista...");
            Thread.Sleep(500);

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
        private static void RemoverContato_Encadeada()
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
        public static void EditarContato_Encadeada()
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
        public static void VerContato_Encadeada()
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

            Thread.Sleep(500);

            Console.WriteLine("Nome: {0}", contato.Nome);
            Console.WriteLine("Telefone: {0}", contato.Telefone);
            Console.WriteLine("Email: {0}", contato.Email);
        }
        #endregion

        #region [Imprimir todos os Contatos Encadeada]
        /// <summary>
        /// Atividade 6: 
        /// </summary>
        public static void ImprimirTodosOsContatos_Encadeada()
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

        #region ------Pilha Comum------
        #region [Criar Pilha]
        private static void CriaPilha()
        {
            Console.Clear();
            Console.Write("[Nova Pilha]");
            Console.WriteLine("\n");

            pilhaDeContatos = new Pilha();

            Console.WriteLine("Será criada uma nova pilha de contatos...");
            Console.Write("Escolha o tamanho desejado para essa pilha: ");
            var maxTam = Int32.Parse(Console.ReadLine());
            pilhaDeContatos.CriaPilhaVazia(maxTam);

            Thread.Sleep(500);
            Console.WriteLine("A pilha de contatos foi criada, com capacidade para {0} contatos.", maxTam);
        }
        #endregion

        #region [Novo Contato]
        /// <summary>
        /// Atividade 2: 
        /// </summary>
        private static void NovoContato_Pilha()
        {
            Console.Clear();
            Console.Write("[Novo Contato]");
            Console.WriteLine("\n");

            var contato = new Contato();

            Console.WriteLine("Entre com os dados do novo contato a ser adicionado na pilha...");
            Thread.Sleep(500);

            Console.Write("Nome: ");
            contato.Nome = Console.ReadLine();

            Console.Write("Telefone: ");
            contato.Telefone = Int32.Parse(Console.ReadLine());

            Console.Write("Email: ");
            contato.Email = Console.ReadLine();

            contato.ID_Contato = Guid.NewGuid();

            pilhaDeContatos.Empilha(contato);

            Console.WriteLine("O contato {0} foi inserido com sucesso.", contato.Nome);
        }
        #endregion

        #region [Remover Contato]
        /// <summary>
        /// Atividade 3: 
        /// </summary>
        private static void RemoverContato_Pilha()
        {
            Console.Clear();
            Console.Write("[Desempilhar Contato]");
            Console.WriteLine("\n");

            pilhaDeContatos.Desempilha();

            Console.WriteLine("\n");
            Console.WriteLine("O último contato foi removido.");
        }
        #endregion

        #region [Editar Contato]
        ///// <summary>
        ///// Atividade 4: 
        ///// </summary>
        //public static void EditarContato_Pilha()
        //{
        //    Console.Clear();
        //    Console.Write("[Editar Contato]");
        //    Console.WriteLine("\n");


        //}
        #endregion

        #region [Ver Contato]
        ///// <summary>
        ///// Atividade 5: 
        ///// </summary>
        //public static void VerContato_Pilha()
        //{
        //    Console.Clear();
        //    Console.Write("[Ver Contato]");
        //    Console.WriteLine("\n");

        //    //var listaDeContato = new Lista();
        //    string nomeDoContato;
        //    var contato = new Contato();

        //    Console.Write("Entre com o nome do contato que deseja pesquisar: ");
        //    nomeDoContato = Console.ReadLine();

        //    listaDeContato.Pesquisa(nomeDoContato);

        //    Thread.Sleep(500);

        //    Console.WriteLine("\n");

        //    Console.WriteLine("Nome: {0}", contato.Nome);
        //    Console.WriteLine("Telefone: {0}", contato.Telefone);
        //    Console.WriteLine("Email: {0}", contato.Email);
        //}
        #endregion

        #region [Imprimir todos os Contatos]
        ///// <summary>
        ///// Atividade 6: 
        ///// </summary>
        //public static void ImprimirTodosOsContatos_Pilha()
        //{
        //    Console.Clear();
        //    Console.Write("[Imprimir todos os Contatos]");
        //    Console.WriteLine("\n");

        //    Console.WriteLine("Lista de contatos: ");
        //    Console.WriteLine("\n");

        //    while (!pilhaDeContatos.IsPilhaVazia())
        //        pilhaDeContatos.Imprime();
        //}
        #endregion

        #region Atividade 5 - Aula Prática 4
        /// <summary>
        /// Atividade 5: Escreva uma função para determinar se uma cadeia de caracteres (string) é da forma: 
        /// x C y onde x e y são cadeias de caracteres compostas por letras ‘A’ e/ou ‘B’, 
        /// e y é o inverso de x. Isto é, se x = “ABABBA”, y deve equivaler a “ABBABA”. 
        /// Em cada ponto, você só poderá ler o próximo caractere da cadeia(é mandatório o uso de pilha).
        /// </summary>
        public static void CadeiaDeCaracteres_Pilha()
        {
            Console.Clear();
            Console.Write("[Verificando cadeia de caractéres]");
            Console.WriteLine("\n");

            string cadeiaDeCaracteresInseridaPeloUsuario;
            string cadeiaInvertida;

            Console.Write("Entre com a cadeia de caracteres que deseja que seja verificada.");
            cadeiaDeCaracteresInseridaPeloUsuario = Console.ReadLine();

            cadeiaInvertida = pilhaDeContatos.VerificaCadeiaCaracteres(cadeiaDeCaracteresInseridaPeloUsuario);

            Console.WriteLine();
        }

        #endregion

        #endregion

        #region ------Pilha Encadeada------

        #region [Criar Pilha Encadeada]
        private static void CriaPilha_Encadeada()
        {
            Console.Clear();
            Console.Write("[Nova Pilha Encadeada]");
            Console.WriteLine("\n");

            pilhaDeContatosEncadeada = new PilhaEncadeada();

            Console.WriteLine("Será criada uma nova pilha de contatos...");

            pilhaDeContatosEncadeada.CriaPilhaVazia();

            Thread.Sleep(500);
            Console.WriteLine("A pilha encadeada de contatos foi criada.");
        }
        #endregion

        #region [Novo Contato]
        /// <summary>
        /// Atividade 2: 
        /// </summary>
        private static void NovoContato_Pilha_Encadeada()
        {
            Console.Clear();
            Console.Write("[Novo Contato]");
            Console.WriteLine("\n");

            var contato = new Contato();

            Console.WriteLine("Entre com os dados do novo contato a ser adicionado na pilha...");
            Thread.Sleep(500);

            Console.Write("Nome: ");
            contato.Nome = Console.ReadLine();

            Console.Write("Telefone: ");
            contato.Telefone = Int32.Parse(Console.ReadLine());

            Console.Write("Email: ");
            contato.Email = Console.ReadLine();

            contato.ID_Contato = Guid.NewGuid();

            pilhaDeContatosEncadeada.Empilha(contato);

            Console.WriteLine("O contato {0} foi inserido com sucesso.", contato.Nome);
        }
        #endregion

        #region [Remover Contato]
        /// <summary>
        /// Atividade 3: 
        /// </summary>
        private static void RemoverContato_Pilha_Encadeada()
        {
            Console.Clear();
            Console.Write("[Desempilhar Contato]");
            Console.WriteLine("\n");

            pilhaDeContatosEncadeada.Desempilha();

            Console.WriteLine("\n");
            Console.WriteLine("O último contato foi removido.");
        }
        #endregion

        #region [Editar Contato]
        ///// <summary>
        ///// Atividade 4: 
        ///// </summary>
        //public static void EditarContato_Pilha()
        //{
        //    Console.Clear();
        //    Console.Write("[Editar Contato]");
        //    Console.WriteLine("\n");


        //}
        #endregion

        #region [Ver Contato]
        ///// <summary>
        ///// Atividade 5: 
        ///// </summary>
        //public static void VerContato_Pilha()
        //{
        //    Console.Clear();
        //    Console.Write("[Ver Contato]");
        //    Console.WriteLine("\n");

        //    //var listaDeContato = new Lista();
        //    string nomeDoContato;
        //    var contato = new Contato();

        //    Console.Write("Entre com o nome do contato que deseja pesquisar: ");
        //    nomeDoContato = Console.ReadLine();

        //    listaDeContato.Pesquisa(nomeDoContato);

        //    Thread.Sleep(500);

        //    Console.WriteLine("\n");

        //    Console.WriteLine("Nome: {0}", contato.Nome);
        //    Console.WriteLine("Telefone: {0}", contato.Telefone);
        //    Console.WriteLine("Email: {0}", contato.Email);
        //}
        #endregion

        #region [Imprimir todos os Contatos]
        ///// <summary>
        ///// Atividade 6: 
        ///// </summary>
        //public static void ImprimirTodosOsContatos_Pilha_Encadeada()
        //{
        //    Console.Clear();
        //    Console.Write("[Imprimir todos os Contatos]");
        //    Console.WriteLine("\n");

        //    Console.WriteLine("Pilha de contatos: ");
        //    Console.WriteLine("\n");

        //    while (!pilhaDeContatosEncadeada.IsPilhaVazia())
        //        pilhaDeContatosEncadeada.Imprime();
        //}
        #endregion
        #endregion

        #region para fechar o programa

        private static void SaiPrograma()
        {
            Console.WriteLine();
            Console.WriteLine("Você saiu do programa. Clique qualquer tecla para fechar...");
        }
        #endregion
    }
}