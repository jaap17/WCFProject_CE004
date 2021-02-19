using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CourseAllocationSystem
{
    [DataContract]
    public class AllocatedCourses
    {
        private string subjectname;
        private string facultyname1;
        private string facultyname2;

        [DataMember]
        public string SubjectName
        {
            get { return subjectname; }
            set { subjectname = value; }
        }

        [DataMember]
        public string Faculty1Name
        {
            get { return facultyname1; }
            set { facultyname1 = value; }
        }

        [DataMember]
        public string Faculty2Name
        {
            get { return facultyname2; }
            set { facultyname2 = value; }
        }
    }
}
