using DatingAppV2.Data.Repositories;
using DatingAppV2.Entities.Models;
using DatingAppV2.Site.ViewModels;
using System.Threading.Tasks;

namespace DatingAppV2.Site.Services
{
    public interface ISysConfigService
    {
        Task<SysConfigViewModel> GetIndexViewAsync();

        Task UpdateSysConfig(SysConfig sysConfig);
    }

    public class SysConfigService : ISysConfigService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserResolverService _userResolverService;

        public SysConfigService(IUnitOfWork unitOfWork, IUserResolverService userResolverService)
        {
            _unitOfWork = unitOfWork;

            _userResolverService = userResolverService;
        }

        public async Task<SysConfigViewModel> GetIndexViewAsync()
        {
            var sysConfig = await _unitOfWork.SysConfigRepository.GetSysConfigAsync();

            var pageView = new SysConfigViewModel();
            pageView.SysConfig = sysConfig;
            pageView.Title = "Edit System Configuration";
            return pageView;
        }

        public async Task UpdateSysConfig(SysConfig sysConfig)
        {
            _unitOfWork.SysConfigRepository.Update(sysConfig);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}