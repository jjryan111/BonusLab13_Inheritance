using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab13_Inheritance
{
    public class Vehicle
    {
        protected int size;
        public Vehicle()
        {
            this.size = 1;
        }
        public int GetSize()
        {
            return size;
        }

    }
    public class Car : Vehicle
    {
        public Car()
        {
            this.size = 2;
        }
    }
    public class Bus : Vehicle
    {
        public Bus ()
        {
            this.size = 10;
        }
    }
}
