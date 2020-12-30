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
        [Display(Name = "First Name")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Please insert valid name!")]
        public string firstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Please insert valid name!")]
        public string lastName { get; set; }

        [Required]
        [Display(Name = "Birth Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime birthDate { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public gender? studentGender { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Please insert valid email address!")]
        public string email { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [StringLength(11)]
        [Phone(ErrorMessage = "Please insert valid phonenumber!")]
        public string phoneNumber { get; set; }

        [Required]
        [Display(Name = "Home Address")]
        public string address { get; set; }

        [Required]
        [Display(Name = "Housenumber")]
        public int houseNumber { get; set; }

        [Required]
        [Display(Name = "ZIP")]
        public int zip { get; set; }

        [Required]
        [Display(Name = "Location")]
        public string location { get; set; }
    }
}
