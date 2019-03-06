using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpo
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            /// Program: Kő papír olló játék leprogramozása
            /// Írta: maier márk.
            /// Adott: számítógép  véletlenszerűen választ k/p/o
            /// Játékos billentyűzeten választ


            ///Megoldandó feledat 1:
            ///Ciklus programfutás amíg a felhasználó szeretne játszani.
            bool moreGame = true;

            string compChoice = "";
            string playerChoice = "";

            int compScore = 0;
            int playerScore = 0;

            Console.WriteLine("*****Kő/Papír/Olló*****");

            do
            {



                Console.Write("Akarsz még játszani? i/n");
                if (Console.ReadKey(true).KeyChar == 'n')
                {
                    moreGame = false;
                }
            } while (moreGame);


            Console.ReadKey();

            
        }
    }
}
