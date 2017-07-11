using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab13_Inheritance
{
    public class Garage
    {
        public int levels;
        protected int rows;
        protected int spots;
        public Garage (int levels, int rows, int spots)
        {
            this.levels = levels;
            this.rows = rows;
            this.spots = spots;
        }
        public int [,,] MakeSpots()
        {
            int[,,] garageX = new int[levels, rows, spots];
            for (int i = 0; i < levels; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < spots; k++)
                    {
                        garageX[i, j, k] = 0;
                    }
                }
            }
            return garageX;
        }
        public int [,,] ParkIt(int[,,] parkedIn, int levels, int rows, int spots, int size)
        {
            for (int i = 0; i < levels; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < spots; k++)
                    {
                        if (parkedIn[i, j, k] == 0)
                        {
                            int spotsLeft = (spots - (k - 1));
                            if (spotsLeft > size)
                            {
                                for (int l = 0; l < size; l++)
                                {
                                    parkedIn[i, j, (k + l)] = 1;
                                }
                                Console.WriteLine("The vehicle is parked on level {0}, in row {1}, in space {2}", (i + 1), (j + 1), (k + 1));
                                return parkedIn;
                            }

                        }
                    }
                }
            }
            Console.WriteLine("No more vehicles of that type can be parked here.");
            return parkedIn;
        }
    }
  
}
