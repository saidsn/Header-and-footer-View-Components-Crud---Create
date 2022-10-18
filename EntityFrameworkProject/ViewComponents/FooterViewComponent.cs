using EntityFrameworkProject.Data;
using EntityFrameworkProject.Models;
using EntityFrameworkProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkProject.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {

        private readonly LayoutService _layoutService;
        private readonly AppDbContext _appDbContext;

        public FooterViewComponent(LayoutService layoutService)
        {
            _layoutService = layoutService;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View());
        }


    }
}
