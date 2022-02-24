using StudentManage.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.Dto;
using WcfService.Entity;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        MyDBContext myDBContext = new MyDBContext();
        public List<Employee> GetAll(string Department)
        {
            if (!String.IsNullOrEmpty(Department))
            {
                return myDBContext.employees.Where(m => m.Department.Contains(Department)).ToList();
            } 
              return myDBContext.employees.ToList();
        }

        public bool Save(EmployeeDto employeeDto)
        {
            try
            {
                Employee employee = new Employee()
                {
                    EmployeeName = employeeDto.EmployeeName,
                    Department = employeeDto.Department,
                    Salary = employeeDto.Salary
                };
                myDBContext.employees.Add(employee);
                myDBContext.SaveChanges();
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }

      
    }
}
