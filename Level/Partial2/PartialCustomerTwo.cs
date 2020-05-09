using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Partial2
{
  
        public partial class PartialCustomerOne
        {
            public string GetFullName()
            {
                return _firstName + ", " + _lastName;
            }
        }

    
}