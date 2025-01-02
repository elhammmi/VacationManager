using VacationManager.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace VacationManager.Infrastructure.Data;
public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>(); 
        optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=VacationManagerDb;Username=postgres;Password=1234;"); 
        return new ApplicationDbContext(optionsBuilder.Options);
    }
}
