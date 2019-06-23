using storemodel;

namespace store.services.Areas.HelpPage.Models
{
    internal class product : storemodel.product
    {
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public string ModelName { get; set; }
    }
}