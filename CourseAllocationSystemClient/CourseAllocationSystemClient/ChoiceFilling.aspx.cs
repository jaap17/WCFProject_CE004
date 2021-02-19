using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseAllocationSystemClient
{
    public partial class ChoiceFilling : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Name"] != null)
            {
                Label6.Text = Session["Name"].ToString();
            }
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            string[] subjects = client.getAllSubjects();
            for(int i=0;i<subjects.Length;i++)
            {
                DropDownList1.Items.Add(subjects[i]);
                DropDownList2.Items.Add(subjects[i]);
                DropDownList3.Items.Add(subjects[i]);
                DropDownList4.Items.Add(subjects[i]);
                DropDownList5.Items.Add(subjects[i]);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label7.Text = DropDownList1.SelectedValue.ToString();
            Label8.Text = DropDownList2.SelectedValue.ToString();
            Label9.Text = DropDownList3.SelectedValue.ToString();
            Label10.Text = DropDownList4.SelectedValue.ToString();
            Label11.Text = DropDownList5.SelectedValue.ToString();
        }
    }
}