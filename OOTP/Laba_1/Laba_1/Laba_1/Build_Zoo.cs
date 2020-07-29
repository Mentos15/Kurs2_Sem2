using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    public interface IBuild_Zoo
    {
        void BuildRoad();
        void BuildTrees();
        void BuildCage();
        void BuildWC();
        Build_Zoo GetResult();
    }
    public class Build_Zoo : IBuild_Zoo
    {
        public int percent {get; private set;} = 0;
       
        public void BuildCage()
        {
            Console.WriteLine("Клетка построена");
            percent += 25;
        }

        public void BuildRoad()
        {
            Console.WriteLine("Дорога построена");
            percent += 25;
        }

        public void BuildTrees()
        {
            Console.WriteLine("Деревья построены");
            percent += 25;

        }

        public void BuildWC()
        {
            Console.WriteLine("WC построен");
            percent += 25;
        }

        public Build_Zoo GetResult()
        {
            Console.WriteLine("парк построен на ");
            return this;
        }
    }
}
