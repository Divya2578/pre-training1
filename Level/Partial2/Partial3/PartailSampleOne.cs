using System;
using System.Collections.Generic;
using System.Text;

namespace Partial3
{
    public partial class SampleClass
    {
        // Declaration of the partial method.
        partial void SampleMethod();

        // A public method calling the partial method
        public void PublicMethod()
        {
            Console.WriteLine("Public Method Invoked");
            SampleMethod();
        }
    }
}
