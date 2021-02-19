using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CourseAllocationSystem
{
    [DataContract]
    public class FacultyChoice
    {
        private string facultyname;
        private string priority1;
        private string priority2;
        private string priority3;
        private string priority4;
        private string priority5;

        [DataMember]
        public string Name
        {
            get { return facultyname; }
            set { facultyname = value; }
        }

        [DataMember]
        public string Priority1
        {
            get { return priority1; }
            set { priority1 = value; }
        }

        [DataMember]
        public string Priority2
        {
            get { return priority2; }
            set { priority2 = value; }
        }

        [DataMember]
        public string Priority3
        {
            get { return priority3; }
            set { priority3 = value; }
        }

        [DataMember]
        public string Priority4
        {
            get { return priority4; }
            set { priority4 = value; }
        }

        [DataMember]
        public string Priority5
        {
            get { return priority5; }
            set { priority5 = value; }
        }

    }
}
