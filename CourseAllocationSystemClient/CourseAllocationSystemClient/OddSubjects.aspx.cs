using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseAllocationSystemClient
{
    public partial class OddSubjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            GridView3.DataSource = client.getOddSubjectsThree();
            GridView3.DataBind();
            GridView4.DataSource = client.getOddSubjectsFive();
            GridView4.DataBind();
            GridView5.DataSource = client.getOddSubjects();
            GridView5.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddSubject.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteSubject");
        }
    }
}