using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    [Serializable]
    public class CrewMember
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Function { get; set; }
        public int Experience { get; set; }

        public CrewMember(string name, string surname, int age, string function, int experience)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Function = function;
            Experience = experience;
        }

        public string CrewInfo()
        {
            return $"Имя: {Name}\nФамилия: {Surname}\nВозраст: {Age}\nДолжность: {Function}\nСтаж: {Experience}\n\n";
        }
    }
}
