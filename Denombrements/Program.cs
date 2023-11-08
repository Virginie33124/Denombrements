/**
 * Titre : B1.2 Exercice cours
 * Description : Dénombrements
 * Auteur : VDL
 * Date création : 08/11/2023
 * Date dernière modification :
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        static int t, n;
        static void saisie() 
        {
            // Saisir le nombre d'éléments à gérer
            Console.Write("nombre total d'éléments à gérer = ");
            t = int.Parse(Console.ReadLine());
            // Saisir le sous ensemble
            Console.Write("nombre d'éléments dans le sous ensemble = ");
            n = int.Parse(Console.ReadLine());
           
        }
        static void Main(string[] args)
        {
            int c = 1;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());

                if (c == 0)
                {
                    Environment.Exit(0);
                }

                if (c == 1)
                {
                    // Saisir le nombre d'élement à gérer
                    Console.Write("nombre total d'éléments à gérer = ");
                    n = int.Parse(Console.ReadLine()); 
                    // Calcul de r                                       
                    long r = 1;
                    for (int k = 1; k <= n; k++)
                        r *= k;
                    Console.WriteLine(n + "! = " + r);
                }
                else
                {
                    if (c == 2)
                    {
                        // Saisir le nombre d'éléments à gérer
                        saisie();
                        // Calcul de r
                        long r = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r *= k;
                        // Affichage du résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                    }
                    else
                    {
                        // Saisir le nombre d'éléments à gérer
                        saisie();
                        // Calcul de r
                        long r = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r *= k;
                        // Calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= n; k++)
                            r2 *= k;
                        // Calcul de r3 ("résultat = " + (r1 / r2));
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
