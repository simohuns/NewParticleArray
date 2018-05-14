using System.ComponentModel.DataAnnotations;

namespace NewParticleArray.Models
{
    public class ContactEmail
    {
        public ContactEmail(){}

        [Required(ErrorMessage = "I must know your name!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "I'll need to get back to you.")]
        [EmailAddress(ErrorMessage = "Valid email address needed.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Write a message!")]
        public string Message { get; set; }

        // If the message was processed succesfully
        public bool Success { get; set; }
    }
}