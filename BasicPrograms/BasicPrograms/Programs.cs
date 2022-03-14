using System;

namespace BasicPrograms
{
     class Programs
    {
        public void SwapNumber()
        {
            Console.WriteLine("Enter Number a : ");
            int Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number b :");
            int Num2 = int.Parse(Console.ReadLine());

            Num1 = Num1 * Num2;
            Num2 = Num1 / Num2;
            Num1 = Num1 / Num2;

            Console.WriteLine("Number after Swapping \n");
            Console.WriteLine("Number a :" + Num1 + " Number b :" + Num2);


        }
        public static void Main(String[]args)
        {
            Programs swap=new Programs();
            swap.SwapNumber();
        }
    }
}
