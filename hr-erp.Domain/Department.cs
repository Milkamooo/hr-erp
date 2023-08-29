namespace hr_erp.Infrastructure
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Position>? Positions { get; set; }
    }
}
