namespace VaccineApp.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Login
    {
        public int Id { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]
        public byte[] PasswordSalt { get; set; }
    }
}