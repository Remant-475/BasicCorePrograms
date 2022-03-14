using System;

namespace BasicPrograms
{
    internal class Programs
    {
        public void factor()
        {
            Console.WriteLine("Enter the number");
            int Num = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} Prime Factors is =", Num);
            for (int i = 2; i < Num; i++)
            {
                if (Num % i == 0)
                {
                    Console.WriteLine(i);

                }
            }
        }

        public static void Main(String[] args)
        {
            Programs factors = new Programs();
            factors.factor();
        }
    }
}
