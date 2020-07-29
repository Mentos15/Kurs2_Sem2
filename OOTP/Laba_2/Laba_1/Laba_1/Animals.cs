using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    class Animals: IComponent
    {
        private IWildAnimals wild;
        private IHomeAnimals home;


        public string Title { get; set; }
        public void Draw()
        {
            Console.WriteLine(Title);
        }
        public IComponent Find(string title)
        {
            return Title == title ? this : null;
        }
        
        public Animals(IAbstactFactory factory)
        {
            wild = factory.GetWildAnimals();
            home = factory.GetHomeAnimals();
        }

        public string Sleep()
        {
            return home.Sleep();
        }
        public string SaveHouse()
        {
            return home.SaveHouse();
        }
        public string Atack()
        {
            return wild.Atack();
            
        }
        public string Eat()
        {
           return  wild.Eat();
        }
    }
}
