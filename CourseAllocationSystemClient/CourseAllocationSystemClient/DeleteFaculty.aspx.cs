using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseAllocationSystemClient
{
    public partial class DeleteFaculty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Session["Admin"].ToString();
            Label1.Text = "You are Signed in as " + name;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = Session["Admin"].ToString();
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            int ret = client.deleteFaculty(TextBox1.Text);
            Response.Redirect("AdminHomepage.aspx");
        }
    }
}