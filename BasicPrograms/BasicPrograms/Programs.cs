using System;

namespace BasicPrograms
{
    internal class Program 
    {
        public void LeapYear()
        {
            Console.WriteLine("Enter the year");
            int Year = int.Parse(Console.ReadLine());
            if (Year >= 1000 && Year <= 9999)
            {
                if ((Year % 4 == 0 && Year != 100) || (Year % 400 == 0))
                {
                    Console.WriteLine(" It is a Leap Year");
                }
                else
                {
                    Console.WriteLine(" It is not a Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Invalid year");
            }
        }

        public static void Main(String[]args)
        {
            Program Leapyear=new Program();
            Leapyear.LeapYear();
        }

    }

}