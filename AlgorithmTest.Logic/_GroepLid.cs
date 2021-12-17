using AlgorithmTest.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest.Logic
{
    class _GroepLid
    {
        public _GroepLid(int groepId, _Bezoeker bezoeker, int aantalKinderen) 
        {
            this.groepId = groepId;
            this.bezoeker = bezoeker;
            this.aantalKinderen = aantalKinderen;
        }

        public int groepId { get; set; }

        public _Bezoeker bezoeker { get; set; }

        public int aantalKinderen { get; set; }
    }
}
