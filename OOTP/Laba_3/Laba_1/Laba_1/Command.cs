using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    interface ICommand
    {
        void Execute();
    };

    class JumpCommand: ICommand
    {
        Dog dog;
        public JumpCommand(Dog DogJump)
        {
            dog = DogJump;
        }
        public void Execute()
        {
            dog.Jump();
        }
    }
    class RunCommand: ICommand
    {
        Dog dog;

        public RunCommand(Dog DogRun)
        {
            dog = DogRun;
        }
        public void Execute()
        {
            dog.Run();
        }
    }
    class DownCommand: ICommand
    {
        Dog dog;
        public DownCommand(Dog DogDown)
        {
            dog = DogDown;
        }
        public void Execute()
        {
            dog.Down();
        }
    }
}
