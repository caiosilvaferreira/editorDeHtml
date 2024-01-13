using System;
using System.Security.Cryptography.X509Certificates;
using EditorHtml;

namespace texEditor
{
    public class Menu
    {
        public static void Show()
        {

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green; // muda o fundo para a cor verde
            Console.ForegroundColor = ConsoleColor.Black; // muda a cor das letras para preto

            DrawScreen();
            WriteOptions();

            var option = byte.Parse(Console.ReadLine()); // ler a opcao que o usuario vai digitar
            HandleMenuOptions(option);
        }

        public static void DrawScreen()
        {
            Lines();
            Colums(); // aqui ele desenha um painel para o usuario 
            Lines();
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);  // posicionamento do cursor, aonde vai aparecer a resposta do writeLine.
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("==============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opcao abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opcao:");
        }

        public static void HandleMenuOptions(short option)
        {

            switch (option)
            {

                case 1: Editor.Show(); break;  // se caso for 1, vai abrir o editor para o usuario 
                case 2: Viewer.Show(""); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0); // se caso for 0, ele vai fechar o programa
                        break;
                    }
                default: Show(); break; // caso o usuario digite alguma coisa errado, ele volta para o menu
            }
        }

        static void Lines()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");
            /* essa é uma funcao de laço de repeticao para criar linhas com caractere " - "*/

            Console.Write("+");
            Console.Write("\n");
        }

        static void Colums()
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");

                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");
                /* aqui ele faz um laço de repeticao para que seja criado colunas a ordem seria criar uma coluna, depois
                 entre 30 espaços vazios criasse outra coluna ai formaria um desenho linear de colunas */
                Console.Write("|");
                Console.Write("\n"); // mesma funcao do Console.WriteLine
            }
        }
    }
}