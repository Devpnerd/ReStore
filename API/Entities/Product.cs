namespace API.Entities
{
    public class Product{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; } //long is using instead of decimal, as we need it during payment

        public string PictureUrl { get; set; }
        public string Type { get; set; }

        public string Brand { get; set; }
        public int QuantityInStock { get; set; }
    }
}