using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask a question
            Console.WriteLine("What is your name?");

            //read answer
            string input = Console.ReadLine();

            //Repeat answer
            Console.WriteLine(input + ", really?");
            Console.WriteLine("{0}, really?", input);

            //wait for confirmation
            Console.ReadLine();
        }
    }
}
