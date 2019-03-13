using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esf
{
    class Program
    {
        static void Main(string[] args)
        {
            //A létrhozot új tipussal inicilizáljunk egy objektumot.
            Excercise ex = new Excercise("Maier Márk");

            //ex.Name = "Maier Márk";

            Console.WriteLine(ex.Name);
             
            Console.ReadKey();

            
        }
    }
}
