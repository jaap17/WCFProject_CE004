using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseAllocationSystemClient
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Name"] != null)
            {
                Label1.Text = Session["Name"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sem = "Semester Type:",sem1= "",name="";
            if(Session["FormSemester"] != null)
            {
                sem1 = Session["FormSemester"].ToString();
            }
            if (Session["Name"] != null)
            {
                name = Session["Name"].ToString();
            }
            Session["Name"] = name;
            Label2.Text = sem+sem1;
            Response.Redirect(sem1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string name = Session["Name"].ToString();
            Session["Name"] = name;
            Response.Redirect("ViewAllocation.aspx");
        }
    }
}