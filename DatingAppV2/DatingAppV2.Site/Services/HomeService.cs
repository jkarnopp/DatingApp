﻿using DatingAppV2.Common.Email;
using DatingAppV2.Data.Repositories;
using DatingAppV2.Entities.Models;
using DatingAppV2.Site.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace DatingAppV2.Site.Services
{
    public interface IHomeService
    {
        HomeIndexViewModel GetIndexView();
    }

    public class HomeService : IHomeService
    {
        private IUnitOfWork _unitOfWork;
        private IEmailService _emailService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeService(IUnitOfWork unitOfWork, IEmailService emailService, IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _emailService = emailService;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        public HomeIndexViewModel GetIndexView()
        {
            var user = GetCurrentUserAsync().Result;
            var homeIndexViewModel = new HomeIndexViewModel();
            if (user != null)
            {
                //homeIndexViewModel.IsCompanyConfigured = user.CompanyId != null;
            }

            return homeIndexViewModel;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
    }
}