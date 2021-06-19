using System;

namespace CA2
{
    
    class Program
    {

        

        static void Main(string[] args)
        {
            Console.Write("enter a name: ");
            string name = Console.ReadLine();
            Console.WriteLine("you matched with Bob, Be nice and only talk in english");
            Console.WriteLine("hi " + name);
            string input = Console.ReadLine();
            if (input == "hi")
            {
                Console.WriteLine("die");
            } else
            {
                Console.WriteLine("your dead to me");
            }

        }
    }
}
