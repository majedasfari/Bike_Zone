using System.ComponentModel.DataAnnotations;

namespace Bike_Zone.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }

        public string BuyerName { get; set; }
        public double TotalPrice { get; set; }
        public string? Location { get; set; }

        public ICollection<PurchaseItem>? PurchaseItems { get; set; }
    }
}
