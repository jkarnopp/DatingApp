using DatingAppV2.Entities.Dtos;
using DatingAppV2.Entities.Models;
using DatingAppV2.Site.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppV2.Site.ViewModels
{
    public class UserInfoAdminEditViewModel : BaseViewModel
    {
        public RegisterUserDto UserInformation { get; set; }

        //public IEnumerable<SelectListItem> Company { get; set; }
        public List<AssignedRoleData> AssignedRoleDatas { get; set; }
    }
}