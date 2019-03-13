using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masalhangzok
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            string msh = "qwrtzpsdfghjklyxcvbnm";
            int msh_szam = 0;

            Console.Write("kérem a szöveget:");

            str = Console.ReadLine();

            Console.Write("Mássalhangzók száma:");

            for (int i = 0; i < str.Length; i++)
            {
                if (msh.Contains(str[i]))
                {
                    msh_szam++;
                }
            }
            Console.Write(msh_szam);
            Console.ReadKey();
        }
    }
}
