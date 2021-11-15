using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecomposeDll
{
    public class Decompose
    {
        public List<int> DivisorsNumbers(int value)
        {
            if (value < 1)
                throw new ArgumentException("O valor de entrada inválido.");

            var valuesList = new List<int>();
            for (int i = 1; i <= value; i++)
            {
                if(value%i==0)
                    valuesList.Add(i);
            }
            return valuesList;
        }

        public List<int> PrimeNumbers(int value)
        {
            if (value < 1)
                throw new ArgumentException("O valor de entrada inválido.");


            var valuesList = new List<int>();
            var divisors = DivisorsNumbers(value);

            foreach (var divisor in divisors)
            {
                var count = DivisorsNumbers(divisor).Count;
                if (count == 1 || count == 2)
                    valuesList.Add(divisor);
            }

            return valuesList;
        }
    }
}
