using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte
{
    class Program
    {
        static void Main(string[] args)
        {
            Client Clt = new Client("BICHRY", "Youssef", "Casablanca");
            MAD sld = new MAD(10000);
            MAD plafond = new MAD(3000);
            Compte cpt = new Compte(Clt,sld,plafond);
            //L'affichage du compte
            cpt.Consulter();
            Console.Out.WriteLine("********************************************");
            //Crediter le compte
            MAD s1 = new MAD(2000);
            if (cpt.Crediter(s1))
            {
                Console.Out.WriteLine("Operation bien effectuee");
            }
            //L'affichage du compte apres l'avoir credité
            cpt.Consulter();
            Console.Out.WriteLine("********************************************");
            //Debiter le compte
            MAD s2 = new MAD(1000);
            //Debiter le compte
            if (cpt.Debiter(s2)==true)
            {
                Console.Out.WriteLine("Operation bien effectuee");
            }
            else
            {
                Console.Out.WriteLine("Solde insuffisant");
            }
            //Affichage du compte apres le debit
            cpt.Consulter();
            Console.Out.WriteLine("********************************************");
            Client Clt1 = new Client("JAHID", "Hamza", "Casablanca");
            MAD sld1 = new MAD(20000);
            Compte cpt2 = new Compte(Clt1, sld1, plafond);
            MAD s3 = new MAD(1000);
            //Effectuer un virement
            if(cpt.Verser(cpt2, s3) == true)
            { 
                Console.Out.WriteLine("Operation bien effectuee");
            }
            else
            {
                Console.Out.WriteLine("Solde insuffisant");
            }
            //L'affichage du premier compte
            cpt.Consulter();
            Console.Out.WriteLine("********************************************");
            //L'affichage du deuxieme compte
            cpt2.Consulter();


            Console.ReadKey();
        }
    }
}
