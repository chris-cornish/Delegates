using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate void SayGreeting(string name);

        public static void SayHello(string name)
        {
            Console.WriteLine(string.Format("Hello, {0}", name));
        }

        public static void SayGoodbye(string name)
        {
            Console.WriteLine(string.Format("Goodbye, {0}", name));
        }
        static void Main(string[] args)
        {
            SayGreeting sayGreeting = new SayGreeting(SayHello);
            Console.WriteLine("What's your name?");
            string input = Console.ReadLine();
            sayGreeting(input);
            sayGreeting = new SayGreeting(SayGoodbye);
            sayGreeting(input);
        }
    }
}
