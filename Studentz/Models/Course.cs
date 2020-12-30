using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Studentz.Models
{
    public enum courseLanguage
    {
        [EnumMember(Value = "Dutch")]
        NL,

        [EnumMember(Value = "French")]
        FR,

        [EnumMember(Value = "English")]
        EN
    }

    public class Course
    {
        [Key]
        public int courseID { get; set; }

        [Required]
        [Display(Name = "Course name")]
        public string courseName { get; set; }

        [Required]
        [Display(Name = "Course Language")]
        public courseLanguage? language { get; set; }
    }
}
