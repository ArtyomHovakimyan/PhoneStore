using PhoneStore.Data.Models;
using PhoneStore.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneStore.Data.Implement
{
    public class ImplCompany : ICompanySeR
    {
        public IEnumerable<Company> Companies
        {
            get
            {
                return new List<Company>
                {
                   new Company { Name="Samsung",Address="Random Address", Number="*****-*****"},
                   new Company { Name="Samsung",Address="Random1 Address", Number="*****-#####"}
                };
            }
        }
    }
}
