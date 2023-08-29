using hr_erp.Infrastructure;

namespace hr_erp.Application
{
    public class DepartmentService
    {
        LocalRepository repository = new LocalRepository();
        public List<Department>? GetDepartments()
        {
            return repository.Departments;
        }
        public Department GetDepartment(int id)
        {
            return repository.Departments!.Where(d => d.Id.Equals(id)).FirstOrDefault();
        }

        public void AddDepartment(Department department)
        {

        }
        public void DeleteDepartment(int id)
        {

        }
    }
}
