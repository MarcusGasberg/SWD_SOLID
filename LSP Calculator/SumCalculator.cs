using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Calculator
{
    public abstract class Calculator
    {
        protected readonly int[] _numbers;

        protected Calculator(int[] numbers)
        {
            _numbers = numbers;
        }
        public abstract int Calculate();
    }

    public class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers) : base(numbers)
        {
        }
        public override int Calculate() => _numbers.Sum();
    }

    public class EvenNumbersSumCalculator : Calculator
    {
        public EvenNumbersSumCalculator(int[] numbers) : base(numbers)
        {
        }
        public override int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
    }
}