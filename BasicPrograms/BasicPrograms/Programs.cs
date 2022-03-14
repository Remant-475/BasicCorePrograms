using System;


namespace BasicPrograms
{
     class Programs
    {
        public void PowerOfTwo()
        {
            Console.WriteLine("Enter the Power ");
            int Num = int.Parse(Console.ReadLine());

            if (0 <= Num && Num < 31)
            {
                for (int i = 1; i <= Num; i++)
                {
                    Console.WriteLine("2^" + i + "=" + Math.Pow(2, i));
                }
            }
            else
            {
                Console.WriteLine("Exceed the range of integer datatype");
            }
        }
        public static void Main(String[] args)
        {
            Programs powerof = new Programs();
            powerof.PowerOfTwo();
        }
    }
}