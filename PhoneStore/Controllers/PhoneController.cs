using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneStore.Data.Services;
using PhoneStore.ViewModels;

namespace PhoneStore.Controllers
{
    public class PhoneController : Controller
    {
        private readonly ICompanySeR _company;
        private readonly IMobSeR _mob;
        public PhoneController(ICompanySeR companySeR,IMobSeR mobSeR)
        {
            _company = companySeR;
            _mob = mobSeR;
        }
        public IActionResult List()
        {
            ViewBag.Name = "Change this text";
            PhoneListViewModel vm = new PhoneListViewModel();
            vm.Phones = _mob.Phones;
            vm.CurrentCompany = "Samsung";
            return View(vm);
        }
    }
}