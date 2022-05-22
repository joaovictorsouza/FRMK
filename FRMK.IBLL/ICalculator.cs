using FRMK.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRMK.IBLL
{
    public interface ICalculator
    {
        DivisorsResponse GetDivisorsAndPrimeDivisors(int number);
        List<int> GetDivisors(int number);
        List<int> FilterPrimeNumbers(List<int> numbers);
        bool IsPrimeNumber(int number);
    }
}
