using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Game
    {
        public String[] genres;
        public float price;
        public List<DLC> dlcs;
        public string name;
        public string description;
        public string systemReqirements;
        public int metacriticScore;

        public Game(string name, string description, float price)
        {
            this.name = name;
            this.description = description;
            this.price = price;

        }
    }
}
