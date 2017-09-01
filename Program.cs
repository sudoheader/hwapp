using System;

namespace hwapp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Awesome();
            writeToTheScreen();
        }
        public static void Awesome() {
            Console.WriteLine("Awesome");
        }
        public static void writeToTheScreen() {
            Console.WriteLine("This is so awesome");
        }
    }
}
