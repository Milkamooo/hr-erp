using hr_erp.Infrastructure;

namespace hr_erp.Application
{
    public class DepartmentService
    {
        LocalRepository localRepository = new();
        public List<Department>? GetDepartments()
        {
            return localRepository.Departments;
        }
        public Department? GetDepartment(int id)
        {
            return localRepository.Departments!.Where(d => d.Id.Equals(id)).FirstOrDefault();
        }

        public void AddDepartment(Department department)
        {

        }
        public void DeleteDepartment(int id)
        {

        }
    }
}
