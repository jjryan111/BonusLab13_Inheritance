using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab13_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Input n = new Input();
            int inputL = n.GetInput("How many levels? ", "Invalid input", 0, int.MaxValue);
            int inputR = n.GetInput("How many rows per level? ", "Invalid input", 0, int.MaxValue);
            int inputS = n.GetInput("How many spots per row? ", "Invalid input", 0, int.MaxValue);

            Garage MyGarage = new Garage(inputL, inputR, inputS);
            int[,,] myGarageSpots = MyGarage.MakeSpots();
            Vehicle inputCar = new Vehicle();
            int type = 0;
            int size = 0;
            string yesNo = "y";
            while (yesNo == "y")
            {
                type = n.GetInput("Enter 1 for motorcycle, 2 for car and 3 for bus: ", "Please enter 1, 2, or3.", 0, 3);
                if (type == 2)
                {

                    inputCar = new Car();
                    size = inputCar.GetSize();
                    myGarageSpots = MyGarage.ParkIt(myGarageSpots, inputL, inputR, inputS, size);
                }
                else if (type == 3)
                {
                    inputCar = new Bus();
                    size = inputCar.GetSize();
                    myGarageSpots = MyGarage.ParkIt(myGarageSpots, inputL, inputR, inputS, size);

                }
                else
                {
                    inputCar = new Vehicle();
                    size = inputCar.GetSize();
                    myGarageSpots = MyGarage.ParkIt(myGarageSpots, inputL, inputR, inputS, size);

                }
                yesNo = n.ynInput();
            }
        }
    }
}
