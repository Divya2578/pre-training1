using System;


    class PublicAccess
    {
        public string name = "Mahesh Tadooru";
        public void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PublicAccess publicTest = new PublicAccess();
            // Accessing public variable  
            Console.WriteLine("Hello " + publicTest.name);
            // Accessing public function  
            publicTest.Msg("Divya Tadooru");
        }
    }

