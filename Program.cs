using System;

namespace Game_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameon = false;
            int x = 30;
            int y = 15;

           Console.Clear();
           Console.SetCursorPosition(40,20);
           System.Console.WriteLine("welcome to snake game");
            Console.SetCursorPosition(40,20);
           System.Console.WriteLine("press  any key to start the game");
           Console.ReadKey();
           gameon = true;
           Console.Clear();
           Console.SetCursorPosition(x,y);
           System.Console.WriteLine("x");
           while(gameon == true)
           {
               ConsoleKeyInfo keyInfo = Console.ReadKey();
               if(keyInfo.Key==ConsoleKey.Escape)
               {
                   gameon = false;
               }
               else if (keyInfo .Key ==ConsoleKey.UpArrow)
               {
                   y++;
                   
               }
               else if (keyInfo .Key ==ConsoleKey.DownArrow)
               {
                   y--;
               }
               else if (keyInfo .Key ==ConsoleKey.LeftArrow)
               {    
                   x--;
               }
               else if (keyInfo .Key ==ConsoleKey.RightArrow)
               {
                   x++;
               }
           }
           Console.ForegroundColor = ConsoleColor.DarkBlue;
           Console.SetCursorPosition(Console.BufferHeight/2, Console.BufferHeight/2);
           System.Console.WriteLine("game over");
        }
    }
}
