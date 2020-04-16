using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шахматы
{
    public static class Logik
    {
        public static int x, y;
        public static int[] BX = new int[15];
        public static int[] BY = new int[15];
        public static int[] WX = new int[15];
        public static int[] WY = new int[15];

        public static void Figure_choice(ConsoleKeyInfo keyInfo,char[,] pole,int[,] pole2, int user)
        {
            char figura;

            if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                if (x + 1<=7)
                {
                    x++;
                    Console.SetCursorPosition(x, y);            
                }
            }
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                if (y - 1 >= 0)
                {
                    y--;
                    Console.SetCursorPosition(x, y);                
                }
            }
            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                if (x - 1 >= 0)
                {
                    x--;
                    Console.SetCursorPosition(x, y);                 
                }                    
            }
            if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                if (y + 1 <=7)
                {
                    y++;
                    Console.SetCursorPosition(x, y );                   
                }                         
            }
            if (keyInfo.Key == ConsoleKey.Enter)
            {
                if ()// проверка на то кто ходит
                    figura = pole[y, x];
                Console.SetCursorPosition(x, y);
                if (pole2[y,x] == 0)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(' ');
                }
                if (pole2[y,x]== 1)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(' ');
                }
            }
            if (keyInfo.Key == ConsoleKey.Spacebar)
            {
                if()// проверка на то кто ходит
            }
        }
    }
}
