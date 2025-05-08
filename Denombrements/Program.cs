using System;

namespace Denombrements
{

    /// <summary>
    /// Classe principale de l'application
    /// Programme de calcul de dénombrements : Permutation, Arrangement et Combinaison
    /// </summary>
    class Program
    {
        /// <summary>
        /// Méthode de calcul des arrangements
        /// </summary>
        /// <param name="t"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static long Calcul2(int t, int n)
        {
            long r = 1;

            for (int k = (t - n + 1); k <= t; k++)
                r *= k;


            return r;
        }


        /// <summary>
        /// Méthode de calcul des permutations
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static long Calcul1(int n)
        {
            long r = 1;

            for (int k = 1; k <= n; k++)
                r *= k;

            return r;
        }

        /// <summary>
        /// Méthode de saisie d'un entier
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        static int Saisie(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Erreur de saisie, veuillez recommencer");
                }
            }
        }


        /// <summary>
        /// Méthode principale de l'application
        /// Se lance au démarrage de l'application et gère le déroulement du programme
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //déclaration
            int c = 1;
            long r1, r2, r3, r4;
            const string MESSAGE1 = "nombre total d'éléments à gérer = ", MESSAGE2 = "nombre d'éléments dans le sous ensemble = ";

            // boucle principale
            while (c != 0)
            {
                try
                {
                    // affichage du menu
                    Console.WriteLine("Permutation ...................... 1");
                    Console.WriteLine("Arrangement ...................... 2");
                    Console.WriteLine("Combinaison ...................... 3");
                    Console.WriteLine("Quitter .......................... 0");

                    // saisie du choix
                    c = Saisie("Choix :                            ");

                    switch (c)
                    {

                        // l'utilisateur choisi la permutation
                        case 1:

                            // saisie du nombre d'éléments à gérer
                            int n1 = Saisie(MESSAGE1);

                            // calcul de r1
                            r1 = Calcul1(n1);

                            // affichage du résultat
                            Console.WriteLine(n1 + "! = " + r1);
                            break;

                        // l'utilisateur choisi l'arrangement
                        case 2:

                            // saisie du nombre d'éléments à gérer
                            int t2 = Saisie(MESSAGE1);

                            // saisie du nombre d'éléments dans le sous ensemble
                            int n2 = Saisie(MESSAGE2);

                            // calcul de r2
                            r2 = Calcul2(t2, n2);

                            // affichage du résultat
                            Console.WriteLine("A(" + t2 + "/" + n2 + ") = " + r2);
                            break;

                        // l'utilisateur choisi la combinaison
                        case 3:

                            // saisie du nombre d'éléments à gérer
                            int t3 = Saisie(MESSAGE1);

                            // saisie du nombre d'éléments dans le sous ensemble
                            int n3 = Saisie(MESSAGE2);

                            // calcul de r3
                            r3 = Calcul2(t3, n3);

                            // calcul de r4
                            r4 = Calcul1(n3);

                            // affichage du résultat
                            Console.WriteLine("C(" + t3 + "/" + n3 + ") = " + (r3 / r4));
                            break;

                        //l'utilisateur choisi de quitter
                        case 0:

                            //sortie du programme
                            Environment.Exit(0);
                            break;

                        // l'utilisateur a fait un choix incorrect
                        default:

                            // affichage d'un message d'erreur
                            Console.WriteLine("Erreur de saisie, veuillez recommencer");
                            break;
                    }
                }
                catch
                {
                    // affichage d'un message d'erreur
                    Console.WriteLine("Erreur, veuillez recommencer");
                }
            }

            // permet de garder la console ouverte
            Console.ReadLine();
        }
    }
}
