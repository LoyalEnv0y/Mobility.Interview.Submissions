using System.Runtime.InteropServices;

namespace QuestionThree
{
    class Program
    {
        public static void Main(string[] args)
        {
            const string dllPath = @"../../../../Multiply/x64/Debug/Multiply.dll";

            [DllImport(dllPath)]
            static extern double getProduct(double a, double b);

            double x = getInput();
            double y = getInput();
            Console.WriteLine($"x => {x}, y => {y}");
            Console.WriteLine(getProduct(x, y));
        }

        public static double getInput()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter a number");
                    Console.Write("> ");

                    double input = Convert.ToDouble(Console.ReadLine());
                    return input;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please only provide numbers");
                }
            }

        }
    }
}
