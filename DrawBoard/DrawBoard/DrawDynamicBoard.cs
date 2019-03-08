using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoard
{
    class DrawDynamicBoard
    {
        public static void DrawBoard1(int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                string row1 = "";
                string row2 = "";

                for (int j = 0; j < columns; j++)
                {
                    row1 = row1 + " | ";
                    row2 = row2 + "-+-";
                }
                Console.WriteLine(row1);
                Console.WriteLine(row2);
            }
            Console.WriteLine();
        }        
    }
}
