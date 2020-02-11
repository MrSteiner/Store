using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Showcase
    {
        public List<Game> games;
        int maxGames;

        public Showcase(int size)
        {
            games = new List<Game>();
            maxGames = size;
        }

        public void addGame(Game game)
        {
            if(games.Count < maxGames)
                games.Add(game);
        }
        public void removeGame(Game game)
        {
            games.Remove(game);
        }
        public bool removeGame(int index)
        {
            if(index < games.Count)
                games.RemoveAt(index);
            return true;
        }

        public void Show()
        {
            for(int i=0; i<games.Count; i++)
            {
                Console.WriteLine("[{0}] {1}", i, games[i].name);
                //Console.WriteLine("["+ i +"]", games[i].name);
            }
        }

    }
}
