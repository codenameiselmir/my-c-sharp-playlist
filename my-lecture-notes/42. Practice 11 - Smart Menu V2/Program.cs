/*
===========================================================
Practice 11: Smart Menu V2
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================

In this lesson we will learn:

1) How to separate responsibilities using multiple classes
2) How to pass objects between classes (dependency injection)
3) How to build a reusable history tracking system
4) How to use a while loop as a main application loop
5) How to use switch statements for menu navigation
6) How to organize a real-world multi-class C# console application

-----------------------------------------------------------
PART 1 - WHAT IS CLASS SEPARATION (SEPARATION OF CONCERNS)?
-----------------------------------------------------------

When a program grows, putting everything in one class makes it:

✖ Hard to read
✖ Hard to maintain
✖ Hard to extend

So we split responsibilities into separate classes.

Each class has ONE clear job:

➡ Calculator     → handles math operations
➡ ArrayWorkshop  → handles array operations
➡ LuckyNumber    → handles random number generation
➡ HistoryManager → handles saving and showing records
➡ Program        → handles the main menu and flow

This is called: Separation of Concerns.

-----------------------------------------------------------
PART 2 - WHAT IS DEPENDENCY INJECTION?
-----------------------------------------------------------

Some classes need to USE another class to do their job.

Example:

Calculator needs HistoryManager to save results.

Instead of creating a new HistoryManager INSIDE Calculator,
we pass it FROM OUTSIDE.

This is called:

➡ Dependency Injection

How it works:

    HistoryManager historyManager = new HistoryManager();
    Calculator calculator = new Calculator(historyManager);

Now Calculator and HistoryManager share the SAME object.

Any record saved by Calculator goes into the SAME history
that HistoryManager tracks.

This is why history shows ALL operations from ALL classes.

-----------------------------------------------------------
PART 3 - THE HISTORYMANAGER CLASS
-----------------------------------------------------------

HistoryManager has one job: track operation history.

It uses:

✔ A fixed-size string array (100 slots)
✔ A counter to track how many records exist
✔ AddRecord() → to save a new record
✔ ShowHistory() → to display all saved records

Why a fixed array and not a List?

At this stage of learning, we use arrays to practice.
In future lessons, we will use List<T> for dynamic sizing.

Important:

If the array is full (100 records), a warning is shown.
No crash. Just a safe message.

-----------------------------------------------------------
PART 4 - THE APPLICATION LOOP (while true)
-----------------------------------------------------------

The program runs inside a:

    while (true) { ... }

This means:

➡ The menu keeps showing until the user chooses to exit.

Why 'true'?

Because we do NOT know in advance how many times
the user will use the program.

The loop only breaks when the user selects option 5:

    case "5":
        return;   ← exits Main() and ends the program

For all other choices:

    Console.ReadKey();   ← waits for a key press

Then the loop restarts and shows the menu again.

-----------------------------------------------------------
PART 5 - SWITCH STATEMENT FOR MENU NAVIGATION
-----------------------------------------------------------

The main menu uses a switch statement:

    switch (mainOperation)
    {
        case "1": calculator.Run();       break;
        case "2": arrayWorkshop.Run();    break;
        case "3": luckyGenerator.Run();   break;
        case "4": historyManager.ShowHistory(); break;
        case "5": return;
        default:  // invalid input message
    }

Each case calls the Run() method of the relevant class.

Run() is the entry point for each feature.
It handles its own internal menu and logic.

The 'default' case handles invalid inputs gracefully.

-----------------------------------------------------------
PART 6 - THE CALCULATOR CLASS
-----------------------------------------------------------

Calculator handles 11 math operations.

It has:

✔ Run()           → shows the calculator menu
✔ ProcessChoice() → routes to the right method
✔ Private methods → one for each operation

Why private methods?

Each operation (Addition, Subtraction, etc.) is isolated.
This makes the code clean, readable, and easy to extend.

New operations can be added without touching existing code.

Each method:
1) Reads input from the user
2) Performs the calculation
3) Prints the result
4) Saves a record to HistoryManager

-----------------------------------------------------------
PART 7 - THE ARRAYWORKSHOP CLASS
-----------------------------------------------------------

ArrayWorkshop lets the user practice array methods.

It uses:

✔ Array.Sort()    → sorts alphabetically (A to Z)
✔ Array.Reverse() → reverses order
✔ Array.Clear()   → sets elements to default (null)
✔ Array.Resize()  → changes the array size
✔ Array.Exists()  → checks if a condition is true for any element
✔ Array.Find()    → returns the first matching element

Important about Array.Resize():

    Array.Resize(ref students, 8);

The 'ref' keyword is required here.
Resize creates a NEW array and re-assigns the reference.
Without 'ref', the original variable would not update.

Important about Array.Clear():

It does NOT remove elements. It sets them to null (for strings).
That's why we check:

    string.IsNullOrEmpty(s) ? "- [Empty Slot]" : "- " + s

-----------------------------------------------------------
PART 8 - THE LUCKYNUMBERGENERATOR CLASS
-----------------------------------------------------------

This class generates a random number between 1 and 100.

It uses:

    Random rnd = new Random();
    int luckyNumber = rnd.Next(1, 101);

Why 101 and not 100?

Because Random.Next(min, max) is:
➡ Inclusive on the left  (1 is possible)
➡ Exclusive on the right (101 means 100 is the maximum)

The result is saved to history automatically.

-----------------------------------------------------------
PART 9 - PRINTRESULT HELPER METHODS
-----------------------------------------------------------

Calculator has two helper methods:

    PrintResult(double result)
    PrintDetailedResult(string description, double result)

Why two methods?

Some operations (Add, Subtract, Multiply, Divide)
just show "Result: X".

Other operations (Pow, Sqrt, Abs, etc.)
need a label like "Square root of 9: 3".

Helper methods avoid repeating the same
Console.WriteLine("===================") block everywhere.

This follows the DRY principle:

➡ DRY = Don't Repeat Yourself

-----------------------------------------------------------
PART 10 - USER PROFILE (STRING METHODS REVIEW)
-----------------------------------------------------------

At the top of every menu cycle, the user profile is shown:

    fullName.ToUpper()          → all uppercase
    fullName.ToLower()          → all lowercase
    fullName.Replace(" ", "_")  → spaces replaced with _
    fullName.Length             → number of characters

This is a practical review of string manipulation from
earlier lessons, used in a real-world context.

-----------------------------------------------------------
PART 11 - OVERALL PROGRAM FLOW
-----------------------------------------------------------

Program starts
    ↓
User enters full name
    ↓
Objects are created (HistoryManager shared by all)
    ↓
while (true) loop begins
    ↓
Console.Clear() → user profile printed → menu printed
    ↓
User selects an option
    ↓
Matching class.Run() is called
    ↓
Operation runs → result printed → history saved
    ↓
"Press any key..." → ReadKey() → loop restarts
    ↓
(Repeat until option 5 is selected → return)

*/

