using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseAllocationSystemClient
{
    public partial class Allocation : System.Web.UI.Page
    {
        int length = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            GridView1.DataSource = client.GetFacultyChoices();
            GridView1.DataBind();
            ServiceReference1.Subject[] sub = null ;
            ServiceReference1.Subject[] sub1 = null;
            ServiceReference1.Subject[] sub2 = null;
            string[] names = client.GetFacultyNames();
            string type = client.GetSemesterType();
            if(type.Equals("odd"))
            {
                sub = client.getOddSubjects();
                sub1 = client.getOddSubjectsThree();
                 sub2 = client.getOddSubjectsFive();
            }
            else
            {
                 sub = client.getEvenSubjects();
                 sub1 = client.getEvenSubjectsFour();
                 sub2 = client.getEvenSubjectsSix();
            }
            
            TableRow row1 = new TableRow();
            
            TableCell cell3 = new TableCell();
            cell3.Text = "<h3>Faculty Name</h3>";
            TableCell cell4 = new TableCell();
            cell4.Text = "<h3>Subject One Assignment</h3>";
            TableCell cell5 = new TableCell();
            cell5.Text = "<h3>Subject Two Assignment</h3>";
            row1.Cells.Add(cell3);
            row1.Cells.Add(cell4);
            row1.Cells.Add(cell5);
            Table1.Rows.Add(row1);
            List<string> subnames = new List<string>();
            for(int k=0;k<sub.Length;k++)
            {
                subnames.Add(sub[k].Name);

            }
            for (int k = 0; k < sub1.Length; k++)
            {
                subnames.Add(sub1[k].Name);

            }
            for (int k = 0; k < sub2.Length; k++)
            {
                subnames.Add(sub2[k].Name);

            }
            length = names.Length;
            for (int i=0;i<names.Length;i++)
            {
                TableRow row = new TableRow();
                TableCell cell = new TableCell();
                TableCell cell1 = new TableCell();
                TableCell cell2 = new TableCell();
                DropDownList drop = new DropDownList();
                drop.ID = "Drop"+i.ToString();
                DropDownList drop1 = new DropDownList();
                drop1.ID = "Drop1"+i.ToString();
                if(i == names.Length-1)
                {
                    label5.Text = drop.ID + " " + drop1.ID;
                }
                for (int j = 0; j < subnames.Count; j++)
                {
                    drop.Items.Add(subnames[j]);
                    drop1.Items.Add(subnames[j]);
                }
                cell.Text = names[i];
                row.Cells.Add(cell);
                cell1.Controls.Add(drop);
                cell2.Controls.Add(drop1);
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                //table1.Controls.Add(row);
                Table1.Rows.Add(row);
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            string[] names = client.GetFacultyNames();
            List<string> allocation = new List<string>();
            allocation.Add("Choice1");

            List<ServiceReference1.CourseAllocation> courseAllocations = new List<ServiceReference1.CourseAllocation>();

            List<string> allocation1 = new List<string>();
            allocation1.Add("Choice2");
            int count = Table1.Rows.Count;
            for (int i=1;i<Table1.Rows.Count;i++)
            {
                ServiceReference1.CourseAllocation course = new ServiceReference1.CourseAllocation();
                string name = Table1.Rows[i].Cells[0].Text;
                
                DropDownList temp = ((DropDownList)Table1.Rows[i].Cells[1].FindControl("Drop"+(i-1).ToString()));
                DropDownList temp1 = ((DropDownList)Table1.Rows[i].Cells[1].FindControl("Drop1" + (i-1).ToString()));
                //allocation.Add(name + " "+temp.SelectedValue);
                //allocation1.Add(name + " " +temp1.SelectedValue);
                if (temp != null && temp1 != null)
                {
                    course.Subject1 = temp.SelectedValue;
                    course.Subject2 = temp1.SelectedValue;
                    course.FacultyName = name;
                    allocation.Add(temp.SelectedValue);
                    allocation1.Add(temp1.SelectedValue);
                    courseAllocations.Add(course);
                    //client.addAllocation(course);
                }
                else
                {
                    label5.Text = name + " allocation failed";
                }

            }
           
            for(int k=0;k<courseAllocations.Count;k++)
            {
                client.addAllocation(courseAllocations[k]);
            }
            Session["Admin"] = "Dr Pankaj Jalote";
            Response.Redirect("ViewAllocation.aspx");
            /*GridView2.DataSource = courseAllocations;
            GridView2.DataBind();*/
            //GridView3.DataSource =;
           // GridView3.DataBind();
            //Type obj1 = Table1.Rows[0].Cells[1].Controls.GetType();
            
        }
    }
}