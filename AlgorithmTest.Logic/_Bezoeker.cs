using System;

namespace AlgorithmTest.Logic
{
    public class _Bezoeker
    {
        public _Bezoeker(int id, bool isKind)
        {
            this.id = id;
            this.isKind = isKind;
        }
        public int id { get; set; }

        public bool isKind { get; set; }
    }
}
