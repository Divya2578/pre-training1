using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Partial2
{
    public partial class PartialCustomerOne
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }
}