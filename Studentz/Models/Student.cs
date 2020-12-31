using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Studentz.Models
{
    public enum gender
    {
        [EnumMember(Value = "Male")]
        Male,

        [EnumMember(Value = "Female")]
        Female
    }

    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Please insert valid name!")]
        public string firstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Please insert valid name!")]
        public string lastName { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime birthDate { get; set; }

        [Required]
        public gender? studentGender { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please insert valid email address!")]
        public string email { get; set; }

        [Required]
        [StringLength(11)]
        [Phone(ErrorMessage = "Please insert valid phonenumber!")]
        public string phoneNumber { get; set; }

        [Required]
        public string address { get; set; }

        [Required]
        public int houseNumber { get; set; }

        [Required]
        public int zip { get; set; }

        [Required]
        public string location { get; set; }
    }
}
