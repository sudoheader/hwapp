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
            int answer = 4;

            // Math
            answer = score + lives + 1;

            Awesome(answer);
        }
        public static void Awesome(int a) {
            Console.WriteLine(GlobalScore + a);
        }
        public static void addition(int b) {
            Console.WriteLine(b);
        }
    }
}
