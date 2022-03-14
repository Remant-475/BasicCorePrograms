using System;


namespace BasicPrograms
{
     class Programs
    {
        public void VowelandConsonant()
        {
            Console.WriteLine("Enter the character :");
            char ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Albhabet is Vowel");
                    break;
                default:
                    Console.WriteLine("Albhabet is Consonant");
                    break;

            }

        }
        public static void Main(String[] args)
        {
            Programs vowel = new Programs();
            vowel.VowelandConsonant();
        }
    }

}
