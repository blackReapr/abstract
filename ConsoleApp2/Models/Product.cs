namespace ConsoleApp2.Models
{
    internal class Product
    {
        public Product(string? name, double price, int productId)
        {
            Name = name;
            Price = price;
            ProductId = productId;
        }

        public int ProductId { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        string Detail()
        {
            return $"Name: {Name} Price: {Price}, Count: {Count}";
        }

        void Discount(int discount)
        {
            Price -= Price * (discount / 100);
            Console.WriteLine($"New Price: {Price}");
        }
    }
}
