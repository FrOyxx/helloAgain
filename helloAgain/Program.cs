using System;

namespace helloAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello what is your name?: ");
            string userName  = Console.ReadLine();
            Console.WriteLine("Hello {0}!", userName);
            
        }
    }
}
