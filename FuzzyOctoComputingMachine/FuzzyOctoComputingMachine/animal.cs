using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyOctoComputingMachine
{
    class animal : Entity
    {
        string name;
        int age;

        public animal(string name, int age, int x, int y, int id)
            : base(x, y, id)
        {
            this.name = name;
            this.age = age;
        }

        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        public void ChangeAge(int a)
        {
            age = a;
        }
    }
}
