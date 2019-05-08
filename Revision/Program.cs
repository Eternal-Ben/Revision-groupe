using System;

namespace Revision

{
    class Program
    {
        static void Main(string[] args)
        {
            bool bAchat = Convert.ToBoolean(Console.ReadLine());
            string sAchat = "Souhaitez vous acheter un véhicule ?";
            Console.WriteLine($"{sAchat}");

            if (bAchat)
            {
                var vUneVoiture = new Voiture();
            }

        }
    }
    class Voiture
    {
        static Voiture()
        {
            string sDemmarer = new Contact, // a corriger
                   sRouler = new Avance, // a corriger
                   sAcceler = new Gaz, // a corriger
                   sClee = "voulez vous mettre la clée dans le contact, Oui ou Non ?";

            Console.WriteLine($"{sClee}");
            bool bClee = Convert.ToBoolean(Console.ReadLine());

            if (bClee)
            {
                Console.WriteLine("Parfait, mettez la clee dans le contact pour démarrer");
                new Contact();
                return ;
            }
        }

    }
    class Contact
    {
        static Contact()
        {
            blabla
        }
    }
    class Avance
    {
        static Avance()
        {
            bazlbazlba
        }
    }
    class Gaz
    {
        static Gaz()
        {
            blzalbal
        }
    }
}