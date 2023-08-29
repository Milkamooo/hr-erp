using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr_erp.Infrastructure
{
    public class LocalRepository
    {
        public List<Department> Departments = new();
        public List<Employee> Employees = new();

        public void DefaultData()
        {
            Department d1 = new Department()
            {
                Id = 1,
                Name = "Бухгалтерия",
                Positions = new List<Position>()
                {
                    new Position()
                    {
                        Id = 4,
                        Name = "Руководитель",
                        Busy = true,
                    },
                    new Position()
                    {
                        Id = 1,
                        Name = "Бухгалтер",
                        Busy = true,
                    }
                }
            };
            Department d2 = new Department()
            {
                Id = 2,
                Name = "Отдел кадров",
                Positions = new List<Position>()
                {
                    new Position()
                    {
                        Id = 5,
                        Name = "Руководитель",
                        Busy = true,
                    },
                    new Position()
                    {
                        Id = 2,
                        Name = "HR"
                    }
                }
            };
            Department d3 = new Department()
            {
                Id = 3,
                Name = "Отдел разработки",
                Positions = new List<Position>()
                {
                    new Position()
                    {
                        Id = 6,
                        Name = "Руководитель",
                        Busy = true,
                    },
                    new Position()
                    {
                        Id = 3,
                        Name = "Разработчик"
                    }
                }
            };

            Employee e1 = new Employee()
            {
                Id = 1,
                Name = "",
                LastName = "",
                PositionId = 1,
                DepartmentId = 1,
                Salary = 1000,
                Bonus = 0,
                Permanent = true
            };
            Employee e2 = new Employee()
            {
                Id = 2,
                Name = "",
                LastName = "",
                PositionId = 4,
                DepartmentId = 1,
                Salary = 1000,
                Bonus = 0,
                Permanent = true
            };
            Employee e3 = new Employee()
            {
                Id = 3,
                Name = "",
                LastName = "",
                PositionId = 2,
                DepartmentId = 2,
                Salary = 1000,
                Bonus = 0,
                Permanent = true
            };
            Employee e4 = new Employee()
            {
                Id = 4,
                Name = "",
                LastName = "",
                PositionId = 5,
                DepartmentId = 2,
                Salary = 1000,
                Bonus = 0,
                Permanent = true
            };
            Employee e5 = new Employee()
            {
                Id = 5,
                Name = "",
                LastName = "",
                PositionId = 6,
                DepartmentId = 3,
                Salary = 1000,
                Bonus = 0,
                Permanent = true
            };
            Employee e6 = new Employee()
            {
                Id = 6,
                Name = "",
                LastName = "",
                PositionId = 3,
                DepartmentId = 3,
                Salary = 1000,
                Bonus = 0,
                Permanent = false
            };

            Departments.Add(d1);
            Departments.Add(d2);
            Departments.Add(d3);
            Employees.Add(e1);
            Employees.Add(e2);
            Employees.Add(e3);
            Employees.Add(e4);
            Employees.Add(e5);
            Employees.Add(e6);
        }
    }
}
