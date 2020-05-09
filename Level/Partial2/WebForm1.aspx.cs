using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Partial2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer c1 = new Customer();
            c1.FirstName = "Divya";
            c1.LastName = "Tadooru";

            string FullName1 = c1.GetFullName();
            Response.Write("Full Name = " + FullName1 + "<br/>");

            PartialCustomerOne c2 = new PartialCustomerOne();
            c2.FirstName = "Divya";
            c2.LastName = "T";

            string FullName2 = c2.GetFullName();
            Response.Write("Full Name = " + FullName2 + "<br/>");

        }
    }
}