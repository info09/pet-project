using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PetProject.Data
{
    public class PetProjectContextFactory : IDesignTimeDbContextFactory<PetProjectDbContext>
    {
        public PetProjectDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();
            var builder = new DbContextOptionsBuilder<PetProjectDbContext>();
            builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            return new PetProjectDbContext(builder.Options);
        }
    }
}
