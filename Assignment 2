using System;
using System.Collections.Generic;

class Program
{
    // This is the main dictionary our group will be using.
    // The key is a string, and each key can hold multiple values
    // inside a list. This will allow us to add more values later.
    static Dictionary<string, List<string>> dictionary = new();

    static void Main()
    {
        // This variable keeps the program running until the
        // user chooses option 7 to exit.
        bool running = true;

        // The while loop keeps bringing the user back to the
        // main menu after they finish an action.
        while (running)
        {
            Console.WriteLine("\n===== DICTIONARY MANAGEMENT SYSTEM =====");
            Console.WriteLine("1. Populate Dictionary");
            Console.WriteLine("2. Display Dictionary");
            Console.WriteLine("3. Remove a Key");
            Console.WriteLine("4. Add a New Key and Value");
            Console.WriteLine("5. Add a Value to an Existing Key");
            Console.WriteLine("6. Sort the Keys");
            Console.WriteLine("7. Exit");

            // Ask the user which option they want to perform.
            // The ?? "" handles a null input by using an empty string.
            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine() ?? "";

            // The switch statement checks the user's selection
            // and calls the method that matches their choice.
            switch (choice)
            {
                case "1":
                    // Populate the dictionary with starting entries.
                    PopulateDictionary();
                    break;

                case "2":
                    // Display the keys and values in the dictionary.
                    DisplayDictionary();
                    break;

                case "3":
                    // Remove a specific key and its values.
                    RemoveEntry();
                    break;

                case "4":
                    // Add a completely new key and value.
                    AddEntry();
                    break;

                case "5":
                    // Add another value to a key that already exists.
                    AppendValue();
                    break;

                case "6":
                    // Display the dictionary keys in sorted order.
                    SortDictionary();
                    break;

                case "7":
                    // Change running to false to stop the while loop.
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    // Handle selections that are not on the menu.
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // =====================================================
    // GROUP MEMBER METHODS
    // =====================================================
    // These methods are placeholders for the other members.
    // They allow the program to run while everyone works
    // on their assigned portions of the project.
    //
    // Each member should replace the placeholder message
    // with their working code when their section is ready.
    //
    // All methods can access the shared dictionary above.
    // =====================================================

    // Option 1: Add the starting keys and values.
    static void PopulateDictionary()
    {
        Console.WriteLine("Populate feature coming soon.");
    }

    // Option 2: Use enumeration to display dictionary contents.
    static void DisplayDictionary()
    {
        Console.WriteLine("Display feature coming soon.");
    }

    // Option 3: Ask the user for a key and remove it.
    static void RemoveEntry()
    {
        Console.WriteLine("Remove feature coming soon.");
    }

    // Option 4: Ask for a new key and its starting value.
    static void AddEntry()
    {
        Console.WriteLine("Add feature coming soon.");
    }

    // Option 5: Append a value to an existing key's list.
    static void AppendValue()
    {
        Console.WriteLine("Append feature coming soon.");
    }

    // Option 6: Sort and display the dictionary keys.
    static void SortDictionary()
    {
        Console.WriteLine("Sort feature coming soon.");
    }
}
