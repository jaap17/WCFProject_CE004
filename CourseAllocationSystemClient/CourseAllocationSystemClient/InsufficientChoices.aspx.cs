using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseAllocationSystemClient
{
    public partial class InsufficientChoices : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Session["Admin"].ToString();
            Label1.Text = "You are signed in as: "+name;
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            int facultychoicecount = client.choiceCount();
            int faculties = client.facultyCount();
            int difference = faculties - facultychoicecount;
            Label2.Text = "Allocation cannot be done as " + difference + " faculty/faculties has/have not yet given their choices";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = Session["Admin"].ToString();
            Session["Admin"] = name;
            Response.Redirect("AdminHomepage.aspx");
        }
    }
}