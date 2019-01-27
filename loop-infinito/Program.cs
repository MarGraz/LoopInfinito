using System;
using System.Collections.Generic;

namespace loop_infinito
{
    class Program
    {
        static void Main(string[] args)
        {
            string numRighe;

            //loop infinito per far eseguire il programma di continuo finché l'utente non scrive NO
            while (true)
            {
                Console.Write("Inserisci il numero di righe, altrimenti scrivi no per interrompere: ");
                numRighe = Console.ReadLine();

                if (numRighe == "no")
                {
                    Console.WriteLine("Termina esecuzione, premi Invio ");
                    Console.ReadLine();

                    break;
                }

                int righe = Int32.Parse(numRighe);

                string asterisco = "* ";

                List<string> listOfAsterisks = new List<string>();

                int x = 0;

                for (int r = 1; r <= righe; r++)
                {
                    //ad ogni ciclo di aggiunta riga (r), aggiungi un asterisco
                    for (int ast = 1; ast <= r; ast++)
                    {
                        listOfAsterisks.Add(asterisco);
                        Console.Write(listOfAsterisks[x].ToString());
                    }

                    Console.Write("\n");
                    x++;                      
                }
            }
        }
    }
}
