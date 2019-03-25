using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    class Program
    {
        static void Main(string[] args)
        {
           
            

            Console.WriteLine("Köszötelek a város keresőben.");

            var Lista = new List<City>();
            ///A lista elem hozzá adása
            Lista.Add(new City() { Name = "Balassagyarmat", County = "Nógrád", Population = 20000 });
            Lista.Add(new City() { Name = "Salgótarján", County = "Nógrád", Population = 35000 });
            Lista.Add(new City() { Name = "BudaPest", County = "Pest", Population = 2000000 });

            ///A lista  elem kiírása
            foreach (City city in Lista)
            {
                Console.WriteLine(city.Name + " " + city.County + " " + city.Population);
            }
            ///A lista kitörlése
            Lista.Remove(Lista.Find(x => x.Name.Contains("BudaPest")));

            Console.WriteLine("******************************************************************");

            //Lista kiirása
            foreach (City city in Lista)
            {
                Console.WriteLine(city.Name + " " + city.County + " " + city.Population);
            }


            Console.ReadKey();
        }
    }
}
