using System.ComponentModel.DataAnnotations;

namespace bookpage.webui.Models
{
    public class RegisterModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]//RePassword'e girdiğin değer passwordle aynı olmak zorunda
        public string RePassword { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }
    }
}