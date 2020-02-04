using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Store
    {
        Showcase showCase;

        public Store()
        {
            showCase = new Showcase(5);
            Game g1 = new Game("Raid SL", "Just, Whatever", 10);
            //Need to add games to showcase
        }

        //buying
        //navigation/seeing what's for sale
    }
}
