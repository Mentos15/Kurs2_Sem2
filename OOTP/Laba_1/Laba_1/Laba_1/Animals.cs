using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    class Animals
    {
        private IWildAnimals wild;
        private IHomeAnimals home;

        public Animals(IAbstactFactory factory)
        {
            wild = factory.GetWildAnimals();
            home = factory.GetHomeAnimals();
        }

        public void Sleep()
        {
            home.Sleep();
        }
        public void SaveHouse()
        {
            home.SaveHouse();
        }
        public void Atack()
        {
            wild.Atack();
        }
        public void Eat()
        {
            wild.Eat();
        }
    }
}
