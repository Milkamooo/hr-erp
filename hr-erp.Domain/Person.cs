namespace hr_erp.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
