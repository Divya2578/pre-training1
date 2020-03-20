using System;
namespace AccessSpecifiers
{
    class InternalTest
    {
        protected internal string name = "Mahesh Tadooruu";
        protected internal void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            InternalTest internalTest = new InternalTest();
            // Accessing protected internal variable  
            Console.WriteLine("Hello " + internalTest.name);
            // Accessing protected internal function  
            internalTest.Msg("Lalita Tadooru");
        }
    }
}