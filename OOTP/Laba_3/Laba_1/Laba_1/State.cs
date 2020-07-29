using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    class StayState : ICatState
    {
        public void Down(Cat cat)
        {
            Console.WriteLine("Кот лег!");
            cat.State = new StayState();

        }

        public void Jump(Cat cat)
        {
            Console.WriteLine("Кот прыгнул!");
            cat.State = new StayState();
        }

        public void Stay(Cat cat)
        {
            Console.WriteLine("Кот и так стоит");
        }
    }
    class DownState : ICatState
    {
        public void Down(Cat cat)
        {
            Console.WriteLine("Кот лежит, он  не может снова лечь");
        }

        public void Jump(Cat cat)
        {
            Console.WriteLine("Кот лежит, он не может прыгнуть!");
        }

        public void Stay(Cat cat)
        {
            Console.WriteLine("Кот встал!");
            cat.State = new StayState();
        }
    }
    class JumpState : ICatState
    {
        public void Down(Cat cat)
        {
            Console.WriteLine("Кот в состоянии прыжка, он не модет сразу лечь");
        }

        public void Jump(Cat cat)
        {
            Console.WriteLine("Кот в состоянии прыжка, он не может снова прыгнуть!");
        }

        public void Stay(Cat cat)
        {
            Console.WriteLine("Кот встал!");
            cat.State = new StayState();
        }
    }
}
