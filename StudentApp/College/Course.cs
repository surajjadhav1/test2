namespace StudentApp.College;

public class Course
{
    public int Id { get; set; }

    public string Name { get; set; }

    public decimal Fees { get; set; }

    public List<Student> Students { get; set; }
    
}