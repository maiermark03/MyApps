using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    class City
    {
        public string Name;
        public string County;
        public int Population;

        public City(string aName,string aCounty,int aPopulation)
        {
            Name = aName;
            Population = aPopulation;
            County = aCounty;
        }
        public City() { }

    }
}
