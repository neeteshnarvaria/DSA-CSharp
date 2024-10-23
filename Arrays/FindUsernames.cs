namespace DSA.Arrays;

using System;

class FindUsernames
{
    // Method to perform binary search on a sorted array of usernames
    public static bool BinarySearch(string[] usernames, string usernameToFind)
    {
        int left = 0;
        int right = usernames.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Compare the middle element with the username we're looking for
            int comparison = string.Compare(usernames[mid], usernameToFind, StringComparison.OrdinalIgnoreCase);

            if (comparison == 0)
            {
                return true; // Username found
            }
            else if (comparison < 0)
            {
                left = mid + 1; // Search in the right half
            }
            else
            {
                right = mid - 1; // Search in the left half
            }
        }

        return false; // Username not found
    }

    // Method to insert a new username while maintaining sorted order
    public static string[] InsertUsername(string[] usernames, string newUsername)
    {
        // Create a new array with one additional slot for the new username
        string[] newUsernames = new string[usernames.Length + 1];
        int i = 0;

        // Insert usernames into the new array, maintaining sorted order
        while (i < usernames.Length && string.Compare(usernames[i], newUsername, StringComparison.OrdinalIgnoreCase) < 0)
        {
            newUsernames[i] = usernames[i];
            i++;
        }

        // Insert the new username
        newUsernames[i] = newUsername;

        // Copy the remaining usernames
        while (i < usernames.Length)
        {
            newUsernames[i + 1] = usernames[i];
            i++;
        }

        return newUsernames;
    }

    public static void Run()
    {
        // Example sorted list of usernames
        string[] usernames = { "alice", "bob", "charlie", "dave", "eve" };

        // Search for a username
        string usernameToFind = "Charlie";
        bool found = BinarySearch(usernames, usernameToFind);
        Console.WriteLine($"Username '{usernameToFind}' found: {found}");

        // Insert a new username
        string newUsername = "Frank";
        usernames = InsertUsername(usernames, newUsername);

        // Display updated list of usernames
        Console.WriteLine("Updated list of usernames:");
        foreach (var username in usernames)
        {
            Console.WriteLine(username);
        }
    }
}
