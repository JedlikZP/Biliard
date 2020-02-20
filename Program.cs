
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> golyók = new List<int>();
            kezdes(golyók);
            int leesett;
            int szamolo = 0;

            do
            {
                szamolo++;
                leesett = eltettsors(golyók);
                Console.WriteLine($"A lelökött golyó: {leesett} ");
                kiiro(golyók);
                Console.ReadKey();

            } while (golyók.Contains(8));

            if (golyók.Count == 0)
            {
                Console.WriteLine("Nyertél!");
            }
            else
            {
                Console.WriteLine("Vesztettél.");
            }

            Console.ReadKey();
        }

        static void kiiro(List<int> golyók)
        {
            foreach (var item in golyók)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static int eltettsors(List<int> golyók)
        {
            Random rnd = new Random();
            int szám = rnd.Next(golyók.Count);
            int sorsolt = golyók[szám];
            golyók.Remove(golyók[szám]);
            return sorsolt;
        }

        static void kezdes(List<int> golyók)
        {
            for (int i = 1; i <= 15; i++)
            {
                golyók.Add(i);
            }
        }
    }
}