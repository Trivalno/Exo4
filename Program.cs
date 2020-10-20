/**
 * Exo 4 calcul dans un affichage
 * Tristan
 * 08/10/2020
 */
using System;


namespace Exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            //déclaration
            float ht, tva;

            //Saisie valeur
            Console.Write("Entrez le prix HT = ");
            ht = float.Parse(Console.ReadLine());           
            Console.Write("Entrez le prix TVA =");
            tva = float.Parse(Console.ReadLine());

            //calcul et affichage resultat
            Console.Write("Le prix Total est de = " +(ht*(1+(tva/100)))+"€");
            Console.ReadLine();

        }
    }
}
