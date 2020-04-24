using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шахматы
{
   public static class Paint
    {
        //отрисовывает поле
        public static int[,] Pole(char[,] pole,int[,] pole2)
        {
            //Console.ForegroundColor = ConsoleColor.DarkBlue;//изменение цвета шрифта.


            //Console.BackgroundColor = ConsoleColor.Yellow;//изменяет фона за текстом.
            int k = 2;
            int l = -1;
            
            
            for (int i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    k = k + l;
                    if (k == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(i, j);
                        if (j-2 < 2)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write(pole[j-2,i-2]);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write(pole[j -2, i - 2]);
                        }
                        pole2[i - 2, j - 2] = 1;        
                    }
                    else
                    {                      
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(i, j);
                        if (j-2 < 2)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write(pole[j - 2, i - 2]);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write(pole[j - 2, i - 2]);
                        }
                        pole2[i - 2, j - 2] = 0;
                    }
                  
                    l = l * (-1);
                }
                l = l * (-1);
                k = k - l;
            }
            return pole2;
        }


    }
}
