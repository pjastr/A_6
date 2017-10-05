using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabliczka mnożenia od 0 do 5");
            for (int i=0;i<=5;i++)
            {
                for(int j=0;j<=5;j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
