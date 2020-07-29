using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
   class Man
    {
        public int Age;
        public string Name;
        public int Height;
        public Id id;

        public Man Copy()
        {
            Man copy = (Man)this.MemberwiseClone();
            copy.id = new Id(id.Id_Num) /*id*/;
            copy.Name = string.Copy(Name);
            return copy;
        }
        public Man(int age, string name, int height, int counter)
        {
            Age = age;
            Name = name;
            Height = height;
            id = new Id(counter);
        }
    }

    public class Id
    {
        public int Id_Num;

        public Id(int idNumber)
        {
            this.Id_Num = idNumber;
        }
    }
}
