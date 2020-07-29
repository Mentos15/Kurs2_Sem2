using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    interface IGoHunting
    {
        void Hunt();
    }
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
        public IGoHunting GoHunt{ private get; set; }
        public Tiger(IGoHunting hunt)
        {
            GoHunt = hunt;
        }
        public Tiger ()
        {

        }
        public void Hunt()
        {
            GoHunt.Hunt();
        }

        public string Atack()
        {
           
            return "Cat_zoo";
        }
        public string Eat()
        {
            
            return "Cat_zoo";
        }
    }
    class LitleTiger:IGoHunting
    {
    
        public void Hunt()
        {
            Console.WriteLine("Тигр слишком мал, он не может охотится");
        }
    }
    class OldTiger : IGoHunting
    {
        public void Hunt()
        {
            Console.WriteLine("Тигр ушел охотится");
        }
    }
}
