using PhoneStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneStore.Data.Services
{
    public interface ICompanySeR
    {
        IEnumerable<Company> Companies { get; }

    }
}
