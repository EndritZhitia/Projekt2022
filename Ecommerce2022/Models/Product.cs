namespace Ecommerce2022.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public int Barcode { get; set; }

        public string Country { get; set; }
        public DateTime ProductionDate { get; set; }

        public DateTime ExpirationDate { get; set; }


    }
}
