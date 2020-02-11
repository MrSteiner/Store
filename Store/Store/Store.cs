using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Store
    {
        public Showcase showCase;

        public Store()
        {
            showCase = new Showcase(5);
            Game g1 = new Game("Raid Shadow Legends", "Best game ever", 10);
            Game g2 = new Game("Fallout 76", "Sucks", 60);
            Game g3 = new Game("Fortnite", "Child Casino", 1);
            //Need to add games to showcase
            showCase.addGame(g1);
            showCase.addGame(g2);
            showCase.addGame(g3);
            DLC d1 = new DLC("Engineers", 10, "New gear");
            g2.dlcs.Add(d1);
            
        }

        //buying
        //navigation/seeing what's for sale
    }
}
