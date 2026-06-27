#define TRIAL_VERSION 
using SchoolManagement;
using ModuleA ;
using ModuleB;
using HelpA = ModuleA.Helper;
using HelpB = ModuleB.Helper;

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




        /*
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
        */





    }
}
