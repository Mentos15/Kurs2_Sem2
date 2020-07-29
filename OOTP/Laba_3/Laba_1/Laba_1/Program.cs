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
            Pet_Owner owner = new Pet_Owner();
            Dog dog = new Dog();

            owner.SetCommand(new RunCommand(dog));
            owner.Run();
            owner.Jump();
            owner.SetCommand(new JumpCommand(dog));
            owner.Jump();


            //Task 2

            Cat cat1 = new Cat(new DownState());
            cat1.Down();
            cat1.Jump();
            cat1.Stay();
            cat1.Jump();

            // Task 3

            Dog dog1 = new Dog();


            dog1.Sound();
            SoundHistory hist = new SoundHistory();
            hist.History.Push(dog1.SaveState());
            dog1.Sound();

            dog1.RestorerState(hist.History.Pop());
            dog1.Sound();
            
            // Task 4
            Tiger tiger1 = new Tiger(new LitleTiger());
            tiger1.Hunt();

            tiger1.GoHunt = new OldTiger();
            tiger1.Hunt();
        }
    }
}
