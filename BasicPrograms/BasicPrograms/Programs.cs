using System;


namespace BasicPrograms
{
    class Programs
    {
        public void EvenAndOdd()
        {
            Console.WriteLine("Enter the number");
            int Num = int.Parse(Console.ReadLine());

            if (Num % 2 == 0)
            {
                Console.WriteLine("Number is Even");

            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
        public static void Main(string[] args)
        {
            Programs evenandodd = new Programs();
            evenandodd.EvenAndOdd();
        }
    }
    
}