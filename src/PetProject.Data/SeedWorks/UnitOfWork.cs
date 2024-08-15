using PetProject.Core.SeedWorks;

namespace PetProject.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PetProjectDbContext _context;

        public UnitOfWork(PetProjectDbContext context)
        {
            _context = context;
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
