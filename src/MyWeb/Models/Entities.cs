using System;
using System.ComponentModel.DataAnnotations;

namespace MyWeb.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; } = DateTime.UtcNow;

        [Range(0, 4.0)]
        public double GPA { get; set; }
    }

    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Subject { get; set; }

        public DateTime HireDate { get; set; } = DateTime.UtcNow;
    }
}
