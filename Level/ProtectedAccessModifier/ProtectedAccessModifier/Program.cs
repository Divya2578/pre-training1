using System;
namespace AccessSpecifiers
{
    class ProtectedTest
    {
        protected string name = "Lalita";
        protected void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class Program : ProtectedTest 
    {
        static void Main(string[] args)
        {
            Program protectedTest = new Program ();
            // Accessing protected variable  
            Console.WriteLine("Hello " + protectedTest.name);
            // Accessing protected function  
            protectedTest.Msg("Divya Tadooru");
        }
    }
}
