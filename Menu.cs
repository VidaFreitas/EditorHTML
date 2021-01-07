using System;

namespace EditorHTML
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
            Console.WriteLine("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.WriteLine("-");
            }
        }
    }
}