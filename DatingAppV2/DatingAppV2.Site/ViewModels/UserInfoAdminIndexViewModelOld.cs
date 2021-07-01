using DatingAppV2.Entities.Dtos;
using DatingAppV2.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using X.PagedList;

namespace DatingAppV2.Site.ViewModels
{
    public class UserInfoAdminIndexViewModelOld : BaseViewModel
    {
        public PageListActionDto PageListAction { get; set; }
        public IPagedList<UserDto> Users { get; set; }

        public IPagedList<ApplicationUser> ApplicationUsers { get; set; }

        public IEnumerable<UserRole> UserRoles { get; set; }
    }
}