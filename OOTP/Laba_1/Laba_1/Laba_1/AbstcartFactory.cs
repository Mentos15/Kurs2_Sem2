using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    interface IAbstactFactory
    {
        IWildAnimals GetWildAnimals();
        IHomeAnimals GetHomeAnimals();

    }

    class Cat_Zoo : IAbstactFactory
    {
        public IWildAnimals GetWildAnimals()
        {
            return new Tiger();
        }
        public IHomeAnimals GetHomeAnimals()
        {
            return new Cat();
        }
    }
    class Other_Zoo : IAbstactFactory
    {
        public IWildAnimals GetWildAnimals()
        {
            return new Ealiphant();
        }
        public IHomeAnimals GetHomeAnimals()
        {
            return new Dog();
        }
    }
}
