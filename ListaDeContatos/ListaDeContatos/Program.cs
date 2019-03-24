using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Console.Write("[Nova Lista");
            Console.WriteLine("\n");

            
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
