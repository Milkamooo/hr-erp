using hr_erp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr_erp.Application
{
    public class EmployeeService
    {
        LocalRepository localRepository = new();
        public List<Employee>? GetEmployees()
        {
            return localRepository.Employees;
        }
        public Employee? GetEmployee(int id)
        {
            return localRepository.Employees!.Where(e => e.Id.Equals(id)).FirstOrDefault();
        }

        public void AddEmployee(Employee employee)
        {
            localRepository.Employees.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            var emp = localRepository.Employees.Where(e => e.Id.Equals(employee.Id)).FirstOrDefault();
            if (emp is not null)
            {
                emp.Name = employee.Name;
                emp.LastName = employee.LastName;
                emp.PositionId = employee.PositionId;
                emp.DepartmentId = emp.DepartmentId;
                emp.Salary = employee.Salary;
                emp.Bonus = employee.Bonus;
                emp.Permanent = employee.Permanent;
            }
        }
        public void DeleteEmployee(int id)
        {
            var employee = localRepository.Employees!.Where(e => e.Id.Equals(id)).FirstOrDefault();
            if (employee is not null)
            {
                localRepository.Employees.Remove(employee);
            }
        }
    }
}
