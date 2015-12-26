using System;

namespace DelegateTest
{
    class Program
    {
        public delegate int CalculationHandler(int x, int y);

        public delegate double DoubleOp(double x);
        static void Main(string[] args)
        {
            var math = new Math();
            int i = 0;

            #region CalCulationHandler
            //Creating the instance of the delegate class
            var sumHandler = new CalculationHandler(math.Sum);

            //invoke the delegate
            int result = sumHandler(10, 20);
            Console.WriteLine("Result of the sum is => {0}", result); 
            Console.WriteLine();
            #endregion

            #region DoubleOp

            DoubleOp[] operations =
            {
                math.MultiplyByTwo,
                math.Square
            };

            for (; i < operations.Length; i++)
            {
                Console.WriteLine("Using operations[{0}] : ", i);
                ProcessAndDisplayNumbers(operations[i], 2.40);
                ProcessAndDisplayNumbers(operations[i], 7.23);
                ProcessAndDisplayNumbers(operations[i], 10.20);
                Console.WriteLine();
            }
            #endregion

            Console.ReadKey();
        }

        private static void ProcessAndDisplayNumbers(DoubleOp action, double value)
        {
            double result = action(value);
            Console.WriteLine("value is => {0}, result of operation is => {1:f2}", value, result);
        }
    }
}
