namespace ArmstrongNumber
{
    using System;
    public class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var num = number;

            var digitsCount = number.ToString().Length;
            var remainingNumber = 0;
            var sum = 0;
            var exponent = 1;

            for (int i = 1; i <= digitsCount; i++)
            {
                remainingNumber = number % 10;

                for (int x = 1; x <= digitsCount; x++)
                {
                    exponent *= remainingNumber;
                }

                remainingNumber = exponent;
                exponent = 1;
                sum += remainingNumber;
                number /= 10;
            }

            if (sum == num)
            {
                Console.WriteLine("{0} is an Armstrong number.", num);
            }

            else
            {
                Console.WriteLine("{0} is not an Armstrong number.", num);
            }
        }
    }
}