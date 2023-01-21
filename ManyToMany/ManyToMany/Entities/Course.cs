namespace ManyToMany.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UnitQty { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get;}
    }
}
