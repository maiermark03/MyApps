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
            int v = 0;
            string  s;
            //A létrhozot új tipussal inicilizáljunk egy objektumot.
            Excercise ex = new Excercise("Maier Márk");

            //ex.Name = "Maier Márk";

            Console.WriteLine(ex.Name);
            //tagfügvény
            ex.printName();

            Console.WriteLine(ex.getName());

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Cilklus:<Változóhivatkozás I.>" + i);
                Console.WriteLine("Cilklus:<Változóhivatkozás II.>{0}" + i);
            }
            v = 2;
            while (v>0)
            {
                Console.WriteLine("While Ciklus");
                v--;
            }
            v = 2;
            do
            {
                Console.WriteLine("Do ciklus");
                v--;
            } while (v > 0);

            //elágazások
            v = 2;
            if (v == 2 )
            {
                Console.WriteLine("A v egyenlő kettővel");
            }
            else if (v == 3)
            {
                Console.WriteLine("A v egyenlő hárommal");
            }
            else
            {
                Console.WriteLine(" v nem 2és nem 3");
            }
            v = 5;
            switch (v)
            {
                case 0:
                    Console.WriteLine("Switch:" + v);
                    break;
                case 5:
                    Console.WriteLine("Switch:" + v);
                    break;
                
                    default:
                    Console.WriteLine("Switch default:" + v);
                    break;
            }
            s = Console.ReadLine();
            Console.WriteLine("Ez egy szöveg:");
             
            Console.ReadKey();

            
        }
    }
}
