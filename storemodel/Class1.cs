using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storemodel
{
    public class country
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
        public class category
        {
            public int Id { get; set; }
            public string Name { get; set; }

        }

        public class company
        {
            public int Id { get; set; }
            public string PersianName { get; set; }
            public string EnglishName { get; set; }
            public int CountryId { get; set; }

        }

        public class product
        {
            public int Id { get; set; }
            public int CategoryId { get; set; }
            public int BrandId { get; set; }
            public string ModelName { get; set; }
            public string Description { get; set; }
        }
    }


    
