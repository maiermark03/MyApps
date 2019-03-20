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

            //ex.Name = "Maier Márk";.

            Console.WriteLine(ex.Name);
            //tagfügvény.
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

            //elágazások.
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

            //Egy billentyű leütése.
            //Console.ReadKey(true).KeyChar.
            //integerré konvertálni a console számot(string).
            //int.Parse(Console.WriteLine()).

            //Tömbök.
            //Létrehoztunk egy int tipusútömbötaminek a neve szamok.
            int[] szamok = new int[5];
            string[] szoveg = new string[10];

            //Tömb inicializálás.
            int[] iNums = new int[] { 1, 2, 3, 4, 5, 6 };
            string[] sFruit = new string[] {"Alma","Körte","Eper","Banán"};
            Console.WriteLine("iNums első eleme: {0} sFruit első eleme: {1}", iNums[0], sFruit[0]);
            Console.WriteLine("iNums első eleme:"+ iNums[0] + "sFruit első eleme:" +sFruit[0]);

            //Lista elem
            var Lista = new List<Book>();

            //Új elemek hozzáadása a listához.
            //Ctrl-'.'Hívjuk segítségül.
            Lista.Add(new Book() { Name = "Oroszlánkölykök", Author = "Irwin Shan", Page = 100 });
            Lista.Add(new Book() { Name = "Megkergetve", Author = "Margó István", Page = 200 });
            Lista.Add(new Book() { Name = "Egri csillagok", Author = "Gárdonyi Géza", Page = 1200 });

            //Lista kiirása
            foreach (Book book in Lista)
            {
                Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
            }
            //Lista egy elemének törlése
            Lista.Remove(Lista.Find(x => x.Name.Contains("Oroszlánkölykök")));

            Console.WriteLine("******************************************************************");

            //Lista kiirása
            foreach (Book book in Lista)
            {
                Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
            }

           
            //Lista.Find(x => x.Name.Contains("Oroszlánkölykök"))
            //Console.WriteLine("\nFind: Könyv címe tartalmaz \"Oroszlánkölykök\": {0}",Lista.Find(x => x.Name.Contains("Oroszlánkölykök")).Name);

            Console.ReadKey();

            
        }
    }
}
