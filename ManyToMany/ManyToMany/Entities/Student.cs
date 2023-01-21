namespace ManyToMany.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual  ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
