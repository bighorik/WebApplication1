namespace Application.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<bool> ExistsAsync(Guid id);
    }
}
