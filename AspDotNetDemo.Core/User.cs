using System.ComponentModel.DataAnnotations;

namespace AspDotNetDemo.Core
{
<<<<<<< HEAD
    public class User
=======
    internal class User
>>>>>>> 647b00c1a4bb8cdef0c5cadd790477509e072f9d
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public int Phone { get; set; }
        public string Bio { get; set; }

    }
}
