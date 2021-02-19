using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseAllocationSystemClient
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Textbox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = Textbox1.Text;
            string password = Textbox2.Text;
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            int ans = client.Login(username, password);
            if(ans == 1)
            {
                string name = client.getNameOnUsername(username);
                Session["Name"] = name;
                Response.Redirect("Homepage.aspx");
            }
            else
            {
                
                Response.Redirect("Login.aspx");
            }
            
            //Label4.Text = name;
            

        }
    }
}