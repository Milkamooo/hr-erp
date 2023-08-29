namespace hr_erp.Infrastructure
{
    public class Employee : Person
    {
        public int PositionId { get; set; }
        public int DepartmentId { get; set; }
        public bool Permanent { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
    }
}