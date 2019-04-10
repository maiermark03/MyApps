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
            Console.Write(x == 5 ? "x == 5" : "x != 5");
            // int cast
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                Console.Write(ch + "->" +(int)ch+ ' ');
            }
            Console.WriteLine();
            //Tömb
            int iPrev;
            int[] iTomb = new int[10];
            Random r = new Random();
            for (int i = 0; i < iTomb.Length; i++)
            {
                //iTomb[i] = r.Next();
                Console.Write("Kérek az {0}. számot:", i);
                try
                {
                    iTomb[i] = int.Parse(Console.ReadLine());
                    iPrev = i;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Hiba!!nem megfelelő az adat.");
                    i = iPrev;
                }
            }
            Console.WriteLine();

            for (int i = 0; i < iTomb.Length; i++)
            {
                Console.Write(iTomb[i] + " ");
            }

            int[] iArr = new int[] { 1, 2, 3, 4, 5 };
            string[] sArr = new string[] { "alma", "korte" };

            Array.Sort(sArr);
            for (int i = 0; i < sArr.Length; i++)
            {
                Console.Write(sArr[i] + " ");

            }


            int[,] matrix = new int[,]
            {
                {12, 23, 2 },
                {13, 67, 52 },
                {45, 55, 1 }
            };


            Console.ReadKey();
        }
    }
}
