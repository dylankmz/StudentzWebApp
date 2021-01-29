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
        Female,

        [EnumMember(Value = "Homme")]
        Homme,

        [EnumMember(Value = "Femme")]
        Femme,

        [EnumMember(Value = "Man")]
        Man,

        [EnumMember(Value = "Vrouw")]
        Vrouw
    }

    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please insert valid name!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Please insert valid name!")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Please insert valid name!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Please insert valid name!")]
        public string lastName { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime birthDate { get; set; }

        [Required(ErrorMessage = "Please use correct value as shown!")]
        public gender? studentGender { get; set; }

        [Required(ErrorMessage = "Please insert valid email address!")]
        [EmailAddress(ErrorMessage = "Please insert valid email address!")]
        public string email { get; set; }

        [Required(ErrorMessage = "Please insert valid phonenumber!")]
        [StringLength(11)]
        [Phone(ErrorMessage = "Please insert valid phonenumber!")]
        public string phoneNumber { get; set; }

        [Required(ErrorMessage = "Please insert correct address!")]
        public string address { get; set; }

        [Required(ErrorMessage = "Please insert correct house number!")]
        public int houseNumber { get; set; }

        [Required (ErrorMessage = "Please insert valid zip!")]
        public int zip { get; set; }

        [Required(ErrorMessage = "Please insert valid location!")]
        public string location { get; set; }

    }
}
