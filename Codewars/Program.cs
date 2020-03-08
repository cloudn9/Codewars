using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<string, string, string> Greet = (string a, string b) => $"{a} {b} !";
            //Console.WriteLine(Greet("Ciao", "Tanya")); // Ciao Tanya !
            //var SameGreet = Greet.SwapArgs();
            //Console.WriteLine(SameGreet("Tanya", "Ciao")); // Ciao  Tanya!
            //Console.ReadKey();
            
            var p = Task.Run(() => Console.WriteLine("oooh a task"));
            Console.ReadKey();
        }

    }

    public static class CustomExtensions
    {
        public static Func<string, string, string> SwapArgs(this Func<string, string, string> greet)
        {
            return (a, b) => greet(b, a);
        }
    }
}

