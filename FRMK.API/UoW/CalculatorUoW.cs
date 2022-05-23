using FRMK.IBLL;

namespace FRMK.API.UoW
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
