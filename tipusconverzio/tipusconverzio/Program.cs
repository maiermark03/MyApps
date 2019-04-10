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
            object a = "123";
            object b = "Hello";
            object c = 10;
            string aa = a as string;
            // expr1 ? v1 : v2;
            
            string bb = b as string;
            Console.WriteLine(bb == null ? "NULL" : bb); // Hello

            string cc = c as string;
            Console.WriteLine(cc == null ? "NULL" : cc); // Null

            int x = 10;
            Console.WriteLine(x == 5 ? "x == 5" : "x != 5");

            Console.ReadKey();
        }
    }
}
