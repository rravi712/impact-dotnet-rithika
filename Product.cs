using System;

public enum Category
{
	Electronics,
	Grocery,
    Clothing
}
public class Product
{
	public string Name { get; set; }
	public double Price { get; set; }
	public Category Category { get; set; }

}
