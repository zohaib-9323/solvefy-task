using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Solvefy_Assessment.Models;

namespace Solvefy_Assessment.Data;
public class ApplicationDbContext : IdentityDbContext<User>

{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Product> Products { get; set; }

}