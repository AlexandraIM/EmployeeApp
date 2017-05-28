using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public DateTime EmployementDate { get; set; }
        [Required]
        public double Rate { get; set; }
    }
}