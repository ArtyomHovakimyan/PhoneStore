using PhoneStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneStore.Data.Services
{
    public interface IMobSeR
    {
        IEnumerable<Phone> Phones { get; set; }
        IEnumerable<Phone> PrefPhones { get; set; }
        Phone GetPhoneById(int phoneid);
        void AddPhone(Phone phone);
        void DeletePhone(Phone phone);

    }
}
