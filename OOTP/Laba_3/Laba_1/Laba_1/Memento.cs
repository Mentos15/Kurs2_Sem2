using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    class Memento
    {
        public int Sound{get;set;}

        public Memento(int sound)
        {
            this.Sound = sound;
        }
    }
    class SoundHistory
    {
        public Stack<Memento> History { get; private set; }
        public SoundHistory()
        {
            History = new Stack<Memento>();
        }
    }

}
