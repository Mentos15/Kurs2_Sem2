using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    public class Decarator:IHomeAnimals
    {
        protected readonly IHomeAnimals Component;

        public Decarator (IHomeAnimals dec)
        {
            Component = dec;
        }
        public virtual string Sleep()
        {
            return Component.Sleep();
        }
        public virtual string SaveHouse()
        {
            return Component.SaveHouse();
        }

    }
    public class ElementDecarator: Decarator
    {
        public ElementDecarator(IHomeAnimals component): base(component)
        {

        }
        public override string SaveHouse()
        {
            Console.WriteLine("До охраны дома");
            Console.WriteLine(base.SaveHouse());
            Console.WriteLine("После  охраны дома");
            return "";
        }
    }
}
