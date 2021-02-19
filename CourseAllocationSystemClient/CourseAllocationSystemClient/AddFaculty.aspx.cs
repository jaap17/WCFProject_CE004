using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseAllocationSystemClient
{
    public partial class AddFaculty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Session["Admin"].ToString();
            Label4.Text = "You are signed in as:" + name;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = Session["Admin"].ToString();
            Session["Admin"] = name;
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            ServiceReference1.Faculty faculty = new ServiceReference1.Faculty();
            faculty.firstname = TextBox1.Text;
            faculty.lastname = TextBox2.Text;
            faculty.Experience = int.Parse(TextBox3.Text);
            faculty.username = TextBox1.Text + "@gmail.com";
            faculty.password = TextBox1.Text + "@2000";
            client.addFaculty(faculty);
            Response.Redirect("AdminHomepage.aspx");
        }
    }
}