using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseAllocationSystemClient
{
    public partial class DeleteSubject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            string del = client.deleteSubject(TextBox1.Text);
            
            Label2.Text = del;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("EvenSubjects.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("OddSubjects.aspx");
        }
    }
}