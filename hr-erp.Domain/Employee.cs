namespace hr_erp.Domain
{
    public class Employee : Person
    {
        public int PositionId { get; set; }
        public int DepartmentId { get; set; }
    }
}
