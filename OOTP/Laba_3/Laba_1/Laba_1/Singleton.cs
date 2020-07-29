using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    class Owner
    {
        public int amount_zoo { get; set; } = 2;

        public void Sell_Zoo()
        {
            Console.WriteLine("Зоопарк продан!");
        }
        public void By_Zoo()
        {
            Console.WriteLine("Зоопарк куплен!");
        }

        private Owner() { }
        private static Owner owner;
        private static object locker = new object();
        public static Owner GetInstance()
        {
                lock (locker)
                {
                    if (owner == null)
                    {
                        owner = new Owner();
                        Console.WriteLine("Объект сингтон создан");
                    }
                    
                   
                }
        
            return owner;
        }
    }
}
