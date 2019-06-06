using System;

namespace _10ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Hemisphere h = new Hemisphere();

            h.Radius = 1;

            Console.WriteLine(h.TotalSurfaceArea);

            h.Radius = 5;

            Console.WriteLine(h.TotalSurfaceArea);

            Console.ReadKey(true);
        }
    }
}
