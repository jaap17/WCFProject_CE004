using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CourseAllocationSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        int Login(string username, string password);

        [OperationContract]
        String addSubject(Subject subject);

        [OperationContract]
        string editSubject(Subject subject);

        [OperationContract]
        string deleteSubject(string subjectid);

        [OperationContract]
        string getNameOnUsername(string username);

        [OperationContract]
        string storeFacultyChoice(string name,string priority1,string priority2,string priority3,string priority4,string priority5);

        [OperationContract]
        string storeCourseAllocation(AllocatedCourses course);

        [OperationContract]
        List<string> getAllSubjects();

        [OperationContract]
        List<Subject> getEvenSubjects();

        [OperationContract]
        List<Subject> getEvenSubjectsSix();

        [OperationContract]
        List<Subject> getEvenSubjectsFour();

        [OperationContract]
        List<Subject> getOddSubjects();

        [OperationContract]
        List<Subject> getOddSubjectsThree();

        [OperationContract]
        List<Subject> getOddSubjectsFive();

        [OperationContract]
        List<FacultyChoice> GetFacultyChoices();

        [OperationContract]
        List<string> GetFacultyNames();

        [OperationContract]
        int addAllocation(CourseAllocation courseAllocation);

        [OperationContract]
        List<CourseAllocation> courseAllocations();

        [OperationContract]
        Faculty addFaculty(Faculty faculty);

        [OperationContract]
        int deleteFaculty(string name);

        [OperationContract]
        int facultyCount();

        [OperationContract]
        int choiceCount();

        [OperationContract]
        int deleteChoices();

        [OperationContract]
        int deleteAllocation();

        [OperationContract]
        string AddSemestertype(string type);

        [OperationContract]
        string GetSemesterType();

        [OperationContract]
        void DeleteSemesterType();
        
        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "CourseAllocationSystem.ContractType".
   
    
}
