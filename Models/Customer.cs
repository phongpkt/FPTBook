using FPTLibrary.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FPTLibrary.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field cannot be empty!")]
        [MinLength(2, ErrorMessage = "The name length must be longer than 2!")]
        [MaxLength(50, ErrorMessage = "The name length exceed maximum required characters!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field cannot be empty!")]
        [MinLength(2, ErrorMessage = "The name length must be longer than 2!")]
        [MaxLength(50, ErrorMessage = "The name length exceed maximum required characters!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This field cannot be empty!")]
        [Url]
        public string Image { get; set; }
        [Required(ErrorMessage = "This field cannot be empty!")]
        [MinLength(5, ErrorMessage = "Email must be at least 5 characters long!")]
        [MaxLength(200, ErrorMessage = "Email cannot exceed 200 characters length!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field cannot be empty!")]
        [MinLength(10, ErrorMessage = "Phone number must be at least 10 characters long!")]
        [MaxLength(13, ErrorMessage = "Phone number length cannot exceed 13 characters!")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "This field cannot be empty!")]
        [MinLength(3, ErrorMessage = "Address must be at least 3 characters long!")]
        [MaxLength(200, ErrorMessage = "Address length cannot exceed 200 characters!")]
        public string Address { get; set; }
        [Required(ErrorMessage = "This field cannot be empty!")]
        public string Password { get; set; }
    }
}
