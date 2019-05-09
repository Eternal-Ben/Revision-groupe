using System;

namespace Revision

{
    class Program
    {
        static void Main(string[] args)
        {
            string bAchat = Console.ReadLine(),
                   sAchat = "Souhaitez vous acheter un véhicule ?";
            bool vOui = Convert.ToBoolean(bAchat is "o");
 //                  vNon = Convert.ToBoolean(bAchat is "n");
            Console.WriteLine($"{sAchat}", bAchat);

            if (vOui)
            {
                var vUneVoiture = new Voiture();
                string sInvite = "j'ai ce model à vous faire essayer pour confirmer votre achat, prennez place.";
                Console.WriteLine(vUneVoiture + sInvite, "Tenez la clée");
            }
            else
            {
                Console.WriteLine("Pas de soucis et repasser nous voir à l'occasion");
                return;
            }
        }
    }
    class Voiture
    {
        static Voiture()
        {
            string sClee = "voulez vous mettre le contact ?";
            bool bClee = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine($"{sClee}");

            if (bClee)
            {
                Console.WriteLine("Parfait, mettez la clee dans le contact pour démarrer");
                new Contact();
            }
        }

    }
    class Contact(sBruit)
    {
        static Contact()
    {
        string bruit = "bruit du demareur",
        var sDemmarer = new Contact();
        roule = "Aller on roule";
        if (Convert.ToBoolean(sDemmarer))
        {
            Console.WriteLine($"{bruit}");
            var sRouler = new Avance(roule);
        }
        return bruit;
        Console.WriteLine();
    }
}
class Avance
{
    static Avance()
    {
        //           var sAcceler = new Gaz();
        var sAcceler = new Gaz();
        Console.WriteLine("On avance ?");
        Convert.ToBoolean(Console.ReadLine());
    }
}
class Gaz
{
    static Gaz()
    {
    }
}
}