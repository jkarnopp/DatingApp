using System;
using System.Collections.Generic;
using System.Text;

namespace DatingAppV2.Entities.Dtos
{
    public class AdminPwResetDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}