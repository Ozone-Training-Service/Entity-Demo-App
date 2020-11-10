using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp
{
    interface Shapes
    {

        void Draw();
    }


    class A : Shapes
    {
        public void Draw()
        {
            Console.WriteLine("Draw Triangle");
        }
    }

    class B : Shapes
    {
        public void Draw()
        {
            Console.WriteLine("Draw a line");
        }

       
    }




    public class program2
    {
        static void Main(string[] args)
        {

            Shapes s1 = new A();

            Shapes s2 = new B();

            s1.Draw();
            s2.Draw();


        }
    }
}
