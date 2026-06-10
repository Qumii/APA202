using System.ComponentModel.DataAnnotations;

namespace _27_FrontToBackSqlConnection.ViewModels
{
    public class RegisterVM
    {

        [Required(ErrorMessage = "Please fill out this field!")]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please fill out this field!")]
        [MinLength(3)]
        [MaxLength(30)]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Please fill out this field!")]
        [MinLength(3)]
        [MaxLength(30)]
        public string Username { get; set; }


        [Required(ErrorMessage = "Please fill out this field!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please fill out this field!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please fill out this field!")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfrimPassword { get; set; }
    }
}
