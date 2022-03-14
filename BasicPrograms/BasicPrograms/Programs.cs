using System;

namespace BasicPrograms
{
     class Programs
    {
        public void SwapNumber()
        {
            Console.WriteLine("Enter Number a : ");
            int Num_a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number b :");
            int Num_b = int.Parse(Console.ReadLine());

            Num_a = Num_a * Num_b;
            Num_b = Num_a / Num_b;
            Num_a = Num_a / Num_b;

            Console.WriteLine("Number after Swapping \n");
            Console.WriteLine("Number a :" + Num_a + " Number b :" + Num_b);


        }
        public static void Main(String[]args)
        {
            Programs swap=new Programs();
            swap.SwapNumber();
        }
    }
}
