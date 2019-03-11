using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
    {
        public virtual string Email { get; set; } // example, not necessary
    }