using System;

class Order
{
    public string Status { get; set; }
    public double Amount { get; set; }
}


class Program
{
    static void Main()
    {

        CheckType(10);
        CheckType("hello");
        CheckType(2.5);
        CheckType(null);

        Console.WriteLine(GetGrade(85));

        Order order = new Order { Status = "Completed", Amount = 600 };
        ApplyDiscount(order);


        static void CheckType(object obj)
        {
            if (obj is null)
                Console.WriteLine("It's null");
            else if (obj is int)
                Console.WriteLine("It's an int");
            else if (obj is string)
                Console.WriteLine("It's a string");
            else if (obj is double)
                Console.WriteLine("It's a double");
        }


        static string GetGrade(int marks) =>
                marks switch
                {
                    >= 90 => "A",
                    >= 75 => "B",
                    >= 50 => "C",
                    _ => "Fail"
                };



        static void ApplyDiscount(Order order)
        {
            if (order is { Status: "Completed", Amount: > 500 })
            {
                Console.WriteLine("Discount Applied");
            }
            else
            {
                Console.WriteLine("No Discount");
            }
        }




        // ✅ VAR (compile-time fixed)
        var x = 10;
         //x = "hello"; //❌ COMPILE ERROR

        // ✅ DYNAMIC (runtime flexible)
        dynamic d = "hello";
        Console.WriteLine(d.GetType()); // String

        d = 123;
        Console.WriteLine(d.GetType()); // Int32

        d = true;
        Console.WriteLine(d.GetType()); // Boolean

        // ✅ dynamic method
        Console.WriteLine(Add(5, 10));         // ints
        Console.WriteLine(Add("Hi ", "Ravi")); // strings

        //Task 1.14 
        int[] numbers = { 5, 2, 9, 1 };

        var (min, max) = GetMinMax(numbers);
        Console.WriteLine($"Min: {min}, Max: {max}");

        var (name, age, dept) = GetEmployee();
        Console.WriteLine($"{name}, {age}, {dept}");

        //Task 1.16
        // ✅ Constructor usage
        Student s1 = new Student("Ravi", 25);
        Console.WriteLine(s1.Name);

        Student s2 = new Student(); // chained constructor
        Console.WriteLine(s2.Name);

        // ✅ Validation check
        s1.Age = 2; // should print "Invalid age!"

        // ✅ Method overloading
        Console.WriteLine(s1.CalculateGrade(60));   // Pass
        Console.WriteLine(s1.CalculateGrade(80.5)); // 8.05

        // ✅ const and readonly
        Console.WriteLine(Student.School);
        Console.WriteLine(s1.RollNumber);


    }

    static (int Min, int Max) GetMinMax(int[] nums)
    {
        int min = nums[0];
        int max = nums[0];

        foreach (int n in nums)
        {
            if (n < min) min = n;
            if (n > max) max = n;
        }

        return (min, max);
    }


    static (string Name, int Age, string Department) GetEmployee()
    {
        return ("Ravi", 25, "IT");
    }


    static dynamic Add(dynamic a, dynamic b)
    {
        return a + b;
    }
}

class Student
{
    // ✅ Private field
    private int age;

    // ✅ Property with validation (5–100)
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 5 || value > 100)
                Console.WriteLine("Invalid age!");
            else
                age = value;
        }
    }

    public string Name;

    // ✅ const (cannot change anywhere)
    public const string School = "ABC School";

    // ✅ readonly (can only change in constructor)
    public readonly int RollNumber;

    // ✅ Default constructor (calls another constructor)
    public Student() : this("Unknown", 10)
    {
    }

    // ✅ Parameterized constructor
    public Student(string name, int age)
    {
        Name = name;
        Age = age; // validation happens here
        RollNumber = new Random().Next(1000);
    }

    // ✅ Method overloading
    public string CalculateGrade(int marks)
    {
        return marks >= 50 ? "Pass" : "Fail";
    }

    public double CalculateGrade(double marks)
    {
        return marks * 0.1;
    }
}

