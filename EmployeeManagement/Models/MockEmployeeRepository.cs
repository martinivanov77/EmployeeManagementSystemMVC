using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employeeList;
        public MockEmployeeRepository()
        {
            this.employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Ivan", Department = Dept.HR, Email = "Ivan@gmail.com"},
                new Employee() { Id = 2, Name = "Dragan", Department = Dept.IT, Email = "Dragan@gmail.com"},
                new Employee() { Id = 3, Name = "Petkan", Department = Dept.None, Email = "Petkan@gmail.com"},
                new Employee() { Id = 4, Name = "Varban", Department = Dept.Payroll, Email = "Varban@gmail.com"}
            };
        }

        public Employee Add(Employee employee)
        {
           employee.Id =  this.employeeList.Max(e => e.Id) + 1;
            this.employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.employeeList;
        }
        public Employee GetEmployee(int id)
        {
            return this.employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}



