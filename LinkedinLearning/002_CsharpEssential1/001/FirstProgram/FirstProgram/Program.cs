using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var challenge = "   The Text processing in C# is really great.   ";
            Console.WriteLine(challenge.Trim().Substring(24, challenge.Trim().Length - 25).ToUpper().Trim());
        }
    }
}
