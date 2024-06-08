using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCLabb4.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        [DisplayName("Förnamn")]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        [DisplayName("Efternamn")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(15)]
        [DisplayName("Telefon")]
        public string PhoneNumber { get; set; }
        public ICollection<Borrow> Borrows { get; set; } = new List<Borrow>();
    }
}
