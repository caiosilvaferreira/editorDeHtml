using System;
using System.Text;
using EditorHtml;


namespace texEditor
{

    public static class Editor
    {

        public static void Show()
        {

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White; // muda a cor do fundo para branco
            Console.ForegroundColor = ConsoleColor.Black; // mudar a cor da letra para preto
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("------------");
            Start();

        }

        public static void Start()
        {

            var file = new StringBuilder(); // tem a função de ler varios caracteres, me multiplas linhas e concatenar todas juntas

            do
            {
                file.Append(Console.ReadLine());  // aqui ele arquiva todas as strings
                file.Append(Environment.NewLine); // ate mesmo depois da quebra de linha
            } while (Console.ReadKey().Key != ConsoleKey.Escape); // so vai sair da tela se o usuario apertar a tecla ESC.

            Console.WriteLine("----------------");
            Console.WriteLine("Deseja salvar o arquivo?");
            Viewer.Show(file.ToString()); // depois aqui ele instancia com viewer.show e mostra tudo o que o usuario digitou
        }
    }
}