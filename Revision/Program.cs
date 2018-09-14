using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            MaFerrari = new Voiture;
            MaFerrariDemmare = Voiture + Contact;
            MaFerrariRoule = Voiture + Contact + Vitesse;
        }
        static string Voiture()
        {
            Console.WriteLine("Je test ma nouvelle Ferrari !");
            Console.ReadKey();
        }
    }
}   
