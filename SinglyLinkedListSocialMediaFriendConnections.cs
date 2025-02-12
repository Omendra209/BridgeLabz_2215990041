using System;
using System.Collections.Generic;

class UserNode
{
    public int UserID;               // Unique ID for each user
    public string Name;              // Name of the user
    public int Age;                  // Age of the user
    public List<int> FriendIDs;       // List of friend IDs
    public UserNode Next;             // Pointer to next user in the linked list

    // Constructor to initialize user details
    public UserNode(int userID, string name, int age)
    {
        UserID = userID;
        Name = name;
        Age = age;
        FriendIDs = new List<int>(); // Initialize friend list
        Next = null;
    }
}

class SocialMediaNetwork
{
    private UserNode head = null; // Head of the singly linked list

    // Add a new user to the network
    public void AddUser(int userID, string name, int age)
    {
        UserNode newUser = new UserNode(userID, name, age);
        if (head == null)
        {
            head = newUser;
        }
        else
        {
            UserNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newUser;
        }
    }

    // Find a user by User ID
    private UserNode FindUser(int userID)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.UserID == userID)
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    // Add a friend connection between two users
    public void AddFriend(int userID1, int userID2)
    {
        UserNode user1 = FindUser(userID1);
        UserNode user2 = FindUser(userID2);

        if (user1 != null && user2 != null)
        {
            if (!user1.FriendIDs.Contains(userID2))
                user1.FriendIDs.Add(userID2);
            if (!user2.FriendIDs.Contains(userID1))
                user2.FriendIDs.Add(userID1);

            Console.WriteLine("Friend connection added between " + user1.Name + " and " + user2.Name);
        }
        else
        {
            Console.WriteLine("One or both users not found.");
        }
    }

    // Remove a friend connection
    public void RemoveFriend(int userID1, int userID2)
    {
        UserNode user1 = FindUser(userID1);
        UserNode user2 = FindUser(userID2);

        if (user1 != null && user2 != null)
        {
            user1.FriendIDs.Remove(userID2);
            user2.FriendIDs.Remove(userID1);

            Console.WriteLine("Friend connection removed between " + user1.Name + " and " + user2.Name);
        }
        else
        {
            Console.WriteLine("One or both users not found.");
        }
    }

    // Display all friends of a specific user
    public void DisplayFriends(int userID)
    {
        UserNode user = FindUser(userID);
        if (user != null)
        {
            Console.WriteLine("\nFriends of " + user.Name + ":");
            if (user.FriendIDs.Count == 0)
            {
                Console.WriteLine("No friends found.");
                return;
            }

            foreach (int friendID in user.FriendIDs)
            {
                UserNode friend = FindUser(friendID);
                if (friend != null)
                    Console.WriteLine(friend.Name + " (ID: " + friend.UserID + ")");
            }
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    // Find mutual friends between two users
    public void FindMutualFriends(int userID1, int userID2)
    {
        UserNode user1 = FindUser(userID1);
        UserNode user2 = FindUser(userID2);

        if (user1 != null && user2 != null)
        {
            List<int> mutualFriends = new List<int>();

            foreach (int friendID in user1.FriendIDs)
            {
                if (user2.FriendIDs.Contains(friendID))
                    mutualFriends.Add(friendID);
            }

            Console.WriteLine("\nMutual friends between " + user1.Name + " and " + user2.Name + ":");
            if (mutualFriends.Count == 0)
            {
                Console.WriteLine("No mutual friends found.");
            }
            else
            {
                foreach (int mutualID in mutualFriends)
                {
                    UserNode mutualFriend = FindUser(mutualID);
                    if (mutualFriend != null)
                        Console.WriteLine(mutualFriend.Name + " (ID: " + mutualFriend.UserID + ")");
                }
            }
        }
        else
        {
            Console.WriteLine("One or both users not found.");
        }
    }

    // Search for a user by Name or User ID
    public void SearchUser(string name)
    {
        UserNode temp = head;
        bool found = false;
        while (temp != null)
        {
            if (temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("User found: " + temp.Name + " (ID: " + temp.UserID + ", Age: " + temp.Age + ")");
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("User not found.");
    }

    // Count the number of friends for each user
    public void CountFriends(int userID)
    {
        UserNode user = FindUser(userID);
        if (user != null)
        {
            Console.WriteLine(user.Name + " has " + user.FriendIDs.Count + " friends.");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }
}

class Program
{
    static void Main()
    {
        SocialMediaNetwork network = new SocialMediaNetwork();

        while (true)
        {
            Console.WriteLine("\nSocial Media Friend Connections Menu:");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Add Friend Connection");
            Console.WriteLine("3. Remove Friend Connection");
            Console.WriteLine("4. Display Friends of a User");
            Console.WriteLine("5. Find Mutual Friends");
            Console.WriteLine("6. Search User");
            Console.WriteLine("7. Count Number of Friends");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            int userID, userID1, userID2, age;
            string name;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter User ID: ");
                    userID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    age = Convert.ToInt32(Console.ReadLine());

                    network.AddUser(userID, name, age);
                    break;

                case 2:
                    Console.Write("Enter first User ID: ");
                    userID1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second User ID: ");
                    userID2 = Convert.ToInt32(Console.ReadLine());

                    network.AddFriend(userID1, userID2);
                    break;

                case 3:
                    Console.Write("Enter first User ID: ");
                    userID1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second User ID: ");
                    userID2 = Convert.ToInt32(Console.ReadLine());

                    network.RemoveFriend(userID1, userID2);
                    break;

                case 4:
                    Console.Write("Enter User ID: ");
                    userID = Convert.ToInt32(Console.ReadLine());

                    network.DisplayFriends(userID);
                    break;

                case 5:
                    Console.Write("Enter first User ID: ");
                    userID1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second User ID: ");
                    userID2 = Convert.ToInt32(Console.ReadLine());

                    network.FindMutualFriends(userID1, userID2);
                    break;

                case 6:
                    Console.Write("Enter User Name: ");
                    name = Console.ReadLine();

                    network.SearchUser(name);
                    break;

                case 7:
                    Console.Write("Enter User ID: ");
                    userID = Convert.ToInt32(Console.ReadLine());

                    network.CountFriends(userID);
                    break;

                case 8:
                    return;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}
