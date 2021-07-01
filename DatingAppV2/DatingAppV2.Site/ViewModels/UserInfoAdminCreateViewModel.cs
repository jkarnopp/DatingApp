using DatingAppV2.Entities.Dtos;
using DatingAppV2.Entities.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppV2.Site.ViewModels
{
    public class UserInfoAdminCreateViewModel : BaseViewModel
    {
        public UserInfoAdminCreateViewModel()
        {
            this.UserInformation = new User();
        }

        public User UserInformation { get; set; }
        public IEnumerable<SelectListItem> Company { get; set; }
        public List<AssignedRoleData> AssignedRoleDatas { get; set; }
    }
}