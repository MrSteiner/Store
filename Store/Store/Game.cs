using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Game
    {
        String[] genres;
        float price;
        List<DLC> dlcs;
        string name;
        string description;
        string systemReqirements;
        int metacriticScore;

        public Game(string name, string description, float price)
        {
            this.name = name;
            this.description = description;
            this.price = price;

        }
    }
}
