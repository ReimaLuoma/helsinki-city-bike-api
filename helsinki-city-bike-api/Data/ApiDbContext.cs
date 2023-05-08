using BikeApp.Drivers;
using Microsoft.EntityFrameworkCore;

namespace BikeApp.Data;

public class ApiDbContext : DbContext {
    
    public ApiDbContext(DbContextOptions<ApiDbContext> options)
        :base(options)
    {

    }

    public DbSet<Driver> Drives {get;set;}
}