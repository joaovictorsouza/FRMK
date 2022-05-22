using FRMK.IBLL;
using FRMK.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRMK.BLL
{
    public class Calculator : ICalculator
    {

        public DivisorsResponse GetDivisorsAndPrimeDivisors(int number)
        {
            var divisors = GetDivisors(number);
            return new DivisorsResponse
            {
                Divisors = divisors,
                PrimeDivisors = FilterPrimeNumbers(divisors)
            };
        }

        public List<int> GetDivisors(int number)
        {
            List<int> result = new List<int>();

            if (number == 0)
                return result;

            int boundary = (int) Math.Floor(Math.Sqrt(number));

            for (int i = 1; i < boundary ; i++)
            {
                if(number % i == 0)
                {
                    result.Add(i);
                    if (i != number / i)
                        result.Add(number / i);
                }
            }

            result.Sort();
            return result;
        }

        public List<int> FilterPrimeNumbers(List<int> numbers)
        {
            return numbers.Where(x => IsPrimeNumber(x)).ToList();
        }

        public bool IsPrimeNumber(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if(number % 2 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));
            for(int i = 3; i <= boundary ; i+= 2)
                if (number % i == 0)
                    return false;
            return true;
        }
    }
}
