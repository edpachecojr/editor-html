using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            short option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            int columnsNumber = 30;
            int linesNumber = 10;
            DrawLine(columnsNumber);

            for (int lines = 0; lines <= linesNumber; lines++)
            {
                Console.Write("|");
                for (int columns = 0; columns <= 30; columns++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }

            DrawLine(columnsNumber);
        }

        public static void DrawLine(int columns)
        {
            Console.Write("+");
            for (int i = 0; i <= columns; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");

        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0: Exit(); break;
                default: Show(); break;
            }
        }

        public static void Exit()
        {
            Console.Clear();
            Environment.Exit(0);
        }
    }
}