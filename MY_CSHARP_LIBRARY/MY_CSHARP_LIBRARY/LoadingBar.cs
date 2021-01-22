using System;
using System.Collections.Generic;
using System.Text;

namespace MY_CSHARP_LIBRARY
{
    public class LoadingBar
    {
        public static void AfficherLoadingBar(int timeToWait)
        {
            string laBarre = "";
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t{0} {1} % ", laBarre, i);
                laBarre += "░";
                System.Threading.Thread.Sleep(timeToWait);
                Console.Clear();
            }
            System.Threading.Thread.Sleep(1000);
        }
        public static void AfficherLoadingBar2(int timeToWait) // Pour bien faire, devrais bloquer la modification de grandeur de la console
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(56, 6);

            //string color = "\x1b[38;2;168;29;50m";
            int posX = 9;
            int posY = 13;
            Console.Write(/*color + */"LOADING:");
            for (int i = 0; i < 101; i++)
            {
                Console.SetCursorPosition(i + posX, posY);
                Console.Write(/*color + */"░");
                Console.SetCursorPosition(i + posX + 1, posY);
                Console.Write(" ");
                Console.SetCursorPosition(i + posX + 2, posY);
                Console.Write(i + " %");
                System.Threading.Thread.Sleep(timeToWait);
            }
        }
        public static void AfficherNbMove(int timeToWait)
        {
            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t0 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░ 1 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░ 2 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░ 3 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░ 4 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░ 5 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░ 6 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░ 7 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░ 8 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░ 9 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░ 10 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░ 11 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░ 12 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░ 13 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░ 14 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░ 15 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░ 16 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░ 17 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░ 18 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░ 19 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░ 20 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░ 21 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░ 22 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░ 23 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░ 24 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░ 25 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░ 26 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░ 27 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 28 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 29 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 30 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 31 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 32 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 33 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 34 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 35 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 36 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 37 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 38 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 39 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 40 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 41 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 42 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 43 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 44 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 45 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 46 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 47 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 48 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 49 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 50 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 51 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 52 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 53 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 54 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 55 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 56 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 57 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 58 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 59 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 60 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 61 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 62 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 63 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 64 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 65 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 66 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 67 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 68 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 69 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 70 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 71 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 72 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 73 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 74 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 75 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 76 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 77 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 78 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 79 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 80 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 81 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 82 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 83 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 84 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 85 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 86 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 87 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 88 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 89 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 90 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 91 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 92 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 93 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 94 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 95 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 96 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░97 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 98 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 99 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tDONE!\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 100 % ");
        }
        public static void AfficherNbNoMove(int timeToWait)
        {
            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t                                                                                                       0 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░                                                                                                      1 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░                                                                                                     2 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░                                                                                                    3 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░                                                                                                   4 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░                                                                                                  5 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░                                                                                                 6 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░                                                                                                7 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░                                                                                               8 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░                                                                                              9 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░                                                                                            10 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░                                                                                           11 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░                                                                                          12 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░                                                                                         13 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░                                                                                        14 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░                                                                                       15 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░                                                                                      16 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░                                                                                     17 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░                                                                                    18 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░                                                                                   19 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░                                                                                  20 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░                                                                                 21 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░                                                                                22 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░                                                                               23 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░                                                                              24 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░                                                                             25 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░                                                                            26 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                                           27 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                                          28 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                                         29 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                                        30 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                                       31 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                                      32 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                                     33 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                                    34 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                                   35 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                                  36 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                                 37 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                                38 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                               39 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                              40 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                             41 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                            42 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                           43 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                          44 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                         45 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                        46 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                       47 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                      48 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                     49 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                    50 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                   51 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                  52 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                 53 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                54 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                               55 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                              56 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                             57 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                            58 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                           59 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                          60 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                         61 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                        62 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                       63 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                      64 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                     65 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                    66 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                   67 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                  68 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                 69 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                70 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                               71 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                              72 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                             73 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                             74 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                           75 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                          76 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                         77 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                        78 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                       79 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                      80 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                     81 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                    82 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                   83 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                  84 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                 85 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                86 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░               87 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░              88 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░             89 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░            90 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░           91 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░          92 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░         93 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░        94 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       95 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░      96 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░    97 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   98 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tLOADING:\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░  99 % ");
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();


            Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tDONE!\n\n\n\n\n\n\n\t░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 100 % ");
        }
    }
}
