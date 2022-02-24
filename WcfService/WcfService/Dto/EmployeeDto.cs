using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Dto
{
    [DataContract]
    public class EmployeeDto
    {
        [DataMember]
        public int EmployeeID { get; set; }
        [DataMember]
        public string EmployeeName { get; set; }
        [DataMember]
        public double Salary { get; set; }
        [DataMember]
        public string Department { get; set; }
    }
}