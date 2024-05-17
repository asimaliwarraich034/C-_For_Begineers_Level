using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PartialClassesConcept
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer C1 = new Customer();
            C1.FirstName = " Asim";
            C1.LastName = " Ali";
            string FullName1 = C1.GetFullName();
            Response.Write("Full Name = " + FullName1 + "<br/>");

            PartialCustomer C2 = new PartialCustomer();
            C2.FirstName = ".Net ";
            C2.LastName = "Developer ";
            string FullName2 = C2.GetFullName();
            Response.Write("Full Name = " + FullName2 + "<br/>");


        }
    }
}