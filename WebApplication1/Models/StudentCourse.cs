﻿namespace WebApplication1.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
