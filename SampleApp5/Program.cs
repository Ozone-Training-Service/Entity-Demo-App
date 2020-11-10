using System;

namespace SampleApp5
{
    interface ISample
    {

        void Hello();
        void Hai();
    }

    class Test : ISample
    {
        public void Hai()
        {
            Console.WriteLine("Hai");
        }

        public void Hello()
        {
            Console.WriteLine("Hello");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            ISample o = new Test();
            o.Hello();
            Console.WriteLine("Hello World!");
        }
    }
}
