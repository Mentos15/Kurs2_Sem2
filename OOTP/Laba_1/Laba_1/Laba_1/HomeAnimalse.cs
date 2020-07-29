using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{

    interface IHomeAnimals
    {
        void Sleep();
        void SaveHouse();
    }

    class Cat : IHomeAnimals
    {
        public void Sleep()
        {
            Console.WriteLine("Кот уснул!");
        }

        public void SaveHouse()
        {
            Console.WriteLine("Кот охраняет дом!");
        }


    }
    class Dog : IHomeAnimals
    {
        public void Sleep()
        {
            Console.WriteLine("Собака уснула!");
        }

        public void SaveHouse()
        {
            Console.WriteLine("Собака охраняет дом!");
        }
    }
}
