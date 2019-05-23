using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneStore.Data.Services;

namespace PhoneStore.Controllers
{
    public class PhoneController : Controller
    {
        private readonly ICompanySeR _company;
        private readonly IMobSeR _mob;
        public IActionResult List()
        {
            var phones = _mob.Phones;
            return View(phones);
        }
    }
}