using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseAllocationSystemClient
{
    public partial class AdminHomepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Admin"] = "Dr Pankaj Jalote";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string admin = Session["Admin"].ToString();
            Session["Admin"] = admin;
            Response.Redirect("SelectSemester.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string admin = Session["Admin"].ToString();
            Session["Admin"] = admin;
            Response.Redirect("AdminFormSelection.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string admin = Session["Admin"].ToString();
            Session["Admin"] = admin;
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            int facultychoicecount = client.choiceCount();
            int faculties = client.facultyCount();
            if(facultychoicecount != faculties)
            {
                Response.Redirect("InsufficientChoices.aspx");
            }
            else
            {
                Response.Redirect("Allocation.aspx");
            }
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAllocation.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string admin = Session["Admin"].ToString();
            Session["Admin"] = admin;
            Response.Redirect("ManageSubjects.aspx");
        }
    }
}