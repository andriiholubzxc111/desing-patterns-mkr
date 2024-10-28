using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public class Domino
    {
        public int FirstValue { get; set; }
        public int SecondValue { get; set; }
        public Domino(int firstValue, int secondValue)
        {
            this.FirstValue = firstValue;
            this.SecondValue = secondValue;
            if (firstValue < 0 || firstValue > 6 || secondValue < 0 || secondValue > 6)
            {
                throw new Exception("Значення тільки від 0 до 6");
            }
        }
         public override string ToString()
        {
            return $"{FirstValue}, {SecondValue}";
        }
    }
    }
}
