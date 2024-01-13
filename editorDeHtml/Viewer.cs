using System;
using System.Text.RegularExpressions;
using texEditor;

namespace EditorHtml
{
    public class Viewer
    {
        public static void Show(String text)
        {

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("VISUALIZADOR");
            Console.WriteLine("------------");
            Replace(text);  // aqui ele instancia o replace, e la embaixo ele verifica se o usuario usou o padrão Regex e mostra a mensagem do usuario
            Console.WriteLine("------------");
            Console.ReadKey();
            Menu.Show(); // depois de aperta qualquer tecla ele volta para o menu
        }

        public static void Replace(String text)
        {


            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {

                if (strong.IsMatch(words[i]))
                { /*strong representa o Regex, ele vai verificar se tem algum caractere que segue o padrão especificado, para que depois ele deixe em negrito*/

                    Console.ForegroundColor = ConsoleColor.Blue; // a cor que representa o Regex vai fica azul
                    Console.Write( // aqui ele irá mostrar toda mensagem que o usuario digitou 
                        words[i].Substring
                        (
                            words[i].IndexOf('>') + 1,
                            (
                            (words[i].LastIndexOf('<') - 1) -
                            words[i].IndexOf('>'))
                            )
                        );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}