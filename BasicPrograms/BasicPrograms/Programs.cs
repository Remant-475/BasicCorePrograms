using System;

namespace BasicPrograms
{
     class Programs
    {
        public void QuotientAndRemainder()
        {
            Console.WriteLine("Enter the Number");
            int Num = int.Parse(Console.ReadLine());
            Console.WriteLine(" Number divided by");
            int Divide = int.Parse(Console.ReadLine());
            int Num1;
            int Num2;

            Num1 = (Num % Divide);
            Console.WriteLine("Remainder of Number = " + Num1);
            Num2 = (Num / Divide);
            Console.WriteLine("Quotient of Number = " + Num2);

        }

        public static void Main(String[]args)
        {
            Programs quotient=new Programs();
            quotient.QuotientAndRemainder();
        }
    }
}