using FRMK.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRMK.ConsoleApp
{
    public class Executor
    {
        private readonly ICalculator _calculator;

        public Executor(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public void Execute()
        {
            int number;
            Console.WriteLine("Insira o número para o cálculo:");
            var value = Console.ReadLine();
            if (!int.TryParse(value, out number))
                Console.WriteLine("Valor inválido, insira um número inteiro.");
            else
            {
                var response = _calculator.GetDivisorsAndPrimeDivisors(number);

                if (response != null)
                {
                    Console.WriteLine("Divisores:" + string.Join(", ", response.Divisors));
                    Console.WriteLine("Divisores Primos:" + string.Join(", ", response.PrimeDivisors));
                }
            }
        }
    }
}
