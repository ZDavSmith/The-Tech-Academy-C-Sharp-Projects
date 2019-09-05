using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)//Object is a generic type that covers almost anything, EventArgs, special data type object
        {
            Label1.Text = TextBox1.Text; //Tkaes whatever is in the input and assigns it to the tool dragged in, which was label
        }
    }
}