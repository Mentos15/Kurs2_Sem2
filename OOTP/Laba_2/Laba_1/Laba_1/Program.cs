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
            Animals zoo2 = new Animals(new Other_Zoo());

            Adapter adap1 = new Adapter(zoo1);
            Adapter adap2 = new Adapter(zoo2);

            adap1.giveX(30);
            adap2.giveY(8);


            Build_Zoo zoo5 = new Build_Zoo();
            zoo5.Title = "zoo5";


            Build_Zoo zoo6 = new Build_Zoo();
            zoo6.Title = "zoo6";

            
    
            IHomeAnimals cat = new Cat();
            cat.SaveHouse();

            IHomeAnimals cat2 = new ElementDecarator(cat);
            cat2.SaveHouse();

            var district = new Map { Title = "City" };
            district.AddComponent(zoo5);
            district.AddComponent(zoo6);
            var city = new Map { Title = "Earth" };
            city.AddComponent(district);
            WriteLine("Все что содержиться на нашей планете");
            city.Draw();
            WriteLine("Ищем объект ");
            var house = city.Find("zoo5");
            house.Draw();
            
        }
    }
}
