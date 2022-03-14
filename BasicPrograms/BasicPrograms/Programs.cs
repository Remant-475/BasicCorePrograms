using System;

namespace BasicProgrms
{
    class Program
    {
        public void FlipCoin()
        {
            Console.WriteLine("Enter the number of flip of coin");
            int Num = int.Parse(Console.ReadLine());
            int headcount = 0;
            int tailcount = 0;

            for (int i = 0; i < Num; i++)
            {
                Random random = new Random();
                float flipcoin = random.Next(0, 2);
                if (flipcoin < 0.5)
                {
                    Console.WriteLine("Coin is tail");
                    tailcount++;
                }
                else
                {
                    Console.WriteLine("Coin is head");
                    headcount++;
                }

            }
            Console.WriteLine("number of heads : " + headcount);
            Console.WriteLine("number of tails : " + tailcount);
            float HeadPercent;
            float TailPercent;

            HeadPercent = (headcount * 100) / Num;
            Console.WriteLine("Percentage of Head :" + HeadPercent);
            TailPercent = 100 - HeadPercent;
            Console.WriteLine("percentage of Tail :" + TailPercent);
        }

        public static void Main(String[]args)
        {
            Program flipcoin = new Program;
            flipcoin.FlipCoin();

        }
            
    }

}