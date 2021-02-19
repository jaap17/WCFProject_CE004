using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseAllocationSystemClient
{
    public partial class ViewAllocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            ServiceReference1.CourseAllocation[] courseAllocations = client.courseAllocations();
            if(Session["Admin"] != null)
            {
                Label1.Text = "You are signed in as: "+ Session["Admin"].ToString();
            }
            if(Session["Name"] != null)
            {
                Label1.Text = "You are signed in as: " +Session["Name"].ToString();
            }
            GridView1.DataSource = courseAllocations;
            GridView1.DataBind();
        }
    }
}