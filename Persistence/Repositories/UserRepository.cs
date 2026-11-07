using Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class UserRepository
        (ApplicationContext context): IUserRepository
    {
        public Task<bool> ExistsAsync(Guid id)
        {
            return context.Users.AnyAsync(user => user.Id == id);
        }
    }
}
