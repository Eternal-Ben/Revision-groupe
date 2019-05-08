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
            var sAcceler = new Gaz();

            string sClee = "voulez vous mettre la clée dans le contact, Oui ou Non ?";

            Console.WriteLine($"{sClee}");
            bool bClee = Convert.ToBoolean(Console.ReadLine());

            if (bClee)
            {
                Console.WriteLine("Parfait, mettez la clee dans le contact pour démarrer");
                new Contact();
            }
        }

    }
    class Contact
    {
        static Contact()
        {
            var sDemmarer = new Contact();
            if (Convert.ToBoolean(sDemmarer))
            {
                Console.WriteLine("bruit du demareur");
                Console.WriteLine("On avance ?");
                var sRouler = new Avance(); // à remettrte pouir plus tard....
            }
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