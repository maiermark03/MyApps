using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipusconverzio
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            if (x is int) //ha x egy int
            {
                Console.WriteLine("x típusa int");
            }

            Console.ReadKey();
        }
    }
}
