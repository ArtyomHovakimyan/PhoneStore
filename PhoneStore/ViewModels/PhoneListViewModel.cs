using PhoneStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneStore.ViewModels
{
    public class PhoneListViewModel
    {
        public IEnumerable<Phone> Phones { get; set; }
        public string CurrentCompany { get; set; }
    }
}
