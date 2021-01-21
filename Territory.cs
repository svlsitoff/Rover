using System;
using System.Collections.Generic;
using System.Text;

namespace RoversApp
{
   public class Territory
    {
        public int[,] CoordSpec = new int[20,29];
        
        public Territory()
        {
            Random random = new Random();
            for(int i = 0; i < CoordSpec.GetLength(0); i++)
            {
                for(int j = 0; j < CoordSpec.GetLength(1); j++)
                {
                    CoordSpec[i, j] = random.Next(10,13);
                }
            }
        }
    }
}
