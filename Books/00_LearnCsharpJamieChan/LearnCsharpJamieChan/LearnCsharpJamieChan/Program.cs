using System;

namespace LearnCsharpJamieChan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] userAge = { 21, 22, 23, 24, 25 };

            userAge[0] = 31;

            userAge[2] = userAge[2] + 20; //sum into item

            Console.WriteLine(userAge.Length);

            for(int i = 0; i < 5; i++)
            {
                Console.Write(" " + userAge[i]);
            }

            int[] userAge2; // declared first
            userAge2 = new [] { 21, 22, 23, 24, 25 }; //initialized later

            Console.WriteLine(" ");

            int[] userAge3 = new int[5]; // empt array
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" " + userAge3[i]);
            }
        }
    }
}
