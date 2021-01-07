using System;

namespace EditorHTML
{
    public class Viewr
    {
        public static void Show(String text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VIZUALIZAÇÃO");
            Console.WriteLine("----------");
            Replace(text);
            Console.WriteLine("----------");
            Console.ReadKey();
            Menu.Show();
        }
    }
}