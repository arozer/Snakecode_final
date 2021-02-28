using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snakecode
{
    class FoodCreator
    {
        int mapWidht;
        int mapHeight;
        char sym;
        char spsSym;
        char badSym;

        Random random = new Random();

        public FoodCreator(int mapWidht, int mapHeight, char sym, char spsSym, char badSym)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.sym = sym;
            this.spsSym = spsSym;
            this.badSym = badSym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidht - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
        
    }
}