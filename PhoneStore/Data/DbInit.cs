using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PhoneStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneStore.Data
{
    public class DbInit
    {
        //public static void Seed(IApplicationBuilder applicationBuilder)
        //{
        //    private static Dictionary<string, Company> companies;
        //    public static Dictionary<string, Company> Companies
        //{
        //    get
        //    {
        //        if (companies == null)
        //        {
        //            var compnList = new Company[]
        //            {
        //                    new Company { Name = "Samsung", Address="random address" },
        //                    new Company { Name = "LG", Address="adress" }
        //            };

        //            companies = new Dictionary<string, Company>();

        //            foreach (Company company in compnList)
        //            {
        //                companies.Add(company.Name, company);
        //            }
        //        }

        //        return companies;
        //    }
        //}

        //    PhoneContext context = applicationBuilder.ApplicationServices.GetRequiredService<PhoneContext>();
        //    if(!context.Companies.Any())
        //    {
        //        context.Companies.AddRange(Companies.Select(c=>))
        //    }
    }      
}
