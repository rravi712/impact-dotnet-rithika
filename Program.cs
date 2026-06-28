#define TRIAL_VERSION 
using SchoolManagement;
using ModuleA ;
using ModuleB;
using HelpA = ModuleA.Helper;
using HelpB = ModuleB.Helper;
using System;

struct Point
{
    public int X;
}

class Person
{
    public int Age;
}

enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}


[Flags]
enum FilePermission
{
    Read = 1,
    Write = 2,
    Execute = 4
}

class Program
{
    static void Main(string[] args)
    {

        //Declare 5 variables using correct conventions
        string firstName = "Rithika";
        int studentAge = 24;
        double averageScore= 99.5;
        bool isEnrolled = true;
        char gradeLevel = 'A';

        //PascalCase for types and methods
        void PrintSummary()         
        {
            Console.WriteLine($"{firstName}, age {studentAge}, grade {gradeLevel}");
        }
        PrintSummary();

        // ── Keyword clash demo ──
        //int class = 1;   
        //   CS1001 Identifier expected
        //   CS1002 ; expected
        // 'class' is a reserved keyword; the parser gets confused.

        int @class = 1;   // ✓ @ tells the compiler "treat 'class' as an identifier"
        Console.WriteLine($"class variable value: {@class}");


        //Preprocessor directives 
        Console.WriteLine("App starting...");

        #if TRIAL_VERSION
            Console.WriteLine("Trial mode — 30 days remaining.");
        #else
            Console.WriteLine("Full version — thank you for purchasing!");
        #endif


        // Test it:
        new SchoolManagement.Course("Maths", 4).Describe();
        //Output for above function call "Maths (4 credits)";




        
        //Without using directive -> must write full namespace path
        var student1 = new SchoolManagement.Student();
        student1.Name = "Ravi";
        student1.Greet();

        //With using directive -> can directly use class name
        var student2= new Student();
        student2.Name = "Rithika";
        student2.Greet();

        var moduleA= new ModuleA.Helper();
        moduleA.Greet();

        var moduleB = new ModuleB.Helper();
        moduleB.Greet();

        // Alternatively, use aliases:
       
       
        var HelperA=new HelpA();
        HelperA.Greet();

        var HelperB = new HelpB();
        HelperB.Greet();

        static void ApplyDiscount(double? discount)
        {
            double actual = discount ?? 0.05; // default 5%

            Console.WriteLine($"Applying {actual * 100}% discount");
        }

        
            Console.WriteLine("=== Implicit Conversion (safe widening) ===");

            int i = 42;
            long l = i;      // int → long
            float f = l;     // long → float
            double d = f;    // float → double

            Console.WriteLine($"int: {i}, long: {l}, float: {f}, double: {d}");



            Console.WriteLine("\n=== Explicit Casting (possible data loss) ===");

            double d2 = 3.99;
            int i2 = (int)d2; // truncates decimal

            Console.WriteLine($"double: {d2} → int: {i2} (decimal lost)");



            Console.WriteLine("\n=== 'is' and 'as' (reference types) ===");

            object obj = "hello";

            // using 'is'
            if (obj is string s)
            {
                Console.WriteLine($"'is' success: {s}");
            }

            // using 'as'
            string s2 = obj as string;
            Console.WriteLine($"'as' result: {s2}");



            Console.WriteLine("\n=== Convert (throws if invalid) ===");

            int x = Convert.ToInt32("42"); // valid conversion
            Console.WriteLine($"Convert.ToInt32(\"42\") = {x}");



            Console.WriteLine("\n=== TryParse (safe, no exception) ===");

            bool ok = int.TryParse("abc", out int y);

            Console.WriteLine($"TryParse(\"abc\") success: {ok}");
            Console.WriteLine($"Parsed value: {y}");


            //Copying and modifying two intS
            int a = 5;
            Console.WriteLine($"Value of a: {a}");
            int b = a;//Copying the value of a to b
            Console.WriteLine($"Copying value of a to b: {b}");
            a = 6;//changing value of a after copying to b
            Console.WriteLine("Changing value after copying ");
            Console.WriteLine($"Value of a: {a}");
            Console.WriteLine($"Value of b: {b}");//b remains unchanged

            //Changing two array values
            Console.WriteLine("Changing two array values");
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = arr1;//Copying the reference of arr1 to arr2

            //Changing value of arr2
            arr2[0] = 11;
            Console.WriteLine($"New value of arr2[0]:{arr2[0]}");
            Console.WriteLine($"Reference change of arr1[0]:{arr1[0]}");//arr1 also changes because arr2 is a reference to arr1

            //Value type: Struct
            Point p1 = new Point { X = 5 };
            Point p2 = p1; // Copying the value of p1 to p2

            p2.X = 100;
            Console.WriteLine($"Value of p1.X:{p1.X}");//unchanged because p2 is a copy of p1
            Console.WriteLine($"Value of p1.X:{p2.X}");// changed because p2 is a copy of p1


            //Reference type: Class

            Person person1 = new Person { Age = 30 };
            Person person2 = person1; // same reference

            person2.Age = 50;
            Console.WriteLine($"Value of person1.Age: {person1.Age}"); // 50 (changed)
            Console.WriteLine($"Value of person2.Age: {person2.Age}"); // 50*/



            int number = 6;
            DaysOfWeek day = (DaysOfWeek)number;

            Console.WriteLine(day); // Output: Friday
            Console.WriteLine((int)day); // Output: 5




            FilePermission perms = FilePermission.Read | FilePermission.Write;

            Console.WriteLine(perms); // Read, Write

            bool hasRead = (perms & FilePermission.Read) != 0;
            bool hasExecute = (perms & FilePermission.Execute) != 0;

            Console.WriteLine(hasRead);    // true
            Console.WriteLine(hasExecute); // false




            int? age = null;

            Console.WriteLine(age.HasValue); // false
            Console.WriteLine(age ?? 18);    // 18 (default)

            age = 25;
            Console.WriteLine(age.HasValue); // true
            Console.WriteLine(age.Value);    // 25

            ApplyDiscount(null);
            ApplyDiscount(0.10);









        
    }




}

