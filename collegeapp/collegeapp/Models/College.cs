namespace collegeapp.Models
{
    public static class  College
    {
        public static List<Student> Students { get; set; }= new List<Student>(){
                new Student
                {
                Id=1,
                StudentName="Student1",
                Email="email@gmail.com",
                Address="Banglore,India"
                },
                new Student
                {
                Id = 2,
                StudentName = "Student2",
                Email = "email1@gmail.com",
                Address = "Banglore,USA"
                }
                };
}
}
