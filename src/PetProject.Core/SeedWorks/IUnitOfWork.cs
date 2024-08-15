namespace PetProject.Core.SeedWorks
{
    public interface IUnitOfWork
    {
        Task<int> CompleteAsync();
    }
}
