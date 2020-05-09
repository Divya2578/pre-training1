Using System;
Using System.Collection.Generic;


Partial Public Class WebForm1 : System.Web.UI.Page
    Protected void page_load(Object sender,EventArgs e)

        Customer c1 = New Customer();
        c1.FirstName = "Divya";
        c1.LastName = "Tadooru";

        String FullName1 = c1.GetFullName();
        Response.Write("Full Name = " + FullName1 + "<br/>");

        PartialCustomer c2 = New PartialCustomer();
        c2.FirstName = "Divya";
        c2.LastName = "T";

        String FullName2 = c2.GetFullName();
        Response.Write("Full Name = " + FullName2 + "<br/>");
  
        
End Class
