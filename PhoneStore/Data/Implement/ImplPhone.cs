using PhoneStore.Data.Models;
using PhoneStore.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneStore.Data.Implement
{
    public class ImplPhone : IMobSeR
    {
        public IEnumerable<Phone> Phones { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEnumerable<Phone> PrefPhones { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddPhone(Phone phone)
        {
            throw new NotImplementedException();
        }

        public void DeletePhone(Phone phone)
        {
            throw new NotImplementedException();
        }

        public Phone GetPhoneById(int phoneid)
        {
            throw new NotImplementedException();
        }
    }
}
