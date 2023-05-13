using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DevFreelaDbContext _dbContext;

        public UserRepository(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            var user = await _dbContext.Users.SingleOrDefaultAsync(u => u.Id == id);

            if (user == null)
                return null;

            return user;
        }

        public async Task<int> CreateUser(User user)
        {
            var userCreated = await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return userCreated.Entity.Id;
        }
    }
}