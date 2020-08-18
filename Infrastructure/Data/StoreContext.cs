using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
  public class StoreContext : DbContext
  {
    // Summary:
    // unit of work and repo pattern implementer
    // A session to connect to the database
    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {


    }

  public DbSet<Product> Products { get; set; }


  }

}