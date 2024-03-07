using ConsoleApp2.Models;

Console.WriteLine("Enter the count: ");
int count = Convert.ToInt32(Console.ReadLine());
Book[] arr = new Book[count];
for (int i = 0; i < count; i++)
{
    Console.WriteLine("Enter name: ");
    string? name = Console.ReadLine();
    Console.WriteLine("Enter Id: ");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter price: ");
    int price = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter genre: ");
    string? genre = Console.ReadLine();
    Book book = new(name, price, id, genre);
    arr[i] = book;
}
