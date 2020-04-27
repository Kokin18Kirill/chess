using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шахматы
{
    class Program
    {
        static void Main(string[] args)
        {
            int user = 1;
         

            int[,] pole2 = new int[8,8];
            char[,] pole = new char[8, 8] 
              { { 'л', 'к', 'с', 'ф', 'ц', 'с', 'к', 'л' },
                { 'п', 'п', 'п', 'п', 'п', 'п', 'п', 'п' },
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' }, 
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' }, 
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' }, 
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                { 'п', 'п', 'п', 'п', 'п', 'п', 'п', 'п' },
                { 'л', 'к', 'с', 'ф', 'ц', 'с', 'к', 'л'} };
            //Logik.Figure_choice(keyInfo,pole,pole2,user); 
            pole2=Paint.Pole(pole,pole2);
       
            while (true)
            {
                var keyInfo = Console.ReadKey(true);
                Logik.Figure_choice(keyInfo, pole, pole2,user);
            }
       
        }
    }
}
