using System.ComponentModel.DataAnnotations;

namespace AspDotNetDemo.Core
{
    public class User

    {
        [Required(ErrorMessage = "The ID of User is Required")]
        [Display(Name = "Id of User:")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The First Name of User is Required")]
        [Display(Name = "First Name:")]
        [MaxLength(15, ErrorMessage = "Please enter correct value")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The Last Name of User is Required")]
        [Display(Name = "Last Name:")]
        [MinLength(2), MaxLength(15, ErrorMessage = "Please enter correct value")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The Email of User is Required")]
        [Display(Name = "Email:")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "The Password of User is Required")]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        [MinLength(8), MaxLength(16, ErrorMessage = "Password must be between 8 and 16 characters")]
        public string Password { get; set; }

        [Display(Name = "Phone:")]
        [DataType(DataType.PhoneNumber)]
        public long Phone { get; set; }

        [Range(0, 100, ErrorMessage = "Please enter correct value from 0 to 100")]
        [Display(Name = "Bio:")]
        public string Bio { get; set; }

    }
}
