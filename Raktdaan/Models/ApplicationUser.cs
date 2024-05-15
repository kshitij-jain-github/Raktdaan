using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Raktdaan.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Full_Name { get; set; }
        public string? Blood_group { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? PostalCode { get; set; }
        public string? Address { get; set; }

    }
    
}
