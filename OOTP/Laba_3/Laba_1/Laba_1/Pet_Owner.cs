using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    class Pet_Owner
    {
        ICommand command;
        public Pet_Owner() { }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void Run()
        {
            command.Execute();
        }
        public void Jump()
        {
            command.Execute();
        }

    }
}
