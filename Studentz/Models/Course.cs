using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Studentz.Models
{
   
    public class Course
    {
        [Key]
        public int courseID { get; set; }

        [Required]
        [Display(Name = "Course")]
        public string courseName { get; set; }

        [Required]
        [Display(Name = "Class")]
        public string courseClass { get; set;}

        [Required]
        [Display(Name = "Course Language (choose between EN, FR, NL)")]
        public string language { get; set; }
    }
}
