using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{

    public interface IHomeAnimals
    {
        string Sleep();
        string SaveHouse();
    }

    class Cat : IHomeAnimals
    {

        
        public string Sleep()
        {
            
            return "Cat_zoo";

        }

        public string SaveHouse()
        {
            
            return "Cat_zoo";
        }


    }
    class Dog : IHomeAnimals
    {
        public string Sleep()
        {
           
            return "Ather_zoo";
        }

        public string SaveHouse()
        {
            
            return "Ather_zoo";
        }
    }
}
