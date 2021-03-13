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
    }
}