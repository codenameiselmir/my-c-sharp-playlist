/*
===========================================================
Lesson 47 - Multithreading
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
What is Multithreading?

Multithreading allows a program to run multiple operations
at the same time.

Normally, a program runs step by step using a single thread.
This is called the "main thread".

However, some tasks can take time (like downloading data,
reading files, or waiting).

Instead of blocking the main thread,
we can create additional threads to handle those tasks.

Each thread works independently,
allowing the program to be faster and more responsive.
*/

namespace _47._Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            //                     Creating a Thread                
            // ==========================================================

            /*
            In C#, we can create a thread using the Thread class.

            When creating a thread, we pass a method
            that the thread will execute.

            The thread does nothing until we call Start().
            */

            Thread thread1 = new Thread(WriteMessage);
            thread1.Start();

            // ==========================================================
            //                Using Task (Modern Approach)
            // ==========================================================

            /*
            Instead of manually working with Thread,
            we often use Task for simpler and cleaner code.

            Task.Run() runs a method asynchronously
            using the thread pool.

            This is the recommended way in modern C#.
            */

            Task.Run(() => WriteMessage());

            // ==========================================================
            //              Main Thread vs Other Threads
            // ==========================================================

            /*
            Even though we started other threads,
            the main thread continues running.

            This means multiple pieces of code
            are executing at the same time.

            The output may appear mixed,
            because threads do not run in a fixed order.
            */

            Console.WriteLine("Main thread is executing...");

            // ==========================================================
            //            Important Concept: Thread.Sleep
            // ==========================================================

            /*
            Thread.Sleep pauses the current thread
            for a specified amount of time (milliseconds).

            In our example:
                Thread.Sleep(500);

            This creates a delay between each message,
            making it easier to observe the thread behavior.
            */

            // ==========================================================
            //                        Final Summary
            // ==========================================================

            /*
            Multithreading:
            - allows multiple tasks to run at the same time
            - improves performance and responsiveness

            Thread:
            - manually created
            - gives more control

            Task:
            - easier to use
            - recommended for most scenarios

            Important:
            - threads run independently
            - execution order is NOT guaranteed
            */
            
            Console.ReadKey();
        }

        // ==========================================================
        //                    Method Used by Threads
        // ==========================================================

        /*
        This method will be executed by both:
        - Thread
        - Task

        It prints messages with a delay,
        allowing us to observe concurrent execution.
        */

        static void WriteMessage()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Message from thread: " + i);
                Thread.Sleep(500);
            }
        }
    }
}
