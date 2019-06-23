using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace store.services.Models
{
    public class company
    {
        public int Id { get; set; }
        public string PersianName { get; set; }
        public string EnglishName { get; set; }
        public int CountryId { get; set; }
    }
}