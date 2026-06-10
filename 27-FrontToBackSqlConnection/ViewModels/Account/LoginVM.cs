using System.ComponentModel.DataAnnotations;

namespace _27_FrontToBackSqlConnection.ViewModels
{
    public class LoginVM
    {

        [Required(ErrorMessage = "Please fill out this field!")]
        [MinLength(3)]
        [MaxLength(30)]
        public string UsernameOrEmail { get; set; }

        [Required(ErrorMessage = "Please fill out this field!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool IsPersistent { get; set; }
    }
}
