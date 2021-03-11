using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte
{
    class MAD
    {
        private double valeur;
        public MAD() { 
            valeur = 0;
        }
        public MAD(double a)
        {
            valeur = a;
        }
        public void afficherval()
        {
            Console.Out.WriteLine("Solde :" + valeur + "MAD.");
        }
        public static MAD operator+(MAD a,MAD b)
        {
            MAD m = new MAD();
            m.valeur = a.valeur+ b.valeur;
            return m;
        }
        public static MAD operator -(MAD a, MAD b)
        {
            MAD m = new MAD();
            m.valeur = a.valeur - b.valeur;
            return m;
        }
        public  bool comparer()
        {
            if (valeur > 0)
            {
                return true;
            }
            return false;
        }
        public bool comparer(MAD a)
        {
            if (valeur > a.valeur)
            {
                return true;
            }
            return false;
        }
    }
}
