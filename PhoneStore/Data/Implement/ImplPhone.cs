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
        private readonly ICompanySeR _company = new ImplCompany();
        public IEnumerable<Phone> Phones
        {
            get
            {
                return new List<Phone>
                {
                new Phone
                {
                    Company = _company.Companies.First(),
                    Price = 500M,
                    Description = "Random Descr",
                    FullDescription = "Descr",
                    Title = "GalaxyS",
                    ImagesUrl = "iphone_4.jpg",
                    InS = true,
                    IsPrefPhone = true,
                    ImageUrl = "iphone_4.jpg"

                },
                new Phone
                {
                    Company = _company.Companies.First(),
                    Price = 470.8M,
                    Description = "Random Descr",
                    FullDescription = "Descr",
                    Title = "Galaxy",
                    ImagesUrl = "iphone_2.jpg",
                    InS = true,
                    IsPrefPhone = true,
                    ImageUrl = "iphone_2.jpg"

                }
            };

            }
        }

        public IEnumerable<Phone> PrefPhones => throw new NotImplementedException();

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
