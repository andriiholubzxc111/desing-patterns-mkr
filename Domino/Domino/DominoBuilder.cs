using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domino
{
    public class DominoBuilder
    {
        private readonly Random random = new Random();
        private readonly List<Domino> dominoes = new List<Domino>();

        public List<Domino> GenerateDominoes(int count)
        {
            if (count < 1)
                throw new Exception("Кількість доміно у списку повинна бути бфльша за 1.");
            while (dominoes.Count < count)
            {
                var domino = new Domino(random.Next(0, 7), random.Next(0, 7));
                dominoes.Add(domino);
            }
            return dominoes.ToList();
        }
        public void PrintDominoes(List<Domino> dominoes)
        {
            foreach (var domino in dominoes)
            {
                Console.WriteLine(domino);
            }

        }
    }
}