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
            /*
            //ask a question
            Console.WriteLine("What is your name?");

            //read answer
            string input = Console.ReadLine();

            //Repeat answer
            Console.WriteLine(input + ", really?");
            //Alternativ: Console.WriteLine("{0}, really?", input);

            //wait for confirmation
            Console.WriteLine("Press enter to accept");
            Console.ReadLine();
            */

            Store st = new Store();
            

            while (true)
            {
                //Buy game, see what games are there, quit store, print game description
                string input = Console.ReadLine();
                switch (input)
                {
                    case "quit":
                        Environment.Exit(0);
                        break;

                    case "show":
                        st.showCase.Show();
                        break;

                    default:
                        Console.WriteLine("I do not understand...");
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
