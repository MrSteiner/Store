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

            Console.WriteLine("Welcome to SteinerStore");
            Console.WriteLine("Best game store in EU");

            while (true)
            {
                //Buy game, see what games are there, quit store, print game description
                Console.WriteLine("These are the available commands: Show, buy & quit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "quit":
                        Environment.Exit(0);
                        break;

                    case "show":
                        Console.WriteLine("*Yells in Lil Jon* OK!!");
                        st.showCase.Show();
                        break;

                    case "buy":
                        // ask user what game
                        // remove game from showcase
                        // or tell user the game is not valid

                        Console.WriteLine("*Yells in Lil Jon* WHAT GAME YOU WANT!?");

                        string selectedGame = Console.ReadLine();
                        int gameIndex = Convert.ToInt32(selectedGame);
                        string gameName = null;

                        if(gameIndex < st.showCase.games.Count)
                            gameName = st.showCase.games[gameIndex].name;

                        if (st.showCase.removeGame(gameIndex))
                        {
                            Console.WriteLine(gameName + " bought successfully");
                        }
                        else
                            Console.WriteLine("*Yells in Lil Jon* Error");

                        break;

                    default:
                        Console.WriteLine("*yells in Lil Jon* WHAT?!");
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
