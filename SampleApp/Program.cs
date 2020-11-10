using System;

namespace SampleApp
{


    interface Shape
    {


     void DrawTriagle();

      void DrawCircle();
    }



    class test : Shape
    {
        public void DrawCircle()
        {
            Console.WriteLine("Draw Circle");
        }

        public void DrawTriagle()
        {
            Console.WriteLine("Draw Triangle");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            test ob = new test();
            ob.DrawCircle();

            ob.DrawTriagle();


            Shape s = new test();

         
           
        }
    }




}
