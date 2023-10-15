using Microsoft.EntityFrameworkCore;
using AbbyWeb.Models;
using System.Security.Cryptography.X509Certificates;

namespace AbbyWeb.Data;
public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
        
        
    }

    public DbSet<Category> Categories { get; set; }
}