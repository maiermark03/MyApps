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
            Random r = new Random();
            ///
            /// Program: Kő papír olló játék leprogramozása
            /// Írta: maier márk.
            /// Adott: számítógép  véletlenszerűen választ k/p/o
            /// Játékos billentyűzeten választ
            /// 



            ///Megoldandó feledat 1:
            ///Ciklus programfutás amíg a felhasználó szeretne játszani.
            ///

            bool moreGame = true;
            
            /// Feledat 2:Változók létrehozása.
            /// 

            string compChoice = "";
            string playerChoice = "";

            int compScore = 0;
            int playerScore = 0;

            Console.WriteLine("*****Kő/Papír/Olló*****");

            do
            {
                ///Feladat 3:
                ///Player választásnak megkérdezése és tárolása.
                ///

                Console.WriteLine("Válasz a Kő/ Papír/ Olló Közül:");
                
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'k':
                        playerChoice = "Kő";
                        break;
                    case 'p':
                        playerChoice = "Papír";
                        break;
                    case 'o':
                        playerChoice = "Olló";
                        break;
                }
                ///Feladat 4: 
                ///Számítógép választásának kérdése random().
                ///
                switch (r.Next(0, 3))
                {
                    case 0:
                        compChoice = "Kő";
                        break;
                    case 1:
                        compChoice = "Papír";
                        break;
                    case 2:
                        compChoice = "Olló";
                        break;
                }
                ///Feladat 6: 
                ///Értékeljük ki a játékot.
                ///
                if (
                    (playerChoice == "Kő" && compChoice == "Papír") ||
                    (playerChoice == "Papír" && compChoice == "Olló") ||
                    (playerChoice == "Olló" && compChoice == "Kő")
                   )
                {
                    Console.WriteLine("Számítógép :" + compChoice + " Te:" + playerChoice);
                    Console.WriteLine("Veszítetél! Állás: Szg: {0} Játékos: {1}", ++compScore, playerScore);
                        
                }
                else if (playerChoice == compChoice)
                {
                    Console.WriteLine("Számítógép :" + compChoice + " Te:" + playerChoice);
                    Console.WriteLine("Döntetlen! Állás: Szg: {0} Játékos: {1}", compScore, playerChoice);

                }
                else
                {
                    Console.WriteLine("Számítógép :" + compChoice + " Te:" + playerChoice);
                    Console.WriteLine("Nyertél! Állás: Szg: {0} Játékos: {1}", compScore, ++playerScore);

                }





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
