﻿namespace CrudOperations
{
    public class Course
    {
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
    }
}