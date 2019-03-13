using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esf
{
    class Excercise
    {
        /// <summary>
        /// Public :nyilvános elérés.
        /// </summary>
        ///Adattagok létrehozása: public ,private ,preotectod
        public string Name;

        //Konstruktor : inicilizálja az osztály adatjait
        public Excercise(string aName)
        {
           Name = aName;
        } 
        //tagfügvény 
        public void printName()
        {
            Console.WriteLine(Name);
        }
        public string getName()
        {
            return Name;
        }
      
    }
}
