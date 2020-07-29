using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    interface IWildAnimals
    {
        void Atack();
        void Eat();
    }
    class Ealiphant : IWildAnimals
    {
        public void Atack()
        {
            Console.WriteLine("Слон атаковал!");
        }
        public void Eat()
        {
            Console.WriteLine("Слон съел жертву");
        }
    }
    class Tiger : IWildAnimals
    {
        public void Atack()
        {
            Console.WriteLine("Тигр атаковал!");
        }
        public void Eat()
        {
            Console.WriteLine("Тигр съел жертву");
        }
    }
}
