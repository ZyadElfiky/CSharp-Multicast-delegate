using System;

namespace Multicast_delegate
{
    public delegate void multicastDelegate(double width, double hight);
    class Program
    {
        static void Main(string[] args)
        {

            var helper = new RectangleHelper();
            multicastDelegate rect;
            
            // subscribing
            rect= helper.calcArea;
            rect += helper.calcPerimeter;

            rect(5, 5);


            Console.WriteLine("After unsubscribing rect.calcArea : \n");
            rect -= helper.calcArea;
            
            rect(5, 5);


        }
    }
    public class RectangleHelper
    {
        public void calcArea(double width,double hight)
        {
            Console.WriteLine($"Area = {width * hight} \n" );
        }
        public void calcPerimeter(double width,double hight)
        {
            Console.WriteLine($"Perimeter = {width * hight} \n" );
        }

    }
}
