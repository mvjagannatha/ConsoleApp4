using System;
namespace constantapp
{
    class program
    {
        static void Main(string[] args)
        {
            const double pi = 3.141;

            double r;
            Console.WriteLine("enter radius:");
            r = Convert.ToDouble(Console.ReadLine());
            double areaofcircle = pi * r * r;
            Console.WriteLine("r={0}, area of the circle={1}", r, areaofcircle);
            Console.ReadLine();
        }
    }
}