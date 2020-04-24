using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шахматы
{
    public static class Logik
    {
        public static int x=5, y=5;
        public static int[] RX = new int[16];
        public static int[] RY = new int[16];
        public static int[] BX = new int[16];
        public static int[] BY = new int[16];
        public static int X = 0,Y=0;
        public static void Figure_choice(ConsoleKeyInfo keyInfo, char[,] pole, int[,] pole2, int user)
        {

          
            if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                if (x + 1 <= 9)
                {
                    x++;
                    Console.SetCursorPosition(x, y);
                }
            }
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                if (y - 1 >= 2)
                {
                    y--;
                    Console.SetCursorPosition(x, y);
                }
            }
            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                if (x - 1 >= 2)
                {
                    x--;
                    Console.SetCursorPosition(x, y);
                }
            }
            if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                if (y + 1 <= 9)
                {
                    y++;
                    Console.SetCursorPosition(x, y);
                }
            }
            if (keyInfo.Key == ConsoleKey.Enter)
            {
                // проверка на то кто ходит
                //if (user == 1)//red
                //{
                //    int proverka = 0;
                //    for (int i = 0; i < 16; i++)
                //    {

                //        if (RX[i] == x && RY[i] == y)
                //        {
                //            proverka++;
                //        }

                //    }
                //    if (proverka == 0)
                //    {
                //        Console.SetCursorPosition(15, 3);
                //        Console.WriteLine("это не ваша фигура.");
                //    }
                //    else
                //    {
                        X = x - 2;
                        Y = y - 2;
                        Console.SetCursorPosition(x, y);
                        if (pole2[y - 2, x - 2] == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(' ');
                        }
                        if (pole2[y - 2, x - 2] == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(' ');
                        }
                //    }
                //}
                //else
                //{
                //    if (user == 0)//blue
                //    {
                //        int proverka = 0;
                //        for (int i = 0; i < 16; i++)
                //        {

                //            if (BX[i] == x && BY[i] == y)
                //            {
                //                proverka++;
                //            }

                //        }
                //        if (proverka == 0)
                //        {
                //            Console.SetCursorPosition(15, 3);
                //            Console.WriteLine("это не ваша фигура.");
                //        }
                //        else
                //        {
                //            X = x - 2;
                //            Y = y - 2;
                //            Console.SetCursorPosition(x, y);
                //            if (pole2[y - 2, x - 2] == 0)
                //            {
                //                Console.BackgroundColor = ConsoleColor.White;
                //                Console.Write(' ');
                //            }
                //            if (pole2[y - 2, x - 2] == 1)
                //            {
                //                Console.BackgroundColor = ConsoleColor.Black;
                //                Console.Write(' ');
                //            }
                //        }
                //    }}

                
                
            }
            if (keyInfo.Key == ConsoleKey.Spacebar)
            {
                bool proverka;
                //проверка на фигуру
                proverka = true;
               proverka= Figura(pole, X, Y);
                Console.SetCursorPosition(x, y);
                if (proverka != false)
                {
                    //проверка на играка
                    if (user == 1)//red
                    {
                        if (pole2[y - 2, x - 2] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(pole[Y, X]);
                            pole[y - 2, x - 2] = pole[Y, X];
                            pole[Y, X] = ' ';
                            X = 0; Y = 0;
                        }
                        if (pole2[y - 2, x - 2] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(pole[Y, X]);
                            pole[y - 2, x - 2] = pole[Y, X];
                            pole[Y, X] = ' ';
                            X = 0; Y = 0;
                        }
                    }
                    else//blue
                    {
                        if (pole2[y - 2, x - 2] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(pole[Y, X]);
                            pole[y - 2, x - 2] = pole[Y, X];
                            pole[Y, X] = ' ';
                            X = 0; Y = 0;
                        }
                        if (pole2[y - 2, x - 2] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(pole[Y, X]);
                            pole[y - 2, x - 2] = pole[Y, X];
                            pole[Y, X] = ' ';
                            X = 0; Y = 0;
                        }
                    }
                }
              
            }
              
        }

        public static bool Figura(char[,] pole,int X,int Y)//int user
        {//проверка на играка
            
            Console.SetCursorPosition(x, y);
            switch (pole[Y, X])
            {
                case 'п':
                   
                        //проверка на ход с любого места дальше 2 клеток кроме начального положения, проверка на ход в сторону,проверка на наступание на другую фигуру                   
                        if (Math.Abs(Y - y+2) > 2 || Math.Abs(X - x+2) != 0 || pole[y, x] != ' ')
                        {


                            Console.SetCursorPosition(12, 2);
                            Console.WriteLine("вы не можете сделать такой ход");
                            Console.SetCursorPosition(12, 3);
                            Console.WriteLine("Math.Abs(Y - y)" + Math.Abs(Y - y+2) + " Math.Abs(X - x)" + Math.Abs(X - x+2)+" Y "+Y+"  y"+ y+" X"+X+" x"+x);
                            return false;
                        }
                        else
                        {//проверка на ход с начальной позиции на 2 клетки
                            if (Math.Abs(Y - y+2) == 2 && X <= 7 && Y == 1 || Y == 6 && Math.Abs(X - x+2) == 0 && pole[y, x] == ' ')
                            {
                                return true;
                            }
                            else
                            {//проверка на ход в 1 клетку
                                if (Math.Abs(Y - y+2) == 1 && Math.Abs(X - x+2) == 0 && pole[y, x] == ' ')
                                {
                                    return true;
                                }
                            }
                        }
                    
                        ;
                    break;

            }
            
            return true;
        }
    }
}
