using System;
using System.Collections.Generic;
using System.Text;

namespace _10ex
{
    class Hemisphere
    {
        private double radius = 1;
        
        
        private double volume;
        private double curvedSurfaceArea;
        private double totalSurfaceArea;

        public double TotalSurfaceArea
        {
            get { return totalSurfaceArea; }
            set { totalSurfaceArea = 3 * Math.PI * Math.Pow(radius, 2); }
        }

        public double CurvedSurfaceArea
        {
            get { return curvedSurfaceArea; }
            set { curvedSurfaceArea = 2 * Math.PI * Math.Pow(radius, 2); }
        }

        public double Volume
        {
            get { return volume; }
            set { volume = 2.0 / 3.0 * Math.PI * Math.Pow(radius, 2); }
        }


        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
                }
        }

    }
}
