using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maganhangzok
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            string mgh = "AaEeIiOoUu";
            int mgh_szam = 0;

            Console.Write("Kérem a szöveget:");

            str = Console.ReadLine();

            Console.Write("A magánhangzók száma:");


            for (int i = 0; i < str.Length; i++)
            {
                if (mgh.Contains(str[i]))
                {
                    mgh_szam++;
                }
            }
            Console.Write(mgh_szam);
            Console.ReadKey();
        }
    }
}
