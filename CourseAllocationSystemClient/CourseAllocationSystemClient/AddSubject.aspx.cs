using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseAllocationSystemClient
{
    public partial class AddSubjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            string subjectid = TextBox1.Text;
            string subjectname = TextBox2.Text;
            int semester = int.Parse(TextBox3.Text);
            ServiceReference1.Subject subject = new ServiceReference1.Subject();
            subject.SubjectId = subjectid;
            subject.Semester = semester;
            subject.Name = subjectname;
            string ret = client.addSubject(subject);
            
            Label4.Text = ret;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("OddSubjects.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("EvenSubjects.aspx");
        }
    }
}