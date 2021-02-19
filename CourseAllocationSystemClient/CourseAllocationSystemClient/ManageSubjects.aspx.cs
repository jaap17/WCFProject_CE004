using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseAllocationSystemClient
{
    public partial class ManageSubjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Admin"] != null)
            {
                string name = Session["Admin"].ToString();
                Label1.Text = "Welcome:" +name+ "  to Manage Faculties page";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string name = Session["Admin"].ToString();
            Session["Admin"] = name;
            Response.Redirect("DeleteFaculty.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = Session["Admin"].ToString();
            Session["Admin"] = name;
            Response.Redirect("AddFaculty.aspx");
        }
    }
}