using DatingAppV2.Common.Repository;
using DatingAppV2.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingAppV2.Data.Repositories
{
    public interface IRoleRepository : IRepository<Role>
    {
        //UserInformation GetUserWithRoles(string UserLanId);
    }

    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        //public DbContext context
        //{
        //    get { return db as DbContext; }
        //}

        public RoleRepository(DbContext db) : base(db)
        {
        }
    }
}