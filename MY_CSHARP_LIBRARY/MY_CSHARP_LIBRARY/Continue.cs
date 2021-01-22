using System;
using System.Collections.Generic;
using System.Text;

namespace MY_CSHARP_LIBRARY
{
    public class Continue
    {
        public static void AppuyezEnter()
        {
            Console.WriteLine("Appuyez sur ENTER pour continuer");
            while (!(Console.ReadKey(true).Key == ConsoleKey.Enter))
            {

            }
        }

        public static void PressEnter()
        {
            Console.WriteLine("Press ENTER to continue");
            while (!(Console.ReadKey(true).Key == ConsoleKey.Enter))
            {

            }
        }
    }
}
