using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Raktdaan.Models;

namespace Raktdaan.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var hasher = new PasswordHasher<ApplicationUser>();

            // Sample data arrays for randomizing user details
            string[] firstNames = new string[] { "Rohit", "Kunal", "Arpit", "Yash", "Vinay", "Ritik", "Jatin", "Sneha", "Monika", "Tanisha", "Manya", "Khushi", "Kritika", "Preeti", "Nisha", "Dhruv", "Shubham" };
            string[] lastNames = new string[] { "Bansal", "Jain", "Goyal", "Sharma", "Gupta", "Prakash", "Aggarwal", "Singh" };
            string[] cities = new string[] { "Gaziabad", "Noida", "Faridabad", "Shahdara", "Rohini", "Patel Nagar", "Dwarka", "Azadnagar", "Krishna Nagar" };
            string[] states = new string[] { "New Delhi", "Mumbai", "Chandigarh", "Banglore", "U.P", "Haryana" };
            string[] countries = new string[] { "India" };
            string[] bloodGroups = new string[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" };

            // Create an array for 100 users
            var users = new ApplicationUser[100];

            for (int i = 0; i < 100; i++)
            {
                // Use modulo to cycle through the sample arrays
                int fnIndex = i % firstNames.Length;
                int lnIndex = i % lastNames.Length;
                int cityIndex = i % cities.Length;
                int stateIndex = i % states.Length;
                int bgIndex = i % bloodGroups.Length;

                var firstName = firstNames[fnIndex];
                var lastName = lastNames[lnIndex];
                var fullName = $"{firstName} {lastName}";
                var email = $"{firstName.ToLower()}.{lastName.ToLower()}{i + 1}@gmail.com";

                users[i] = new ApplicationUser
                {
                    Id = (i + 1).ToString(), // Ensure unique IDs (consider using GUIDs for production)
                    UserName = email,
                    NormalizedUserName = email.ToUpper(),
                    Email = email,
                    NormalizedEmail = email.ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Password@123"), // Ensure the password meets your Identity requirements
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                    Full_Name = fullName,
                    City = cities[cityIndex],
                    State = states[stateIndex],
                    Country = "India",
                    Blood_group = bloodGroups[bgIndex],
                    PhoneNumber = "123-456-7890" // Dummy phone number; adjust as needed
                };
            }

            // Seed the users into the Identity database
            builder.Entity<ApplicationUser>().HasData(users);
        }
        
    }
}
