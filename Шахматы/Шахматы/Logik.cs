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
               proverka= Figura(pole, X, Y,user);
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

        public static bool Figura(char[,] pole,int X,int Y, int user)//int user
        {//проверка на играка
            
            Console.SetCursorPosition(x, y);
            switch (pole[Y, X])
            {
                case 'п':
                    //проверка на сьедание
                   if (Math.Abs(Y - y + 2) == 1 && Math.Abs(X - x + 2) == 1 && pole[y - 2, x - 2] != ' ')
                    {
                        return true;
                    }
                        //проверка на ход с любого места дальше 2 клеток кроме начального положения, проверка на ход в сторону,проверка на наступание на другую фигуру                   
                        if (Math.Abs(Y - y+2) > 2 || Math.Abs(X - x+2) != 0 || pole[y-2, x-2] != ' ')
                        {


                            Console.SetCursorPosition(12, 2);
                            Console.WriteLine("вы не можете сделать такой ход");
                            Console.SetCursorPosition(12, 3);
                            Console.WriteLine("Math.Abs(Y - y+2)" + Math.Abs(Y - y+2) + " Math.Abs(X - x+2)" + Math.Abs(X - x+2)+" Y "+Y+"  y"+ y+" X"+X+" x"+x);
                            return false;
                        }
                        else
                        {//проверка на ход с начальной позиции на 2 клетки
                            if (Math.Abs(Y - y+2) == 2 && X <= 7 && Y == 1 || Y == 6 && Math.Abs(X - x+2) == 0 && pole[y-2, x-2] == ' ')
                            {
                                return true;
                            }
                            else
                            {//проверка на ход в 1 клетку
                                if (Math.Abs(Y - y+2) == 1 && Math.Abs(X - x+2) == 0 && pole[y-2, x-2] == ' ')
                                {
                                    return true;
                                }
                            }
                        }
                    
                        ;
                    break;
                case 'л':
                    Console.SetCursorPosition(12, 2);
                    Console.WriteLine("ладья");
                    int n;

                    if (user == 0)
                        n = -1;
                    else
                        n = 1;

                    if ((x-2-X)>=-7|| (x - 2 - X) >= 7&&(y-2-Y)==0 &&pole[y-2,x-2]==' ')//передвижение горизонтально
                    {
                        Console.SetCursorPosition(12, 3);
                        Console.WriteLine("горизонт");
                        for (int i = 1; i < Math.Abs(x - 2 - X); i++)
                        {
                            if(pole[Y,X+(i*n)]!=' ')
                            {
                                return false;
                            }
                            
                        }
                       
                    }
                    else
                    {
                        if (((x - 2 - X) >= -7 || (x - 2 - X) >= 7) && ((y - 2 - Y) != 0 || pole[y - 2, x - 2] != ' '))//наступание на фигуру, передвижение сразу по двум координатам
                        {
                            return false;
                        }

                    }
                    if((y - 2 - Y) >= -7 || (y - 2 - Y) >= 7 && (x - 2 - X) == 0 && pole[y - 2, x - 2] == ' ')//передвижение вертикально
                    {
                        Console.SetCursorPosition(12, 3);
                        Console.WriteLine("вертикаль"+ " Math.Abs(y - 2 - Y)"+ Math.Abs(y - 2 - Y));
                        for (int i = 1; i < Math.Abs(y - 2 - Y)-1; i++)
                        {
                            if (pole[Y-(i*n), X ] != ' ')
                            {
                                Console.SetCursorPosition(12, 4+i);
                                Console.WriteLine(pole[Y + i, X]);
                                return false;
                            }

                        }
                        Console.SetCursorPosition(12, 4);
                        Console.WriteLine(pole[y - 2, x - 2]);
                    }
                    else
                    {
                        if ((y - 2 - Y) >= -7 || (y - 2 - Y) >= 7 && (x - 2 - X) != 0 || pole[y - 2, x - 2] != ' ')//наступание на фигуру, передвижение сразу по двум координатам
                        {
                            return false;
                        }
                    }

                        ; break;

            }
            
            return true;
        }
    }
}
