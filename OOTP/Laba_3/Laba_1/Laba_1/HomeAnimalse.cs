using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{

    public interface IHomeAnimals
    {
        string Sleep();
        string SaveHouse();
    }
    interface ICatState
    {

        void Jump(Cat cat);
        void Down(Cat cat);
        void Stay(Cat cat);

    }


    class Cat: IHomeAnimals
    {

        public ICatState State { get; set; }
        public Cat(ICatState state)
        {
            State = state;
        }
        public Cat()
        {

        }
        public void Jump()
        {
            State.Jump(this);
        }
        public void Down()
        {
            State.Down(this);
        }
        public void Stay()
        {
            State.Stay(this);
        }

        public string Sleep()
        {

            return "Cat_zoo";

        }

        public string SaveHouse()
        {

            return "Cat_zoo";
        }
    }
   

    class Dog:IHomeAnimals
    {
        private int sound = 0;

        public void Sound()
        {
            Console.WriteLine("Собака гавкнула!");
            sound += 1;
        }
        public Memento SaveState()
        {
            Console.WriteLine("Сохранение состояния. Количество 'ГАВ' = {0} ",sound);
            return new Memento(sound);
        }
        public void RestorerState(Memento memento)
        {
            this.sound = memento.Sound;
            Console.WriteLine("Возобновление  состояния.Количество 'ГАВ ' = {0}", sound);

            
        }


        public void Jump()
        {
            Console.WriteLine("Собака прыгает!");
        }
        public void Down()
        {
            Console.WriteLine("Собака легла!");
        }
        public void Run()
        {
            Console.WriteLine("Собака побежала!");
        }
        public string Sleep()
        {

            return "Ather_zoo";
        }

        public string SaveHouse()
        {

            return "Ather_zoo";
        }

    }
}
