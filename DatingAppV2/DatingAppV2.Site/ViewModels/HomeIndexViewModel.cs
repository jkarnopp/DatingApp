using DatingAppV2.Entities.Models;

namespace DatingAppV2.Site.ViewModels
{
    public class HomeIndexViewModel : BaseViewModel
    {
        public ApplicationUser User { get; set; }
        public bool IsEmployeeProfileConfigured { get; set; }
        public bool IsCompanyConfigured { get; set; }
    }
}