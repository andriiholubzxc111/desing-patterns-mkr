using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                DominoBuilder builder = new DominoBuilder();
                List<Domino> dominoes = builder.GenerateDominoes(30);
                builder.PrintDominoes(dominoes);
        }
    }
}
