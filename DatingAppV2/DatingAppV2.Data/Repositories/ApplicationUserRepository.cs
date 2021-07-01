using DatingAppV2.Common.Repository;
using DatingAppV2.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingAppV2.Data.Repositories
{
    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
    }

    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(DbContext db) : base(db)
        {
        }
    }
}