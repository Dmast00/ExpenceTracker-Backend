using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Models;

namespace ExpenseTracker.Models
{
    public class ApplicationDbContext :IdentityDbContext<IdentityUser>
    {
                
            public ApplicationDbContext(DbContextOptions options) : base(options)
            {

            }
                
            public DbSet<ExpenseTracker.Models.Transactions> Transactions { get; set; }
        
    }
}
