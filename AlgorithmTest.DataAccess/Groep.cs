using AlgorithmTest.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest.DAL
{
    class Groep
    {
        public int id { get; set; }

        public List<Bezoeker> ledenList { get; set; }

        public int aantalKinderen { get; set; }
    }
}
