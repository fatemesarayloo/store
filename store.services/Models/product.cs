using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace store.services.Models
{
    public class product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string ModelName { get; set; }
        public string Description { get; set; }
    }
}