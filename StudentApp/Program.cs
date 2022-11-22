using StudentApp.College;

var con = new CollegeDbContext();

if(args.Length==0)
{
    foreach(var entry in con.Courses)
        Console.WriteLine("{0,-10} {1,12} {2,10}",entry.Id,entry.Name,entry.Fees);
}
else
{
    int CourseId = int.Parse(args[0]);
    var student = con.Courses
                    .Where(s => s.Id == CourseId)
                    .Include(c => c.Students)
                    .FirstOrDefault();

    if(student != null)
    {
        foreach(var entry in student.Students)
            Console.WriteLine($"{entry.Id}\t {entry.Name}\t {entry.Age}\t {entry.CourseId}\t {entry.Grade}");
    }
}