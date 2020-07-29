using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    interface IWildAnimals
    {
        string Atack();
        string Eat();
    }
    class Ealiphant : IWildAnimals
    {
        public string Atack()
        {
            
            return "Ather_zoo";
        }
        public string Eat()
        {
            
            return "Ather_zoo";
        }
    }
    class Tiger : IWildAnimals
    {
        public string Atack()
        {
           
            return "Cat_zoo";
        }
        public string Eat()
        {
            
            return "Cat_zoo";
        }
    }
}
