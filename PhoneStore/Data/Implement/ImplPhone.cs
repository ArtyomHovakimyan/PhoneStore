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
                    ImagesUrl = "http://www.mobilestore.am/uploads/media/products/0001/02/thumb_1580_products_list.png",
                    InS = true,
                    IsPrefPhone = true,
                    ImageUrl = "http://www.mobilestore.am/uploads/media/products/0001/02/thumb_1580_products_list.png"

                },
                new Phone
                {
                    Company = _company.Companies.First(),
                    Price = 470.8M,
                    Description = "Random Descr",
                    FullDescription = "Descr",
                    Title = "Galaxy",
                    ImagesUrl = "http://www.mobilestore.am/uploads/media/products/0001/02/thumb_1580_products_list.png",
                    InS = true,
                    IsPrefPhone = true,
                    ImageUrl = "http://www.mobilestore.am/uploads/media/products/0001/02/thumb_1580_products_list.png"

                }
            };

            }
        }
        public IEnumerable<Phone> PrefPhones
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

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
