using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseAllocationSystemClient
{
    public partial class EvenSubjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            ServiceReference1.Subject[] subjects = client.getEvenSubjects();
            GridView3.DataSource = subjects;
            GridView3.DataBind();
            ServiceReference1.Subject[] subjects1 = client.getEvenSubjectsFour();
            GridView4.DataSource = subjects1;
            GridView4.DataBind();
            ServiceReference1.Subject[] subjects2 = client.getEvenSubjectsSix();
            GridView5.DataSource = subjects2;
            GridView5.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteSubject.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddSubject.aspx");
        }
    }
}