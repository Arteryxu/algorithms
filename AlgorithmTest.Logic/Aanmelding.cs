using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTest.Logic
{
    public class Aanmelding
    {
        public void bezoekerToevoegen()
        {
            Random rnd = new Random();

            //Lijst van alle bezoekers
            List<_Bezoeker> ledenList = new List<_Bezoeker>();
            ledenList.Add(new _Bezoeker(1, false));
            ledenList.Add(new _Bezoeker(2, false));
            ledenList.Add(new _Bezoeker(3, true));
            ledenList.Add(new _Bezoeker(4, false));
            ledenList.Add(new _Bezoeker(5, true));

            int maxBezoekers = rnd.Next(3, 6);
            int aantalKinderen = 0;
            int aantalVolwassenen = 0;
            int groepGrootte = rnd.Next(1, ledenList.Count());
            int groepId = 1;
            int huidigeBezoekers = 0;

            List<_GroepLid> groepen = new List<_GroepLid>();
            for (int i = 1; i <= maxBezoekers;)
            {
                //Controle of niet de hele lijst al door is
                huidigeBezoekers = i;
                if(huidigeBezoekers < maxBezoekers && huidigeBezoekers == ledenList.Count)
                {
                    break;
                }

                if(groepGrootte==groepen.Count())
                {
                    groepId++;
                    aantalKinderen = 0;
                    aantalVolwassenen = 0;
                }

                int newBezoeker = rnd.Next(0, ledenList.Count());
                if (!ledenList[newBezoeker].isKind)
                {
                    aantalVolwassenen++;
                }
                else if (aantalVolwassenen > 0)
                {
                    aantalKinderen++;
                }

                if (!ledenList[newBezoeker].isKind || aantalVolwassenen > 0)
                {
                    groepen.Add(new _GroepLid(groepId, ledenList[newBezoeker], aantalKinderen));
                    ledenList.RemoveAt(newBezoeker);
                    i++;
                }
            }
        }
    }
}
