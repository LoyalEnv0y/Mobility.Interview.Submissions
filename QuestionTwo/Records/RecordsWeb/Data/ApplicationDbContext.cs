using Microsoft.EntityFrameworkCore;
using RecordsWeb.Models;

namespace RecordsWeb.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Record> Records { get; set; }
}
