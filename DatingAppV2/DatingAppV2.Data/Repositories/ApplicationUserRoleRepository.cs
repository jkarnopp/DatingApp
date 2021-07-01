using DatingAppV2.Common.Repository;
using DatingAppV2.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppV2.Data.Repositories
{
    public interface IApplicationUserRoleRepository : IRepository<ApplicationUserRole>
    {
    }

    public class ApplicationUserRoleRepository : Repository<ApplicationUserRole>, IApplicationUserRoleRepository
    {
        public ApplicationUserRoleRepository(DbContext db) : base(db)
        {
        }
    }
}