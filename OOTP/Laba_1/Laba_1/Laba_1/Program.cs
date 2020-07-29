using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Laba_1
{

    class Program
    {
        static void Main(string[] args)
        {
            Animals zoo1 = new Animals(new Cat_Zoo());
            zoo1.Atack();
            zoo1.Eat();
            zoo1.SaveHouse();
            zoo1.Sleep();
            Animals zoo3 = new Animals(new Other_Zoo());
            zoo3.Atack();
            zoo3.Eat();
            zoo3.SaveHouse();
            zoo3.Sleep();

            WriteLine();
            // Task 2
            Owner s1 = Owner.GetInstance();
            Owner s2 = Owner.GetInstance();

            Parallel.Invoke(() => Owner.GetInstance(), () => Owner.GetInstance(), () => Owner.GetInstance());
            if (s1 == s2)
            {
                WriteLine("Синглтон работает, обе переменные содержат один и тот же экземпляр.");
            }
            else
            {
                WriteLine("Ошибка Синглтон, переменные содержат разные экземпляры");
            }

            WriteLine();

            // Task 3

            Build_Zoo zoo2 = new Build_Zoo();
            Director dir1 = new Director(zoo2);

            dir1.BUILD();
            WriteLine(zoo2.percent);

            // Task 4 

            Man man1 = new Man(13,"Artem",180,1);
            Man man2 = man1.Copy();

            if(man1.id == man2.id)
            {
                Console.WriteLine("неглубоко");
            }
            else
            {
                Console.WriteLine("глубоко");
            }

            

        }
    }
}
