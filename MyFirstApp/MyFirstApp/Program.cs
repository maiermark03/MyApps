using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var myFruit = new List<Fruit1>();
            string neve;
            string szarmazasihelye;
            int mennyisege;
            int gyszam;

            Console.Write("Kérem a gyümölcsök számát:");
            gyszam = int.Parse(Console.ReadLine());

            for (int i = 0; i < gyszam; i++)
            {
                Console.Write("Kérem a(z) {0}. Gyümölcs nevét:", i + 1);
                neve = Console.ReadLine();
                Console.Write("Kérem a(z) {0}. Gyümölcs származásihelyét:", i + 1);
                szarmazasihelye = Console.ReadLine();
                Console.Write("Kérem a(z) {0}. Gyümölcs mennyiségét:", i + 1);
                mennyisege = int.Parse(Console.ReadLine());



                myFruit.Add(new Fruit1(neve, szarmazasihelye,mennyisege));
               
            }
            

            Console.ReadKey();

            
        }
    }
}
