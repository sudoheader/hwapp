using System;

namespace hwapp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numbers = 1;
            int answers = 2;

            // if(condition)
            // action

            if(numbers == 2)
                Console.WriteLine("Yes");
            else if(answers == 1)
                Console.WriteLine("Maybe");
            else
                Console.WriteLine("No");
        }
    }
}
