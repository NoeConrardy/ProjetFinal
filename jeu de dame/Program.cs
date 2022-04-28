using System;

namespace jeu_de_dame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------");
            Console.Write("|");
            Console.Write("Jeu de dame");
            Console.WriteLine("|");
            Console.WriteLine("-------------");
            Console.WriteLine("");

            int[,] array2d = new int[10, 10];

            ConstruireDamier(ref array2d);
            AfficherMatrice(array2d);
            Console.WriteLine("....................");

            pionNoirPlace(ref array2d);
            AfficherMatrice(array2d);
            Console.WriteLine("....................");

            pionBlancPlace(ref array2d);
            AfficherMatrice(array2d);
            Console.WriteLine("....................");


            //ModifierMatrice(ref array2d, nombre);


        }
        static void AfficherMatrice(int[,] array2d)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(" "+array2d[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void ConstruireDamier(ref int[,] array2d)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array2d[ i , j ] = 0 ; 
                }
            }
        }

        static void ModifierMatrice(ref int[,] array2d, int nombre)
        {
            array2d[1, 1] = nombre;
        }
    
        static void pionNoir()
        {

        }
        static void pionBlanc()
        {

        }

        static void pionNoirPlace(ref int[,] array2d)
        {
            for (int ligne = 0; ligne < 4; ligne++)
            {
                for (int colonne = 0; colonne < 10; colonne++)
                {
                    if (ligne % 2 == 0)
                    {
                        if (colonne % 2 != 0)
                        {
                            array2d[ligne, colonne] = 1;
                        }
                    }
                    else if (ligne % 2 != 0)
                    {
                        if (colonne % 2 == 0) 
                        {
                            array2d[ligne, colonne] = 1;
                        }
                    }
                }
            }
        }


        static void pionBlancPlace(ref int[,] array2d)
        {
            for (int ligne = 6; ligne < 10; ligne++)
            {
                for (int colonne = 0; colonne < 10; colonne++)
                {
                    if (ligne % 2 == 0)
                    {
                        if (colonne % 2 != 0)
                        {
                            array2d[ligne, colonne] = 2;
                        }
                    }
                    else if (ligne % 2 != 0)
                    {
                        if (colonne % 2 == 0)
                        {
                            array2d[ligne, colonne] = 2;
                        }
                    }
                }
            }
        }
    }

    /*static void bougerPionNoir(ref int[,] array2d)
    {
        
    }*/

    /*static void bougerPionBlanc(ref int[,] array2d)
    {
    }*/

}
