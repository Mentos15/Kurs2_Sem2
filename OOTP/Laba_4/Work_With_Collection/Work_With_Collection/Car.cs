using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_With_Collection
{
    class Car:IComparable<Car>
    {
        public int speed { get; set; }
        
        public Car (int speed)
        {
            this.speed = speed;
        }
        public int CompareTo(Car car)
        {
            // A null value means that this object is greater.
            if (car == null)
                return 1;

            else
                return this.speed.CompareTo(car.speed);
        }
    }
}
