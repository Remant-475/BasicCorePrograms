using System;


namespace BasicPrograms
{
     class Programs
    {
        public void harmonicnumber()
        {
            Console.WriteLine("Enter Number");
            int Num = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= Num; i++)
            {
                Console.WriteLine("1/{0}+", i);
                sum += 1 / (float)i;
            }
            Console.Write("\n");
            Console.WriteLine("Harmonic Value is :" + sum);
        }
        public static void Main(String[] args)
        {
            Programs harmonic = new Programs();
            harmonic.harmonicnumber();
        }


    }
}