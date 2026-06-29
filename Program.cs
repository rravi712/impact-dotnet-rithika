using System;

//Mini Q3
struct ContactCard
{
    public string Name;
    public string Phone;
}
class Program
{
    static void Main()
    {
        ContactCard[] contacts = new ContactCard[5];

        contacts[0] = new ContactCard { Name = "Ravi", Phone = "111" };
        contacts[1] = new ContactCard { Name = "Anita", Phone = "222" };
        contacts[2] = new ContactCard { Name = "RAHUL", Phone = "333" };
        contacts[3] = new ContactCard { Name = "Meena", Phone = "444" };
        contacts[4] = new ContactCard { Name = "Kiran", Phone = "555" };

        // ✅ Call search
        SearchContact(contacts, "rahul");
    }
    static void SearchContact(ContactCard[] contacts, string searchName)
    {
        searchName = searchName.ToLower();

        foreach (var contact in contacts)
        {
            if (contact.Name.ToLower() == searchName)
            {
                Console.WriteLine($"Found: {contact.Name} - {contact.Phone}");
                return;
            }
        }

        Console.WriteLine("Contact not found");
    }
}

/*
//Mini Q2
using System;
class Program
{
    static void Main()
    {

        TemperatureConverter t = new TemperatureConverter();

        // ✅ Celsius version
        Console.WriteLine("From Celsius:");
        t.Convert(30);   // calls Convert(double c)
        Console.WriteLine();

        // ✅ Fahrenheit version
        Console.WriteLine("From Fahrenheit:");
        t.Convert(86, true);   // calls Convert(double f, bool)
        Console.WriteLine();

        // ✅ Kelvin version
        Console.WriteLine("From Kelvin:");
        t.Convert(300, 'K');   // calls Convert(double k, char)

    }

}
*/

//Mini Q1
/*using System;
using System.Collections.Generic;
using System.Linq; // needed for grouping

class Program
{
    static void Main()
    {
        // ✅ Create products
        List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 50000, Category = Category.Electronics },
            new Product { Name = "Phone", Price = 20000, Category = Category.Electronics },
            new Product { Name = "Shirt", Price = 1000, Category = Category.Clothing },
            new Product { Name = "Rice", Price = 50, Category = Category.Grocery },
            new Product { Name = "Jeans", Price = 2000, Category = Category.Clothing }
        };

        // ✅ Group by category
        var groupedProducts = products.GroupBy(p => p.Category);

        // ✅ Print grouped output
        foreach (var group in groupedProducts)
        {
            Console.WriteLine($"Category: {group.Key}");

            foreach (var product in group)
            {
                Console.WriteLine($"  {product.Name} - ₹{product.Price}");
            }

            Console.WriteLine();
        }
    }
}*/



//Task 1.17
/*// ✅ RECORD
public record Address(string Street, string City, int Pincode);
// ✅ INDEXER CLASS
class Playlist
{
    private string[] songs = new string[3];

    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= songs.Length)
                return "Invalid index";
            return songs[index];
        }
        set
        {
            if (index >= 0 && index < songs.Length)
                songs[index] = value;
        }
    }
}

// ✅ PARTIAL CLASS (single file demo)
public partial class Employee
{
    public string Name { get; set; }

    partial void ShowMessage();

    public void Display()
    {
        Console.WriteLine(Name);
        ShowMessage();
    }
}

public partial class Employee
{
    partial void ShowMessage()
    {
        Console.WriteLine("Hello from partial method");
    }
}




class Program
{
    static void Main()
    {
        // ✅ PARTIAL CLASS
        Employee e = new Employee { Name = "Ravi" };
        e.Display();

        // ✅ RECORD
        var a1 = new Address("Main", "Chennai", 600001);
        var a2 = new Address("Main", "Chennai", 600001);

        Console.WriteLine(a1 == a2); // ✅ TRUE

        var a3 = a1 with { City = "Mumbai" };
        Console.WriteLine(a3);

        // ✅ INDEXER
        Playlist p = new Playlist();
        p[0] = "Song1";
        p[1] = "Song2";

        Console.WriteLine(p[0]);
        Console.WriteLine(p[5]); // invalid index
    }
*/


