namespace Bike_Zone.Models
{
    public class PurchaseItem
    {
        public int Id { get; set; }
        public string BikeName { get; set; }
        public int Quantity { get; set; }
        public double UnitCost { get; set; }

        public int PurchaseId { get; set; }
        public Purchase? Purchase { get; set; }
    }
}
