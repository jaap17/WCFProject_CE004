using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CourseAllocationSystem
{
    [DataContract]
    public class Subject
    {
        private string subjectid;
        private string name;
        private int semester;

        [DataMember]
        public string SubjectId
        {
            get { return subjectid; }
            set { subjectid = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public int Semester
        {
            get { return semester; }
            set { semester = value; }
        }
    }
}
