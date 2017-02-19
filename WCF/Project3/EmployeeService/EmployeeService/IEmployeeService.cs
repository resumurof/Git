using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        EmployeeInfo GetEmployee(EmployeeRequest employeeRequest);

        [OperationContract]
        void SaveEmployee(EmployeeInfo Employee);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "EmployeeService.ContractType".
    //[DataContract(Namespace = "http://MyCompany.com/Employee")]
    //public class Employee
    //{
    //    [DataMember(Order = 1)]
    //    public int Id { get; set; }

    //    [DataMember(Order = 2)]
    //    public string Name { get; set; }

    //    [DataMember(Order = 3)]
    //    public string Gender { get; set; }

    //    [DataMember(Order = 4)]
    //    public DateTime DateOfBirth { get; set; }

    //    [DataMember(Order = 5)]
    //    public EmployeeType Type { get; set; }
    //}
}
