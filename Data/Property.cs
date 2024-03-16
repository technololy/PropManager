using System.ComponentModel.DataAnnotations;

namespace PropManager.Data
{
    public class Property
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Seller { get; set; }
        public string Address { get; set; }
        public DateTime DateUploaded { get; set; } = DateTime.Now;

        public ICollection<PropertyImages> PropertyImages { get; set; }
    }
}
