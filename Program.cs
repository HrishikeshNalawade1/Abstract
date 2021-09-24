using System;

namespace abstracttt
{
   abstract class fig
    {
        public double height,width,radius;
        public const float pi = 3.14f;
        public abstract double area();

    }
    class rectangle:fig
    {
        public rectangle(double height,double width)
        {
            this.height = height;
            this.width =width;

        }
        public  override double area()
        {

            return width*height;
        }


    }
    class circle:fig
    {
        public circle(double radius)
        {
            this.radius = radius;
           
        }
        public override double area()
        {

            return pi*radius*radius;
        }
    }
    class cone : fig
    {
        public cone(double height,double radius)
        {
            this.radius = radius;
            this.height = height;
        }
        public   override double area()
        {

            return pi*radius*(radius+Math.Sqrt(height*height*radius*radius));
        }
    }
    class Program
{
    static void Main(string[] args)
    {
            rectangle R = new rectangle(10, 12);
            Console.WriteLine("area of Rectangle is :"+R.area());
            cone c = new cone(4, 3.2);
            Console.WriteLine("area of conee is:"+c.area());
            circle cc = new circle(2.5);
            Console.WriteLine("Area of circle is:"+cc.area());
     }
}
}
