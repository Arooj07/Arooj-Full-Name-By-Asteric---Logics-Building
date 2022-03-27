using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullnameArooj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Display Name --- AROOJ");
            Console.WriteLine();
            Console.WriteLine("Full Name in ONE line");
            Console.WriteLine();
            int row, column;
            for (row = 0; row < 8; row++)
            {
                for (column = 1; column <= 44; column++)
                {
                    if ((row == 0 && column >= 2 && column <= 6) || (column == 1 && row != 0) || (column == 7 && row != 0) || (row == 4 && column > 1 && column < 7) ||
                        (row == 0 && column >= 10 && column <= 15) || (column == 9 && row != 0) || (column == 16 && row != 0 && row != 4 && row != 5 && row != 6) || 
                        (row == 4 && column > 9 && column < 15) || (row == 6 && column == 15) || (row == 5 && column == 14) || (row == 4 && column == 13) ||
                        (row == 7 && column == 16) || (row == 0 && column >= 19 && column <= 24) || (row == 7 && column >= 19 && column <= 24) || 
                        (column == 18 && row != 0 && row != 7) || (column == 25 && row != 0 && row != 7) || (row == 0 && column >= 28 && column <= 33) ||
                        (row == 7 && column >= 28 && column <= 33) || (column == 27 && row != 0 && row != 7) || (column == 34 && row != 0 && row != 7) ||
                        (row == 0 && column >= 36 && column <= 41) || (column == 41 && row != 7) || (column == 36 && row == 6) || (column == 37 && row == 7) 
                        || (column == 38 && row == 7) || (column == 39 && row == 7) || (column == 40 && row == 7))
                        
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");

            }
            Console.WriteLine();
            Console.WriteLine("Name Displayed");
            Console.WriteLine();

        }
    }
}
