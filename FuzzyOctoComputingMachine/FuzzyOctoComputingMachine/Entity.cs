using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyOctoComputingMachine
{
    class Entity
    {
        int y;
        int x;
        int id;

        public Entity(int x, int y, int id)
        {
            this.x = x;
            this.y = y;
            this.id = id;
        }
        public int Gety()
        {
            return y;
        }
        public int Getx()
        {
            return x;
        }
        public int GetID()
        {
            return id;
        }
    }
}
