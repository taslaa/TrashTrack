using Microsoft.EntityFrameworkCore;

using TrashTrack.Core;
using TrashTrack.Infrastructure.Interfaces;

namespace TrashTrack.Infrastructure
{
    public class UsersRepository : BaseRepository<User, int, UserSearchObject>, IUsersRepository
    {
        public UsersRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }

        public async Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(u => u.Email == email, cancellationToken);
        }

        public override Task<PagedList<User>> GetPagedAsync(UserSearchObject searchObject, CancellationToken cancellationToken = default)
        {
            return DbSet
                .Where(u => searchObject.Query == null || (u.FirstName.ToLower().Contains(searchObject.Query.ToLower()) ||
                                                          u.LastName.ToLower().Contains(searchObject.Query.ToLower()) ||
                                                          u.Email.ToLower().Contains(searchObject.Query.ToLower()) ||
                                                          u.PhoneNumber.ToLower().Contains(searchObject.Query.ToLower())))
                .Where(u=>(searchObject.IsVerified == null || u.IsVerified == searchObject.IsVerified) &&
                          (searchObject.IsActive == null || u.IsActive == searchObject.IsActive))
                .ToPagedListAsync(searchObject, cancellationToken);
        }

        public async Task<int> GetCountByRoleAsync(Role role, CancellationToken cancellationToken = default)
        {
            return await DbSet.Where(u => u.Role == role).CountAsync(cancellationToken);
        }
    }
}
