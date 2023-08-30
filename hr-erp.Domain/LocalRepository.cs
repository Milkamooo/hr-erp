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
        public LocalRepository()
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
                        Name = "HR",
                        Busy = true,
                    },
                    new Position()
                    {
                        Id = 7,
                        Name = "HR",
                        Busy = true
                    },
                    new Position()
                    {
                        Id = 8,
                        Name = "HR",
                        Busy = true,
                    }
                }
            };
            Department d3 = new Department()
            {
                Id = 3,
                Name = "Отдел backend-разработки",
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
            Department d4 = new Department()
            {
                Id = 4,
                Name = "Отдел связей с общественностью",
                Positions = new List<Position>()
                {
                    new Position()
                    {
                        Id = 9,
                        Name = "Сотрудник",
                        Busy = false,
                    }
                }
            };
            Department d5 = new Department()
            {
                Id = 5,
                Name = "Экономический отдел",
                Positions = new List<Position>()
                {
                    new Position()
                    {
                        Id = 10,
                        Name = "Сотрудник",
                        Busy = false,
                    }
                }
            };
            Department d6 = new Department()
            {
                Id = 6,
                Name = "Отдел планирования",
                Positions = new List<Position>()
                {
                    new Position()
                    {
                        Id = 11,
                        Name = "Сотрудник",
                        Busy = false,
                    }
                }
            };
            Department d7 = new Department()
            {
                Id = 7,
                Name = "Отдел охраны труда",
                Positions = new List<Position>()
                {
                    new Position()
                    {
                        Id = 12,
                        Name = "Сотрудник",
                        Busy = false,
                    }
                }
            };
            Department d8 = new Department()
            {
                Id = 8,
                Name = "Юридический отдел",
                Positions = new List<Position>()
                {
                    new Position()
                    {
                        Id = 13,
                        Name = "Сотрудник",
                        Busy = false,
                    }
                }
            };
            Department d9 = new Department()
            {
                Id = 9,
                Name = "Отдел frontend-разработки",
                Positions = new List<Position>()
                {
                    new Position()
                    {
                        Id = 14,
                        Name = "Сотрудник",
                        Busy = false,
                    }
                }
            };
            Department d10 = new Department()
            {
                Id = 10,
                Name = "Отдел мобильной разработки",
                Positions = new List<Position>()
                {
                    new Position()
                    {
                        Id = 15,
                        Name = "Сотрудник",
                        Busy = false,
                    }
                }
            };

            Employee e1 = new Employee()
            {
                Id = 1,
                Name = "Иван",
                LastName = "Иванов",
                PositionId = 1,
                DepartmentId = 1,
                Salary = 1000,
                Bonus = 0,
                Permanent = true
            };
            Employee e2 = new Employee()
            {
                Id = 2,
                Name = "Анна",
                LastName = "Арзамас",
                PositionId = 4,
                DepartmentId = 1,
                Salary = 1000,
                Bonus = 0,
                Permanent = true
            };
            Employee e3 = new Employee()
            {
                Id = 3,
                Name = "Сергей",
                LastName = "Сергеев",
                PositionId = 2,
                DepartmentId = 2,
                Salary = 1000,
                Bonus = 0,
                Permanent = true
            };
            Employee e4 = new Employee()
            {
                Id = 4,
                Name = "Юлия",
                LastName = "Иларионова",
                PositionId = 5,
                DepartmentId = 2,
                Salary = 1000,
                Bonus = 0,
                Permanent = true
            };
            Employee e5 = new Employee()
            {
                Id = 5,
                Name = "Александра",
                LastName = "Иродова",
                PositionId = 6,
                DepartmentId = 3,
                Salary = 1000,
                Bonus = 0,
                Permanent = true
            };
            Employee e6 = new Employee()
            {
                Id = 6,
                Name = "Роман",
                LastName = "Романов",
                PositionId = 3,
                DepartmentId = 3,
                Salary = 1000,
                Bonus = 0,
                Permanent = false
            };
            Employee e7 = new Employee()
            {
                Id = 7,
                Name = "Георгий",
                LastName = "Георгиев",
                PositionId = 7,
                DepartmentId = 2,
                Salary = 1000,
                Bonus = 0,
                Permanent = true
            };
            Employee e8 = new Employee()
            {
                Id = 8,
                Name = "Александр",
                LastName = "Александров",
                PositionId = 8,
                DepartmentId = 2,
                Salary = 1000,
                Bonus = 0,
                Permanent = true
            };

            Departments.Add(d1);
            Departments.Add(d2);
            Departments.Add(d3);
            Departments.Add(d4);
            Departments.Add(d5);
            Departments.Add(d6);
            Departments.Add(d7);
            Departments.Add(d8);
            Departments.Add(d9);
            Departments.Add(d10);
            Employees.Add(e1);
            Employees.Add(e2);
            Employees.Add(e3);
            Employees.Add(e4);
            Employees.Add(e5);
            Employees.Add(e6);
            Employees.Add(e7);
            Employees.Add(e8);
        }
    }
}
