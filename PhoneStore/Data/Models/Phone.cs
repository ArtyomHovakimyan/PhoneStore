using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneStore.Data.Models
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FullDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImagesUrl { get; set; }
        public bool IsPrefPhone { get; set; }
        public bool InS { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
