using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp5
{
    interface Shape
    {

        void Draw();

    }

    class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Draw circle");
        }
    }

    class Lines : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Stright Line");
        }
    }


    class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }






    public class Program2
    {

        static void Main(string[] args)
        {

            Shape s1 = new Rectangle();
            Shape s2 = new Circle();

            s2.Draw();
            s1.Draw();
        }
    }
}
