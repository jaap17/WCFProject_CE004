using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseAllocationSystemClient
{
    public partial class OddChoiceFillingForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            ServiceReference1.Subject[] subjects = client.getOddSubjects();
            ServiceReference1.Subject[] subjects1 = client.getOddSubjectsFive();
            ServiceReference1.Subject[] subjects2 = client.getOddSubjectsThree();
            if (Session["Name"] != null)
            {
                Label2.Text = Session["Name"].ToString();
            }

            if (Session["Admin"] != null && (Session["Name"] == null))
            {
                Label2.Text = Session["Admin"].ToString();
                client.AddSemestertype("odd");
                Session["FormSemester"] = "OddChoiceFillingForm.aspx";
            }

            

            for(int i=0;i<subjects.Length;i++)
            {
                DropDownList1.Items.Add(subjects[i].Name);
                DropDownList2.Items.Add(subjects[i].Name);
                DropDownList3.Items.Add(subjects[i].Name);
                DropDownList4.Items.Add(subjects[i].Name);
                DropDownList5.Items.Add(subjects[i].Name);
            }

            for (int i = 0; i < subjects1.Length; i++)
            {
                DropDownList1.Items.Add(subjects1[i].Name);
                DropDownList2.Items.Add(subjects1[i].Name);
                DropDownList3.Items.Add(subjects1[i].Name);
                DropDownList4.Items.Add(subjects1[i].Name);
                DropDownList5.Items.Add(subjects1[i].Name);
            }

            for (int i = 0; i < subjects2.Length; i++)
            {
                DropDownList1.Items.Add(subjects2[i].Name);
                DropDownList2.Items.Add(subjects2[i].Name);
                DropDownList3.Items.Add(subjects2[i].Name);
                DropDownList4.Items.Add(subjects2[i].Name);
                DropDownList5.Items.Add(subjects2[i].Name);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            //ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            string name = "";
            if (Session["Name"] != null)
            {
                name = Session["Name"].ToString();
            }
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            if (name != null)
            {
                string result = client.storeFacultyChoice(name, DropDownList1.SelectedValue.ToString(), DropDownList2.SelectedValue.ToString(), DropDownList3.SelectedValue.ToString(),
                    DropDownList4.SelectedValue.ToString(), DropDownList5.SelectedValue.ToString());
                //Label1.Text = result;
                showAlert(result);
               
            }
        }

        protected void showAlert(string result)
        {
            
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(result);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
            return;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string name = Session["Name"].ToString();
            Session["Name"] = name;
            Response.Redirect("Homepage.aspx");
        }
    }
}