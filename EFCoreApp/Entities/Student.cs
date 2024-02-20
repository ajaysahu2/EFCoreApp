namespace EFCoreApp.Entities
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
    }
}
