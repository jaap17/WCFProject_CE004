using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseAllocationSystemClient
{
    public partial class EvenChioiceFillingForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            ServiceReference1.Subject[] subjects = client.getEvenSubjects();
            ServiceReference1.Subject[] subjects1 = client.getEvenSubjectsFour();
            ServiceReference1.Subject[] subjects2 = client.getEvenSubjectsSix();

            if(Session["Admin"] != null)
            {
                Label2.Text = Session["Admin"].ToString();
                client.AddSemestertype("even");
                Session["FormSemester"] = "EvenChoiceFillingForm.aspx";   
            }

            for(int i=0;i<subjects.Length;i++)
            {
                DropDownList1.Items.Add(subjects[i].Name);
                DropDownList2.Items.Add(subjects[i].Name);
                DropDownList3.Items.Add(subjects[i].Name);
                DropDownList4.Items.Add(subjects[i].Name);
                DropDownList5.Items.Add(subjects[i].Name);
            }

            for(int i=0;i<subjects1.Length;i++)
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
            string name = "";
            Label1.Text = "Choice1:" + DropDownList1.SelectedValue.ToString() + "<br> Choice2:" + DropDownList2.SelectedValue.ToString()
                + "<br> Choice3 :"+ DropDownList3.SelectedValue.ToString() + "<br> Choice4: "+ DropDownList4.SelectedValue.ToString()
                + "<br>Choice5: "+ DropDownList5.SelectedValue.ToString();
            if(Session["Name"] != null)
            {
                name = Session["Name"].ToString();
            }
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            if(name != null)
            {
                string result = client.storeFacultyChoice(name, DropDownList1.SelectedValue.ToString(), DropDownList2.SelectedValue.ToString(), DropDownList3.SelectedValue.ToString(),
                    DropDownList4.SelectedValue.ToString(), DropDownList5.SelectedValue.ToString());
                Label3.Text = result;
            }
            else
            {
                Label3.Text = "No Name found";
            }
            
        }

        
    }
}