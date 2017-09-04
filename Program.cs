using System;

namespace hwapp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int score = 10;
            int lives = 3;
            int answer;

            // Math
            answer = score + lives + 1;

            Console.WriteLine(answer);
        }
        public static void Awesome() {
            Console.WriteLine(score);
        }
    }
}
