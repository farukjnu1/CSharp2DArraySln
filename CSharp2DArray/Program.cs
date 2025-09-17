using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two D Array Example: Rows=2, Columns=3");
            const int numberOfRow = 2, numberOfColumn = 3;
            int?[,] arr = new int?[numberOfRow, numberOfColumn]; // size of array declaration
            #region Add value to 2D array
            for (int i = 0; i < numberOfRow; i++)
            {
                Console.WriteLine(i + 1 + " Row:");
                for (int j = 0; j < numberOfColumn; j++)
                {
                    Console.WriteLine(j + 1 + " Column:");
                    var v = Convert.ToInt32(Console.ReadLine());
                    arr[i, j] = v;
                }
            }
            Console.WriteLine("Value added successfully.");
            #endregion
            #region Remove value from 2D array
            Console.WriteLine("To remove any value input:");
            Console.WriteLine("Row index:");
            var inR = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Column index:");
            var inC = Convert.ToInt32(Console.ReadLine());
            #endregion
            Console.WriteLine("You value is: " + arr[inR, inC]);
            Console.ReadLine();
        }
    }
}
