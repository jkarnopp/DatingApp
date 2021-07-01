using DatingAppV2.Common.Repository;
using DatingAppV2.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingAppV2.Data.Repositories
{
    public interface IUserRoleRepository : IRepository<UserRole>
    {
        //UserInformation GetUserWithRoles(string UserLanId);
    }

    public class UserRoleRepository : Repository<UserRole>, IUserRoleRepository
    {
        //public DbContext context
        //{
        //    get { return db as DbContext; }
        //}

        public UserRoleRepository(DbContext db) : base(db)
        {
        }
    }
}