/*
===========================================================
Practice 9: Student Grading System
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
Tutorial:
In this practice, we build a Student Grading System step by step.

The program allows the user to:
- add students
- store name and surname information
- enter two exam grades
- calculate average grades
- determine pass or fail status
- list all students
- show class average
- show the student with the highest average
- pick a random student
- sort averages in ascending and descending order
*/

using System;

namespace _25._Practice_9___Student_Grading_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1. Defining the Main Variables
            // ==========================================================
            /*
             First, we define the maximum number of students.

             Then we create arrays to store:
             - names
             - surnames
             - exam 1 grades
             - exam 2 grades
             - averages
             - pass / fail status
            */

            int maxStudents = 100;

            string[] names = new string[maxStudents];
            string[] surnames = new string[maxStudents];
            int[] exam1Grades = new int[maxStudents];
            int[] exam2Grades = new int[maxStudents];
            double[] averages = new double[maxStudents];
            string[] statuses = new string[maxStudents];

            /*
             studentCount keeps track of
             how many students are currently stored.

             isRunning controls the main menu loop.

             Random is used later
             for the random student picker feature.
            */

            int studentCount = 0;
            bool isRunning = true;
            Random random = new Random();

            // ==========================================================
            // 2. Starting the Main Program Loop
            // ==========================================================
            /*
             The program continues running
             as long as isRunning is true.

             Inside this loop,
             we display the menu
             and process the user's selection.
            */

            while (isRunning)
            {
                // ======================================================
                // 3. Displaying the Program Title and Menu
                // ======================================================
                /*
                 Here we print a simple title section
                 and show the available options.
                */

                for (int i = 1; i <= 30; i++)
                {
                    Console.Write("=");
                }

                Console.WriteLine();
                Console.WriteLine("Student Grading System");

                for (int i = 1; i <= 30; i++)
                {
                    Console.Write("=");
                }

                Console.WriteLine();
                Console.WriteLine("1. Add Students");
                Console.WriteLine("2. List Students");
                Console.WriteLine("3. Show Class Average");
                Console.WriteLine("4. Show Highest Average");
                Console.WriteLine("5. Random Student Picker");
                Console.WriteLine("6. Show Sorted Averages");
                Console.WriteLine("7. Exit");
                Console.WriteLine();

                // ======================================================
                // 4. Getting a Valid Menu Option
                // ======================================================
                /*
                 We use a while loop with TryParse
                 to make sure the user enters
                 a valid number between 1 and 7.
                */

                int option;

                while (true)
                {
                    Console.Write("Select an option: ");
                    string optionText = Console.ReadLine();

                    if (int.TryParse(optionText, out option) && option >= 1 && option <= 7)
                    {
                        break;
                    }

                    Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
                }

                Console.WriteLine();

                // ======================================================
                // 5. Processing the Selected Menu Option
                // ======================================================
                /*
                 switch checks which menu option
                 the user selected.
                */

                switch (option)
                {
                    case 1:
                        // ==================================================
                        // 6. Adding a New Student
                        // ==================================================
                        /*
                         Before adding a student,
                         we check whether the array is already full.
                        */

                        if (studentCount >= maxStudents)
                        {
                            Console.WriteLine("Student list is full!");
                            break;
                        }

                        /*
                         We ask the user
                         for the student's name and surname.
                        */

                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter student surname: ");
                        string surname = Console.ReadLine();

                        /*
                         We ask for Exam 1 grade.

                         The loop continues until the user enters
                         a valid integer between 0 and 100.
                        */

                        int exam1;

                        while (true)
                        {
                            Console.Write("Enter Exam 1 grade: ");
                            string exam1Text = Console.ReadLine();

                            if (int.TryParse(exam1Text, out exam1) && exam1 >= 0 && exam1 <= 100)
                            {
                                break;
                            }

                            Console.WriteLine("Invalid grade! Please enter a number between 0 and 100.");
                        }

                        /*
                         We do the same validation
                         for Exam 2 grade.
                        */

                        int exam2;

                        while (true)
                        {
                            Console.Write("Enter Exam 2 grade: ");
                            string exam2Text = Console.ReadLine();

                            if (int.TryParse(exam2Text, out exam2) && exam2 >= 0 && exam2 <= 100)
                            {
                                break;
                            }

                            Console.WriteLine("Invalid grade! Please enter a number between 0 and 100.");
                        }

                        /*
                         The average is calculated
                         using both exam grades.

                         Then we determine
                         whether the student passed or failed.
                        */

                        double average = (exam1 + exam2) / 2.0;
                        string status;

                        if (average >= 60)
                        {
                            status = "Passed";
                        }
                        else
                        {
                            status = "Failed";
                        }

                        /*
                         Now we save all student information
                         into the arrays
                         at the current studentCount index.
                        */

                        names[studentCount] = name;
                        surnames[studentCount] = surname;
                        exam1Grades[studentCount] = exam1;
                        exam2Grades[studentCount] = exam2;
                        averages[studentCount] = average;
                        statuses[studentCount] = status;

                        studentCount++;

                        Console.WriteLine("Student added successfully!");
                        break;

                    case 2:
                        // ==================================================
                        // 7. Listing All Students
                        // ==================================================
                        /*
                         If there are no students,
                         we show an informational message.

                         Otherwise,
                         we loop through all stored students
                         and print their details.
                        */

                        if (studentCount == 0)
                        {
                            Console.WriteLine("No students added yet.");
                        }
                        else
                        {
                            Console.WriteLine("Student List:");
                            Console.WriteLine("------------------------------------------------------------------");

                            for (int i = 0; i < studentCount; i++)
                            {
                                Console.WriteLine(
                                    $"{i + 1}. {names[i]} {surnames[i]} - Exam1: {exam1Grades[i]}, Exam2: {exam2Grades[i]}, Average: {averages[i]:F2}, Status: {statuses[i]}"
                                );
                            }
                        }
                        break;

                    case 3:
                        // ==================================================
                        // 8. Showing the Class Average
                        // ==================================================
                        /*
                         To calculate the class average,
                         we sum all student averages
                         and divide by studentCount.
                        */

                        if (studentCount == 0)
                        {
                            Console.WriteLine("No students added yet.");
                        }
                        else
                        {
                            double totalAverage = 0;

                            for (int i = 0; i < studentCount; i++)
                            {
                                totalAverage += averages[i];
                            }

                            double classAverage = totalAverage / studentCount;

                            Console.WriteLine($"Total Students: {studentCount}");
                            Console.WriteLine($"Class Average: {classAverage:F2}");
                        }
                        break;

                    case 4:
                        // ==================================================
                        // 9. Showing the Highest Average
                        // ==================================================
                        /*
                         We assume the first student
                         has the highest average.

                         Then we compare it
                         with the averages of other students.
                        */

                        if (studentCount == 0)
                        {
                            Console.WriteLine("No students added yet.");
                        }
                        else
                        {
                            double highestAverage = averages[0];
                            int highestIndex = 0;

                            for (int i = 1; i < studentCount; i++)
                            {
                                if (averages[i] > highestAverage)
                                {
                                    highestAverage = averages[i];
                                    highestIndex = i;
                                }
                            }

                            Console.WriteLine("Highest Average Student:");
                            Console.WriteLine($"Name: {names[highestIndex]} {surnames[highestIndex]}");
                            Console.WriteLine($"Exam 1: {exam1Grades[highestIndex]}");
                            Console.WriteLine($"Exam 2: {exam2Grades[highestIndex]}");
                            Console.WriteLine($"Average: {averages[highestIndex]:F2}");
                            Console.WriteLine($"Status: {statuses[highestIndex]}");
                        }
                        break;

                    case 5:
                        // ==================================================
                        // 10. Picking a Random Student
                        // ==================================================
                        /*
                         Random.Next(0, studentCount)
                         generates a random valid index.

                         Then we display
                         the selected student's information.
                        */

                        if (studentCount == 0)
                        {
                            Console.WriteLine("No students added yet.");
                        }
                        else
                        {
                            int randomIndex = random.Next(0, studentCount);

                            Console.WriteLine("Random Student Picker:");
                            Console.WriteLine($"Selected Student: {names[randomIndex]} {surnames[randomIndex]}");
                            Console.WriteLine($"Exam 1: {exam1Grades[randomIndex]}");
                            Console.WriteLine($"Exam 2: {exam2Grades[randomIndex]}");
                            Console.WriteLine($"Average: {averages[randomIndex]:F2}");
                            Console.WriteLine($"Status: {statuses[randomIndex]}");
                        }
                        break;

                    case 6:
                        // ==================================================
                        // 11. Sorting the Averages
                        // ==================================================
                        /*
                         We create a new array
                         to copy the averages.

                         This is useful because
                         we do not want to change
                         the original averages array directly.
                        */

                        if (studentCount == 0)
                        {
                            Console.WriteLine("No students added yet.");
                        }
                        else
                        {
                            double[] sortedAverages = new double[studentCount];

                            for (int i = 0; i < studentCount; i++)
                            {
                                sortedAverages[i] = averages[i];
                            }

                            /*
                             Array.Sort() sorts the array
                             in ascending order.
                            */

                            Array.Sort(sortedAverages);

                            Console.WriteLine("Sorted averages (ascending):");

                            foreach (double avg in sortedAverages)
                            {
                                Console.WriteLine(avg.ToString("F2"));
                            }

                            /*
                             Array.Reverse() changes the order
                             from ascending to descending.
                            */

                            Array.Reverse(sortedAverages);

                            Console.WriteLine("Sorted averages (descending):");

                            foreach (double avg in sortedAverages)
                            {
                                Console.WriteLine(avg.ToString("F2"));
                            }
                        }
                        break;

                    case 7:
                        // ==================================================
                        // 12. Exiting the Program
                        // ==================================================
                        /*
                         We change isRunning to false
                         so the main loop stops.
                        */

                        Console.WriteLine("Exiting the program...");
                        isRunning = false;
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}