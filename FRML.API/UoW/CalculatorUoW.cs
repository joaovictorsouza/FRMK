using FRMK.IBLL;

namespace FRML.API.UoW
{
    public class CalculatorUoW : BaseUoW
    {
        public ICalculator Calculator;
        public CalculatorUoW(ICalculator calculator)
        {
            Calculator = calculator;
        }
    }
}
