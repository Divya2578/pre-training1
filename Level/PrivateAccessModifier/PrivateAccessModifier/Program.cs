using System;
namespace AccessSpecifiers
{
    class PrivateAccess
    {
        private string name = "Mahesh Tadooru";
        private void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    
   
        static void Main(string[] args)
        {
            PrivateAccess privateTest = new PrivateAccess();
            // Accessing private variable  
            Console.WriteLine("Hello " + privateTest.name);
            // Accessing private function  
            privateTest.Msg("Divya Tadooru");
        }
    }
}
