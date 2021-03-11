using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte
{
    class Compte
    {
        private int NumCompt;
        private static int cpt;
        private Client titulaire;
        private MAD solde;
        private static MAD plafond;

        public Compte(Client a,MAD somme,MAD max)
        {
            cpt++;
            NumCompt = cpt;
            titulaire = a;
            solde = somme;
            plafond = max;
        }
        public bool Crediter(MAD somme)
        {
            if (somme.comparer())
            {
                solde += somme;
                return true;
            }
            return false;
        }
        public bool Debiter(MAD somme)
        { 
            if(solde.comparer(somme) && plafond.comparer(somme)) {
                solde -= somme;
                
                return true;
            }
            
            return false;
        }
        public bool Verser(Compte c,MAD somme)
        {
            if (solde.comparer(somme) && plafond.comparer(somme))
            {
                solde -= somme;
                c.solde += somme;
                return true;
            }
            
            return false;

        }
        public void Consulter()
        {
            Console.Out.WriteLine("Numero de compte: " + NumCompt + ".");
            titulaire.afficher();
            solde.afficherval();

        }
    }
}
