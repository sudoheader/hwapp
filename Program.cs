using System;

namespace hwapp
{
    class Program
    {
        public const int GlobalScore = 1;
        public static void Main(string[] args)
        {
            int score = 10;
            int lives = 3;
            int answer;

            // Math
            answer = score + lives + 1;

            Awesome();
        }
        public static void Awesome() {
            Console.WriteLine(GlobalScore);
        }
    }
}
