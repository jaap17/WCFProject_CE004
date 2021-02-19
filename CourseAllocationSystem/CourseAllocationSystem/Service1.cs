using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CourseAllocationSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {

        public String addSubject(Subject subject)
        {
            string retu = "Subject not added successfully";
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Insert into Subjects values(@id,@name,@semester)", conn);
            SqlParameter p = new SqlParameter("@id", subject.SubjectId);
            SqlParameter q = new SqlParameter("@name", subject.Name);
            SqlParameter r = new SqlParameter("@semester", subject.Semester);
            cmd.Parameters.Add(p);
            cmd.Parameters.Add(q);
            cmd.Parameters.Add(r);
            conn.Open();
            int ret = cmd.ExecuteNonQuery();
            if(ret == 1)
            {
                retu = "Subject Stored Successsfully";
            }
            conn.Close();
            return retu;
        }

        public string deleteSubject(string subjectid)
        {
            string retu = "Data deletion not successful";
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Delete from Subjects where SubjectId = @subid", conn);
            cmd.Parameters.Add(new SqlParameter("@subid",subjectid));
            conn.Open();
            int res = cmd.ExecuteNonQuery();
            if(res == 1)
            {
                retu = "Deletion Successful";
            }
            conn.Close();
            return retu;
        }

        public string editSubject(Subject subject)
        {
            string retu = "Update not successful";
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("update Subjects set Name=@name,Semester=@sem where SubjectId=@id", conn);
            SqlParameter p = new SqlParameter("@name", subject.Name);
            SqlParameter q = new SqlParameter("@sem", subject.Semester);
            SqlParameter r = new SqlParameter("@id", subject.SubjectId);
            cmd.Parameters.Add(p);
            cmd.Parameters.Add(q);
            cmd.Parameters.Add(r);
            conn.Open();
            int ret = cmd.ExecuteNonQuery();
            if(ret == 1)
            {
                retu = "Data Updated Successfully";
            }
            conn.Close();
            return retu;
        }

        public List<Subject> getEvenSubjects()
        {
            List<Subject> subjects = new List<Subject>();
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Select * from Subjects where Semester=2", conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Subject subject = new Subject();
                subject.SubjectId = dataReader.GetString(0);
                subject.Name = dataReader.GetString(1);
                subject.Semester = dataReader.GetInt32(2);
                subjects.Add(subject);
            }
            conn.Close();
            return subjects;
        }

        public List<Subject> getEvenSubjectsFour()
        {
            List<Subject> subjects = new List<Subject>();
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Select * from Subjects where  Semester=4", conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Subject subject = new Subject();
                subject.SubjectId = dataReader.GetString(0);
                subject.Name = dataReader.GetString(1);
                subject.Semester = dataReader.GetInt32(2);
                subjects.Add(subject);
            }
            conn.Close();
            return subjects;
        }

        public List<Subject> getEvenSubjectsSix()
        {
            List<Subject> subjects = new List<Subject>();
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Select * from Subjects where Semester=6", conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Subject subject = new Subject();
                subject.SubjectId = dataReader.GetString(0);
                subject.Name = dataReader.GetString(1);
                subject.Semester = dataReader.GetInt32(2);
                subjects.Add(subject);
            }
            conn.Close();
            return subjects;
        }

        public List<Subject> getOddSubjects()
        {
            List<Subject> subjects = new List<Subject>();
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Select * from Subjects where Semester=7", conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Subject subject = new Subject();
                subject.SubjectId = dataReader.GetString(0);
                subject.Name = dataReader.GetString(1);
                subject.Semester = dataReader.GetInt32(2);
                subjects.Add(subject);
            }
            conn.Close();
            return subjects;
        }

        public List<Subject> getOddSubjectsThree()
        {
            List<Subject> subjects = new List<Subject>();
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Select * from Subjects where Semester=3", conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Subject subject = new Subject();
                subject.SubjectId = dataReader.GetString(0);
                subject.Name = dataReader.GetString(1);
                subject.Semester = dataReader.GetInt32(2);
                subjects.Add(subject);
            }
            conn.Close();
            return subjects;
        }

        public List<Subject> getOddSubjectsFive()
        {
            List<Subject> subjects = new List<Subject>();
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Select * from Subjects where Semester=5", conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Subject subject = new Subject();
                subject.SubjectId = dataReader.GetString(0);
                subject.Name = dataReader.GetString(1);
                subject.Semester = dataReader.GetInt32(2);
                subjects.Add(subject);
            }
            conn.Close();
            return subjects;
        }

        public List<string> getAllSubjects()
        {
            List<string> subjects  = new List<string>();
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Select Name from Subjects", conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            while(dataReader.Read())
            {
                subjects.Add(dataReader.GetString(0));
            }
            conn.Close();
            return subjects;
        }

        public string getNameOnUsername(string username)
        {
            string name = "No Name found", name1 = null;
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Select firstname,lastname from Faculties where username = @username",conn);
            cmd.Parameters.Add(new SqlParameter("@username",username));
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                name = reader.GetString(0);
                name1 = reader.GetString(1);
            }
            string name3 = name + "  " + name1;
            conn.Close();
            return name3;
        }

        public int Login(string username, string password)
        {
            string name = "login Failed";
            int ans = 0;
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Select * from Faculties where username=@username and password=@password",conn);
            SqlParameter p = new SqlParameter("@username",username);
            SqlParameter q = new SqlParameter("@password", password);
            cmd.Parameters.Add(p);
            cmd.Parameters.Add(q);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                name = "Login Successful";
                ans = 1;
            }
            conn.Close();
            return ans;
        }

        public string storeCourseAllocation(AllocatedCourses course)
        {
            string retu = "Allocation not stored successfully";
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Insert into AllocatedCourses values(@subjectname,@faculty1,@faculty2)", conn);
            SqlParameter p = new SqlParameter("@subjectname",course.SubjectName);
            SqlParameter q = new SqlParameter("@faculty1", course.Faculty1Name);
            SqlParameter r = new SqlParameter("@faculty2", course.Faculty2Name);
            cmd.Parameters.Add(p);
            cmd.Parameters.Add(q);
            cmd.Parameters.Add(r);
            conn.Open();
            int ret = cmd.ExecuteNonQuery();
            if(ret == 1)
            {
                retu = "Allocation stored successfully";
            }
            return retu;
        }

        public string storeFacultyChoice(string name, string priority1, string priority2, string priority3, string priority4, string priority5)
        {
            string retu = "Choice not stored successfully";
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Insert into FacultyChoice values(@name,@priority1,@priority2,@priority3,@priority4,@priority5)", conn);
            SqlParameter p = new SqlParameter("@name", name);
            SqlParameter q = new SqlParameter("@priority1", priority1);
            SqlParameter r = new SqlParameter("@priority2", priority2);
            SqlParameter s = new SqlParameter("@priority3", priority3);
            SqlParameter t = new SqlParameter("@priority4", priority4);
            SqlParameter u = new SqlParameter("@priority5", priority5);
            cmd.Parameters.Add(p);
            cmd.Parameters.Add(q);
            cmd.Parameters.Add(r);
            cmd.Parameters.Add(s);
            cmd.Parameters.Add(t);
            cmd.Parameters.Add(u);
            conn.Open();
            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
            {
                retu = "Faculty Choice Stored Successsfully";
            }
            conn.Close();
            return retu;
        }

        public List<FacultyChoice> GetFacultyChoices()
        {
            List<FacultyChoice> facultyChoices = new List<FacultyChoice>();
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Select * from FacultyChoice", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                FacultyChoice facultyChoice = new FacultyChoice();
                facultyChoice.Name = reader.GetString(0);
                facultyChoice.Priority1 = reader.GetString(1);
                facultyChoice.Priority2 = reader.GetString(2);
                facultyChoice.Priority3 = reader.GetString(3);
                facultyChoice.Priority4 = reader.GetString(4);
                facultyChoice.Priority5 = reader.GetString(5);
                facultyChoices.Add(facultyChoice);
            }
            conn.Close();
            return facultyChoices;
        }

        public List<string> GetFacultyNames()
        {
            List<string> names = new List<string>();
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Select firstname,lastname from Faculties", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                string fname = reader.GetString(0);
                string lname = reader.GetString(1);
                string name = fname + " " + lname;
                names.Add(name);
            }
            conn.Close();
            return names;
        }

        public int addAllocation(CourseAllocation courseAllocation)
        {
            int ret = 0;
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Insert into AllocatedCourses values(@subject1,@faculty,@subject2)", conn);
            conn.Open();
            SqlParameter p = new SqlParameter("@subject1",courseAllocation.Subject1);
            SqlParameter q= new SqlParameter("@faculty", courseAllocation.FacultyName);
            SqlParameter r = new SqlParameter("@subject2", courseAllocation.Subject2);
            cmd.Parameters.Add(p);
            cmd.Parameters.Add(q);
            cmd.Parameters.Add(r);
            ret = cmd.ExecuteNonQuery();
            conn.Close();
            return ret;
        }

        public List<CourseAllocation> courseAllocations()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Select * from AllocatedCourses", conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            List<CourseAllocation> finalallocation = new List<CourseAllocation>();
            while(dataReader.Read())
            {
                CourseAllocation course = new CourseAllocation();
                course.FacultyName = dataReader.GetString(1);
                course.Subject1 = dataReader.GetString(0);
                course.Subject2 = dataReader.GetString(2);
                finalallocation.Add(course);
            }
            return finalallocation;
        }

        public Faculty addFaculty(Faculty faculty)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Insert into Faculties values(@uname,@pass,@fname,@lname,@exp)", conn);
            conn.Open();
            Faculty f1 = new Faculty();
            f1.firstname = faculty.firstname;
            f1.password = faculty.password;
            f1.username = faculty.username;
            f1.Experience = faculty.Experience;
            f1.lastname = faculty.lastname;
            SqlParameter p = new SqlParameter("@fname", f1.firstname);
            SqlParameter q = new SqlParameter("@lname", f1.lastname);
            SqlParameter r = new SqlParameter("@uname", f1.username);
            SqlParameter s = new SqlParameter("@pass", f1.password);
            SqlParameter t = new SqlParameter("@exp", f1.Experience);
            
            cmd.Parameters.Add(r);
            cmd.Parameters.Add(s);
            cmd.Parameters.Add(p);
            cmd.Parameters.Add(q);
            cmd.Parameters.Add(t);
            cmd.ExecuteNonQuery();
            conn.Close();
            return f1;
        }

        public int deleteFaculty(string name)
        {
            int ans = 0;
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Delete from Faculties where firstname=@fname", conn);
            conn.Open();
            SqlParameter p = new SqlParameter("@fname",name);
            cmd.Parameters.Add(p);
            ans = cmd.ExecuteNonQuery();
            conn.Close();
            return ans;
        }

        public int facultyCount()
        {
            int ans = 0;
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Select Count(*) from Faculties", conn);
            conn.Open();
            ans = (int)cmd.ExecuteScalar();
            return ans;
        }

        public int choiceCount()
        {
            int ans = 0;
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Select Count(*) from FacultyChoice", conn);
            conn.Open();
            ans = (int)cmd.ExecuteScalar();
            return ans;
        }

        public int deleteChoices()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Delete  from FacultyChoice", conn);
            conn.Open();
            int ans = cmd.ExecuteNonQuery();
            conn.Close();
            return ans;
        }

        public int deleteAllocation()
        {
            int ans=0;
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Delete  from AllocatedCourses", conn);
            conn.Open();
            ans = cmd.ExecuteNonQuery();
            conn.Close();
            return ans;
        }

        public string AddSemestertype(string type)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("insert into Type values(@type)", conn);
            conn.Open();
            SqlParameter p = new SqlParameter("@type",type);
            cmd.Parameters.Add(p);
            int ans = cmd.ExecuteNonQuery();
            return type;
        }


        public string GetSemesterType()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Select * from Type", conn);
            //SqlParameter p = new SqlParameter("@type", type);
            conn.Open();
            string type = null;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                type = reader.GetString(0);
            }
            return type;
        }

        public void DeleteSemesterType()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseAllocation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Delete from Type", conn);
            //SqlParameter p = new SqlParameter("@type", type);
            conn.Open();
            int ans = cmd.ExecuteNonQuery();
            return;
        }
    }
}
