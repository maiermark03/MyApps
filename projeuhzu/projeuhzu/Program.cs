using System;

namespace projeuhzu
{
    class Program
    {
        static void Main(string[] args)
        {

            string i, n ;
            string v;
            Console.WriteLine("*****Szia szereted a infót? i/n:*****");

            switch (Console.ReadKey(true).KeyChar)
            {
                case 'i':
                    Console.WriteLine("Gyere a Szondiba!!!");
                    break;
                case 'n':
                    Console.WriteLine("Gyere a Szondiba!!!");
                    break;

                default:
                    Console.WriteLine("Köszönöm a választ!");
                    break;
            }
            Console.WriteLine("Köszönöm a választ!");

            Console.ReadKey();
        }
    }
}
