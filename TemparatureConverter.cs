class TemperatureConverter
{
    public void Convert(double c)
    {
        Console.WriteLine($"F: {(c * 9 / 5) + 32}");
        Console.WriteLine($"K: {c + 273.15}");
    }

    public void Convert(double f, bool isFahrenheit)
    {
        double c = (f - 32) * 5 / 9;
        Console.WriteLine($"C: {c}");
        Console.WriteLine($"K: {c + 273.15}");
    }

    public void Convert(double k, char isKelvin)
    {
        double c = k - 273.15;
        Console.WriteLine($"C: {c}");
        Console.WriteLine($"F: {(c * 9 / 5) + 32}");
    }
}