namespace _42._Practice_11___Smart_Menu_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ---------------------------------------------------
            GET USER NAME
            ---------------------------------------------------

            We collect the full name once at the start.
            It will be displayed at the top of every menu cycle.
            */

            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            /*
            ---------------------------------------------------
            CREATE SHARED HISTORYMANAGER
            ---------------------------------------------------

            One HistoryManager is created here.
            It is PASSED INTO each class that needs it.
            This way all classes share the same history.
            */

            HistoryManager historyManager = new HistoryManager();

            /*
            ---------------------------------------------------
            CREATE FEATURE OBJECTS (DEPENDENCY INJECTION)
            ---------------------------------------------------

            Each class receives historyManager as a parameter.
            This is called Dependency Injection.
            */

            Calculator calculator = new Calculator(historyManager);
            ArrayWorkshop arrayWorkshop = new ArrayWorkshop(historyManager);
            LuckyNumberGenerator luckyGenerator = new LuckyNumberGenerator(historyManager);

            /*
            ---------------------------------------------------
            MAIN APPLICATION LOOP
            ---------------------------------------------------

            while (true) keeps the program running.
            The loop only ends when the user selects option 5.
            */

            while (true)
            {
                Console.Clear();
                PrintUserProfile(fullName);
                PrintMainMenu();

                string mainOperation = Console.ReadLine();

                /*
                ---------------------------------------------------
                MAIN MENU SWITCH
                ---------------------------------------------------

                Each case routes to the correct feature.
                default handles any invalid input safely.
                */

                switch (mainOperation)
                {
                    case "1":
                        calculator.Run();
                        break;
                    case "2":
                        arrayWorkshop.Run();
                        break;
                    case "3":
                        luckyGenerator.Run();
                        break;
                    case "4":
                        historyManager.ShowHistory();
                        break;
                    case "5":
                        Console.WriteLine("\nExiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("\nInvalid option. Please select an option between 1 and 5.");
                        break;
                }

                Console.WriteLine("\nPress any key to return to the Main Menu...");
                Console.ReadKey();
            }
        }

        /*
        ---------------------------------------------------
        HELPER METHOD - PRINT USER PROFILE
        ---------------------------------------------------

        Demonstrates string methods:
        ToUpper(), ToLower(), Replace(), Length

        Called at the top of every menu loop cycle.
        */

        static void PrintUserProfile(string fullName)
        {
            Console.WriteLine("===================");
            Console.WriteLine($"Your name with uppercase: {fullName.ToUpper()}");
            Console.WriteLine($"Your name with lowercase: {fullName.ToLower()}");
            Console.WriteLine($"Your name with underscore: {fullName.Replace(" ", "_")}");
            Console.WriteLine($"Your name length is: {fullName.Length}");
            Console.WriteLine("===================");
            Console.WriteLine();
        }

        /*
        ---------------------------------------------------
        HELPER METHOD - PRINT MAIN MENU
        ---------------------------------------------------

        Displays the 5 options available to the user.
        Kept separate to keep Main() clean and readable.
        */

        static void PrintMainMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Calculator");
            Console.WriteLine("2. Array Operations");
            Console.WriteLine("3. Find Your Lucky Number");
            Console.WriteLine("4. Operation History");
            Console.WriteLine("5. Exit");
            Console.Write("\nEnter your main operation (1-5): ");
        }
    }

    /*
    -------------------------------------------------------
    HISTORYMANAGER CLASS
    -------------------------------------------------------

    Tracks all operations performed by the user.

    Uses a fixed-size array (100 slots).
    Uses a counter (historyCount) to track entries.

    AddRecord()   → saves one string entry
    ShowHistory() → prints all saved entries
    */

    class HistoryManager
    {
        /*
        ---------------------------------------------------
        FIELDS
        ---------------------------------------------------

        history[]    → stores operation strings
        historyCount → tracks how many records exist
        */

        private string[] history = new string[100];
        private int historyCount = 0;

        /*
        ---------------------------------------------------
        ADD RECORD
        ---------------------------------------------------

        Adds a new string to the history array.
        If the array is full, shows a warning instead of crashing.
        */

        public void AddRecord(string record)
        {
            if (historyCount < history.Length)
            {
                history[historyCount] = record;
                historyCount++;
            }
            else
            {
                Console.WriteLine("\n[Warning] History is full! Cannot save this operation.");
            }
        }

        /*
        ---------------------------------------------------
        SHOW HISTORY
        ---------------------------------------------------

        Prints all saved records.
        If no records exist, shows an informative message.
        */

        public void ShowHistory()
        {
            Console.Clear();
            Console.WriteLine("--- Operation History ---");

            if (historyCount == 0)
            {
                Console.WriteLine("\nNo operations found in history yet.");
                return;
            }

            Console.WriteLine("\nYour previous operations:");
            for (int i = 0; i < historyCount; i++)
            {
                Console.WriteLine("- " + history[i]);
            }
        }
    }

    /*
    -------------------------------------------------------
    LUCKYNUMBERGENERATOR CLASS
    -------------------------------------------------------

    Generates a random number between 1 and 100.

    Uses Random.Next(1, 101):
    ➡ 1   is inclusive (can appear)
    ➡ 101 is exclusive (100 is the maximum)
    */

    class LuckyNumberGenerator
    {
        /*
        ---------------------------------------------------
        FIELD - HISTORYMANAGER REFERENCE
        ---------------------------------------------------

        Stored as a field so Run() can use it.
        Received via constructor (Dependency Injection).
        */

        private HistoryManager historyManager;

        public LuckyNumberGenerator(HistoryManager historyManager)
        {
            this.historyManager = historyManager;
        }

        /*
        ---------------------------------------------------
        RUN
        ---------------------------------------------------

        Generates and displays the lucky number.
        Saves the result to history.
        */

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("--- Find Your Lucky Number ---");

            Random rnd = new Random();
            int luckyNumber = rnd.Next(1, 101);

            Console.WriteLine($"\n🍀 Your lucky number is: {luckyNumber} 🍀");
            historyManager.AddRecord($"Generated Lucky Number: {luckyNumber}");
        }
    }

    /*
    -------------------------------------------------------
    ARRAYWORKSHOP CLASS
    -------------------------------------------------------

    Lets the user practice 6 built-in Array methods:

    Sort()    → alphabetical order
    Reverse() → reverse order
    Clear()   → sets elements to null
    Resize()  → changes array size (requires 'ref')
    Exists()  → checks if any element matches a condition
    Find()    → returns first element matching a condition
    */

    class ArrayWorkshop
    {
        /*
        ---------------------------------------------------
        FIELDS
        ---------------------------------------------------

        historyManager → shared history tracker
        students[]     → the array used in all operations
        */

        private HistoryManager historyManager;
        private string[] students;

        public ArrayWorkshop(HistoryManager historyManager)
        {
            this.historyManager = historyManager;
        }

        /*
        ---------------------------------------------------
        RUN
        ---------------------------------------------------

        Collects 5 student names.
        Shows the operation menu.
        Calls ProcessChoice() then PrintCurrentState().
        */

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("--- Advanced Array Methods Workshop ---");

            students = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter student {i + 1} name: ");
                students[i] = Console.ReadLine();
            }

            Console.WriteLine("\n--- Operations ---");
            Console.WriteLine("1. Sort (A-Z)");
            Console.WriteLine("2. Reverse");
            Console.WriteLine("3. Clear (Remove first 2 items)");
            Console.WriteLine("4. Resize (Make list 8 people)");
            Console.WriteLine("5. Exists (Check if a specific name exists)");
            Console.WriteLine("6. Find (Find first name longer than 5 letters)");

            Console.Write("\nSelect operation (1-6): ");
            string arrayChoice = Console.ReadLine();

            ProcessChoice(arrayChoice);
            PrintCurrentState();
        }

        /*
        ---------------------------------------------------
        PROCESS CHOICE
        ---------------------------------------------------

        Routes to the correct array operation.

        Note on Array.Resize():
            Requires 'ref' because it creates a NEW array
            and re-assigns the reference.

        Note on Array.Exists() and Array.Find():
            Use lambda expressions (s => condition)
            to define the search rule inline.
        */

        private void ProcessChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    Array.Sort(students);
                    Console.WriteLine("\n[SUCCESS] Array sorted alphabetically.");
                    historyManager.AddRecord("Array Method: Sort");
                    break;
                case "2":
                    Array.Reverse(students);
                    Console.WriteLine("\n[SUCCESS] Array reversed.");
                    historyManager.AddRecord("Array Method: Reverse");
                    break;
                case "3":
                    Array.Clear(students, 0, 2);
                    Console.WriteLine("\n[SUCCESS] First 2 items cleared.");
                    historyManager.AddRecord("Array Method: Clear");
                    break;
                case "4":
                    Array.Resize(ref students, 8);
                    Console.WriteLine("\n[SUCCESS] Array resized to 8. New empty slots added.");
                    historyManager.AddRecord("Array Method: Resize");
                    break;
                case "5":
                    Console.Write("\nName to check: ");
                    string nameToCheck = Console.ReadLine();
                    bool isExist = Array.Exists(students, s => s == nameToCheck);
                    Console.WriteLine(isExist ? "Yes, exists!" : "No, not found.");
                    historyManager.AddRecord($"Array Method: Exists ({nameToCheck})");
                    break;
                case "6":
                    string found = Array.Find(students, s => s != null && s.Length > 5);
                    Console.WriteLine(found != null ? $"\nFound: {found}" : "\nNo name longer than 5 letters.");
                    historyManager.AddRecord("Array Method: Find");
                    break;
                default:
                    Console.WriteLine("\n[ERROR] Invalid choice!");
                    break;
            }
        }

        /*
        ---------------------------------------------------
        PRINT CURRENT STATE
        ---------------------------------------------------

        Displays the array after the operation.

        string.IsNullOrEmpty() handles:
        ✔ null  → from Array.Clear()
        ✔ ""    → empty strings from unset Resize() slots
        */

        private void PrintCurrentState()
        {
            Console.WriteLine("\n--- CURRENT STATE OF THE ARRAY ---");
            foreach (string s in students)
            {
                Console.WriteLine(string.IsNullOrEmpty(s) ? "- [Empty Slot]" : "- " + s);
            }
        }
    }

    /*
    -------------------------------------------------------
    CALCULATOR CLASS
    -------------------------------------------------------

    Handles 11 math operations:

    Basic:     Addition, Subtraction, Multiplication, Division
    Math lib:  Pow, Sqrt, Abs, Ceiling, Floor, Max, Min

    Structure:
    ✔ Run()           → shows the menu
    ✔ ProcessChoice() → routes to the right private method
    ✔ Private methods → one per operation (DRY principle)
    ✔ PrintResult()   → shared output formatting
    */

    class Calculator
    {
        /*
        ---------------------------------------------------
        FIELD - HISTORYMANAGER REFERENCE
        ---------------------------------------------------
        */

        private HistoryManager historyManager;

        public Calculator(HistoryManager historyManager)
        {
            this.historyManager = historyManager;
        }

        /*
        ---------------------------------------------------
        RUN
        ---------------------------------------------------

        Displays the calculator menu with all 11 options.
        Reads the user's choice and routes via ProcessChoice().
        */

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("--- Calculator Menu ---");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Math.Pow");
            Console.WriteLine("6. Math.Sqrt");
            Console.WriteLine("7. Math.Abs");
            Console.WriteLine("8. Math.Ceiling");
            Console.WriteLine("9. Math.Floor");
            Console.WriteLine("10. Math.Max");
            Console.WriteLine("11. Math.Min");

            Console.Write("\nEnter calculator operation (1-11): ");
            string calcChoice = Console.ReadLine();

            ProcessChoice(calcChoice);
        }

        /*
        ---------------------------------------------------
        PROCESS CHOICE
        ---------------------------------------------------

        Routes to the correct private method.
        Keeps Run() clean and readable.
        */

        private void ProcessChoice(string choice)
        {
            switch (choice)
            {
                case "1": PerformAddition(); break;
                case "2": PerformSubtraction(); break;
                case "3": PerformMultiplication(); break;
                case "4": PerformDivision(); break;
                case "5": PerformMathPow(); break;
                case "6": PerformMathSqrt(); break;
                case "7": PerformMathAbs(); break;
                case "8": PerformMathCeiling(); break;
                case "9": PerformMathFloor(); break;
                case "10": PerformMathMax(); break;
                case "11": PerformMathMin(); break;
                default: Console.WriteLine("Invalid calculator operation."); break;
            }
        }

        /*
        ---------------------------------------------------
        BASIC OPERATIONS
        ---------------------------------------------------

        Addition, Subtraction, Multiplication:
        - Ask how many numbers
        - Fill an int array
        - Compute with a loop
        - Print and save to history

        Division:
        - Uses double[] for decimal precision
        - Checks for division by zero before dividing
        */

        private void PerformAddition()
        {
            Console.Clear();
            Console.WriteLine("--- Calculator (Addition) ---");
            Console.Write("How many numbers do you want to add?: ");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[count];
            Console.WriteLine();
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            PrintResult(total);
            historyManager.AddRecord($"Calculator: Addition, Result: {total}");
        }

        private void PerformSubtraction()
        {
            Console.Clear();
            Console.WriteLine("--- Calculator (Subtraction) ---");
            Console.Write("How many numbers do you want to subtract?: ");
            int subCount = Convert.ToInt32(Console.ReadLine());
            if (subCount < 2)
            {
                Console.WriteLine("You need at least 2 numbers to perform subtraction!");
                return;
            }
            int[] subNumbers = new int[subCount];
            Console.WriteLine();
            for (int i = 0; i < subCount; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                subNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int subResult = subNumbers[0];
            for (int i = 1; i < subCount; i++)
            {
                subResult -= subNumbers[i];
            }
            PrintResult(subResult);
            historyManager.AddRecord($"Calculator: Subtraction, Result: {subResult}");
        }

        private void PerformMultiplication()
        {
            Console.Clear();
            Console.WriteLine("--- Calculator (Multiplication) ---");
            Console.Write("How many numbers do you want to multiply?: ");
            int mulCount = Convert.ToInt32(Console.ReadLine());
            int[] mulNumbers = new int[mulCount];
            Console.WriteLine();
            for (int i = 0; i < mulCount; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                mulNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int mulResult = mulNumbers[0];
            for (int i = 1; i < mulCount; i++)
            {
                mulResult *= mulNumbers[i];
            }
            PrintResult(mulResult);
            historyManager.AddRecord($"Calculator: Multiplication, Result: {mulResult}");
        }

        private void PerformDivision()
        {
            Console.Clear();
            Console.WriteLine("--- Calculator (Division) ---");
            Console.Write("How many numbers do you want to divide?: ");
            int divCount = Convert.ToInt32(Console.ReadLine());
            if (divCount < 2)
            {
                Console.WriteLine("You need at least 2 numbers to perform division!");
                return;
            }
            double[] divNumbers = new double[divCount];
            Console.WriteLine();
            for (int i = 0; i < divCount; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                divNumbers[i] = Convert.ToDouble(Console.ReadLine());
            }
            double divResult = divNumbers[0];
            for (int i = 1; i < divCount; i++)
            {
                if (divNumbers[i] == 0)
                {
                    Console.WriteLine("Error: A number cannot be divided by zero!");
                    return;
                }
                divResult /= divNumbers[i];
            }
            PrintResult(divResult);
            historyManager.AddRecord($"Calculator: Division, Result: {divResult}");
        }

        /*
        ---------------------------------------------------
        MATH LIBRARY OPERATIONS
        ---------------------------------------------------

        Math.Pow(base, exponent)   → raises base to the power
        Math.Sqrt(number)          → square root (no negatives)
        Math.Abs(number)           → removes negative sign
        Math.Ceiling(decimal)      → rounds UP to nearest int
        Math.Floor(decimal)        → rounds DOWN to nearest int
        Math.Max(a, b)             → returns the larger value
        Math.Min(a, b)             → returns the smaller value
        */

        private void PerformMathPow()
        {
            Console.Clear();
            Console.WriteLine("--- Calculator (Math.Pow) ---");
            Console.Write("Enter the base number: ");
            double baseNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the exponent: ");
            double exponent = Convert.ToDouble(Console.ReadLine());
            double powResult = Math.Pow(baseNum, exponent);
            PrintDetailedResult($"{baseNum}^{exponent}", powResult);
            historyManager.AddRecord($"Calculator: Math.Pow, Result: {powResult}");
        }

        private void PerformMathSqrt()
        {
            Console.Clear();
            Console.WriteLine("--- Calculator (Math.Sqrt) ---");
            Console.Write("Enter a number: ");
            double sqrtNum = Convert.ToDouble(Console.ReadLine());
            if (sqrtNum < 0)
            {
                Console.WriteLine("Error: Cannot calculate the square root of a negative number!");
                return;
            }
            double sqrtResult = Math.Sqrt(sqrtNum);
            PrintDetailedResult($"Square root of {sqrtNum}", sqrtResult);
            historyManager.AddRecord($"Calculator: Math.Sqrt, Result: {sqrtResult}");
        }

        private void PerformMathAbs()
        {
            Console.Clear();
            Console.WriteLine("--- Calculator (Math.Abs) ---");
            Console.Write("Enter a number: ");
            double absNum = Convert.ToDouble(Console.ReadLine());
            double absResult = Math.Abs(absNum);
            PrintDetailedResult("Absolute value", absResult);
            historyManager.AddRecord($"Calculator: Math.Abs, Result: {absResult}");
        }

        private void PerformMathCeiling()
        {
            Console.Clear();
            Console.WriteLine("--- Calculator (Math.Ceiling) ---");
            Console.Write("Enter a decimal number: ");
            double ceilNum = Convert.ToDouble(Console.ReadLine());
            double ceilResult = Math.Ceiling(ceilNum);
            PrintDetailedResult("Ceiled value", ceilResult);
            historyManager.AddRecord($"Calculator: Math.Ceiling, Result: {ceilResult}");
        }

        private void PerformMathFloor()
        {
            Console.Clear();
            Console.WriteLine("--- Calculator (Math.Floor) ---");
            Console.Write("Enter a decimal number: ");
            double floorNum = Convert.ToDouble(Console.ReadLine());
            double floorResult = Math.Floor(floorNum);
            PrintDetailedResult("Floored value", floorResult);
            historyManager.AddRecord($"Calculator: Math.Floor, Result: {floorResult}");
        }

        private void PerformMathMax()
        {
            Console.Clear();
            Console.WriteLine("--- Calculator (Math.Max) ---");
            Console.Write("Enter first number: ");
            double max1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double max2 = Convert.ToDouble(Console.ReadLine());
            double maxResult = Math.Max(max1, max2);
            PrintDetailedResult("Maximum value is", maxResult);
            historyManager.AddRecord($"Calculator: Math.Max, Result: {maxResult}");
        }

        private void PerformMathMin()
        {
            Console.Clear();
            Console.WriteLine("--- Calculator (Math.Min) ---");
            Console.Write("Enter first number: ");
            double min1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double min2 = Convert.ToDouble(Console.ReadLine());
            double minResult = Math.Min(min1, min2);
            PrintDetailedResult("Minimum value is", minResult);
            historyManager.AddRecord($"Calculator: Math.Min, Result: {minResult}");
        }

        /*
        ---------------------------------------------------
        HELPER METHODS - PRINT RESULTS (DRY PRINCIPLE)
        ---------------------------------------------------

        PrintResult()         → for basic operations (just a number)
        PrintDetailedResult() → for Math operations (label + number)

        Without these helpers, every method would repeat
        the same Console.WriteLine("===================") lines.

        DRY = Don't Repeat Yourself
        */

        private void PrintResult(double result)
        {
            Console.WriteLine("===================");
            Console.WriteLine($"Result: {result}");
            Console.WriteLine("===================");
        }

        private void PrintDetailedResult(string description, double result)
        {
            Console.WriteLine("===================");
            Console.WriteLine($"{description}: {result}");
            Console.WriteLine("===================");
        }
    }
}