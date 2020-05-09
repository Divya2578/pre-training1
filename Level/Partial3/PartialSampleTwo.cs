using System;
using System.Collections.Generic;
using System.Text;

namespace Partial3
{
    public partial class SampleClass
    {
        // Partial method implemented
        partial void SampleMethod()
        {
            Console.WriteLine("Partial SampleMethod Invoked");
        }
    }
}
