namespace ConsoleApp2.Models
{
    internal class Book:Product
    {
        public Book(string? name, double price, int productId, string? genre): base(name, price, productId)
        {
            Genre = genre;
        }
        public string Genre { get; set; }
    }
}
