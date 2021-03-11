using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte
{
    class Client
    {
        private string Nom;
        private string Prenom;
        private string Adresse;
        public Client()
        {
            Nom = "";
            Prenom = "";
            Adresse = "";
        }
        public Client(string a,string b,string c)
        {
            Nom = a;
            Prenom = b;
            Adresse = c;
        }
        public void afficher()
        {
            Console.Out.WriteLine("Nom :" + Nom + ".");
            Console.Out.WriteLine("Prenom :" + Prenom + ".");
            Console.Out.WriteLine("Adresse :" + Adresse + ".");

        }
    }
}
