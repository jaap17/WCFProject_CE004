using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseAllocationSystemClient
{
    public partial class SelectSemester : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Admin"] != null)
            {
                Label1.Text = Session["Admin"].ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string admin = Session["Admin"].ToString();
            Session["Admin"] = admin;
            Response.Redirect("EvenSubjects.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string admin = Session["Admin"].ToString();
            Session["Admin"] = admin;
            Response.Redirect("OddSubjects.aspx");
        }
    }
}