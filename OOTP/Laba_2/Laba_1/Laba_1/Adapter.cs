using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    interface Iadapt
    {
        void giveX(int x);
        void giveY(int y);
        void giveZ(int z);
    }
    class Adapter : Iadapt
    {
        private readonly Animals _animals;
        public Adapter(Animals animals)
        {          
            _animals = animals;
        }

        public void giveX(int x)
        {
         
            if(_animals.Atack() == "Cat_zoo" || _animals.Eat()=="Cat_zoo" || _animals.SaveHouse() == "Cat_zoo" || _animals.Sleep() == "Cat_zoo")
            {
                Console.WriteLine($"Cat_zoo сдвинут по X на {x}");
            }
            else if(_animals.Atack() == "Ather_zoo" || _animals.Eat() == "Ather_zoo" || _animals.SaveHouse() == "Ather_zoo" || _animals.Sleep() == "Ather_zoo")
            {
                Console.WriteLine($"Ather_zoo сдвинут по X на {x}");
            }
           


        }

        public void giveY(int y)
        {
            if (_animals.Atack() == "Cat_zoo" || _animals.Eat() == "Cat_zoo" || _animals.SaveHouse() == "Cat_zoo" || _animals.Sleep() == "Cat_zoo")
            {
                Console.WriteLine($"Cat_zoo сдвинут по Y на {y}");
            }
            else if (_animals.Atack() == "Ather_zoo" || _animals.Eat() == "Ather_zoo" || _animals.SaveHouse() == "Ather_zoo" || _animals.Sleep() == "Ather_zoo")
            {
                Console.WriteLine($"Ather_zoo сдвинут по Y на {y}");
            }

        }

        public void giveZ(int z)
        {
            if (_animals.Atack() == "Cat_zoo" || _animals.Eat() == "Cat_zoo" || _animals.SaveHouse() == "Cat_zoo" || _animals.Sleep() == "Cat_zoo")
            {
                Console.WriteLine($"Cat_zoo сдвинут по Z на {z}");
            }
            else if (_animals.Atack() == "Ather_zoo" || _animals.Eat() == "Ather_zoo" || _animals.SaveHouse() == "Ather_zoo" || _animals.Sleep() == "Ather_zoo")
            {
                Console.WriteLine($"Ather_zoo сдвинут по Z на {z}");
            }

        }
    }
}
