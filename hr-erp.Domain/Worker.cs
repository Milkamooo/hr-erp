namespace hr_erp.Domain
{
    public class Worker : Person
    {
        public int PositionId { get; set; }
        public int DepartmentId { get; set; }
    }
}
