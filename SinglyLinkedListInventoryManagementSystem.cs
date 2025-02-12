using System;

class InventoryNode
{
    public int ItemID;        // Unique Item ID
    public string ItemName;   // Name of the Item
    public int Quantity;      // Quantity of the Item
    public double Price;      // Price per Item
    public InventoryNode Next;// Pointer to next item

    // Constructor to initialize item details
    public InventoryNode(int itemId, string itemName, int quantity, double price)
    {
        ItemID = itemId;
        ItemName = itemName;
        Quantity = quantity;
        Price = price;
        Next = null;
    }
}

class InventoryManagement
{
    private InventoryNode head; // First item in the list

    // Add an item at the beginning
    public void AddItemAtBeginning(int itemId, string itemName, int quantity, double price)
    {
        InventoryNode newItem = new InventoryNode(itemId, itemName, quantity, price);
        newItem.Next = head;
        head = newItem;
    }

    // Add an item at the end
    public void AddItemAtEnd(int itemId, string itemName, int quantity, double price)
    {
        InventoryNode newItem = new InventoryNode(itemId, itemName, quantity, price);

        if (head == null)
        {
            head = newItem;
        }
        else
        {
            InventoryNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newItem;
        }
    }

    // Remove an item based on Item ID
    public void RemoveItem(int itemId)
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }

        if (head.ItemID == itemId)
        {
            head = head.Next;
            Console.WriteLine("Item removed successfully.");
            return;
        }

        InventoryNode temp = head;
        InventoryNode prev = null;

        while (temp != null && temp.ItemID != itemId)
        {
            prev = temp;
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Item not found.");
            return;
        }

        prev.Next = temp.Next;
        Console.WriteLine("Item removed successfully.");
    }

    // Update the quantity of an item by Item ID
    public void UpdateQuantity(int itemId, int newQuantity)
    {
        InventoryNode temp = head;
        while (temp != null)
        {
            if (temp.ItemID == itemId)
            {
                temp.Quantity = newQuantity;
                Console.WriteLine("Item quantity updated.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }

    // Search for an item based on Item ID
    public void SearchByItemID(int itemId)
    {
        InventoryNode temp = head;
        while (temp != null)
        {
            if (temp.ItemID == itemId)
            {
                Console.WriteLine("Item Found: ID: " + temp.ItemID + ", Name: " + temp.ItemName + ", Quantity: " + temp.Quantity + ", Price: " + temp.Price);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }

    // Search for an item based on Item Name
    public void SearchByItemName(string itemName)
    {
        InventoryNode temp = head;
        bool found = false;
        while (temp != null)
        {
            if (temp.ItemName.Equals(itemName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Item Found: ID: " + temp.ItemID + ", Quantity: " + temp.Quantity + ", Price: " + temp.Price);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
        {
            Console.WriteLine("Item not found.");
        }
    }

    // Calculate and display total inventory value
    public void CalculateTotalInventoryValue()
    {
        double totalValue = 0;
        InventoryNode temp = head;
        while (temp != null)
        {
            totalValue += temp.Price * temp.Quantity;
            temp = temp.Next;
        }
        Console.WriteLine("Total Inventory Value: " + totalValue);
    }

    // Display all items in the inventory
    public void DisplayAllItems()
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }

        InventoryNode temp = head;
        while (temp != null)
        {
            Console.WriteLine("ID: " + temp.ItemID + ", Name: " + temp.ItemName + ", Quantity: " + temp.Quantity + ", Price: " + temp.Price);
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        InventoryManagement inventory = new InventoryManagement();

        while (true)
        {
            Console.WriteLine("\nInventory Management Menu:");
            Console.WriteLine("1. Add Item at Beginning");
            Console.WriteLine("2. Add Item at End");
            Console.WriteLine("3. Remove Item");
            Console.WriteLine("4. Update Item Quantity");
            Console.WriteLine("5. Search by Item ID");
            Console.WriteLine("6. Search by Item Name");
            Console.WriteLine("7. Calculate Total Inventory Value");
            Console.WriteLine("8. Display All Items");
            Console.WriteLine("9. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            int itemId, quantity;
            double price;
            string itemName;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Item ID: ");
                    itemId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Item Name: ");
                    itemName = Console.ReadLine();
                    Console.Write("Enter Quantity: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Price: ");
                    price = Convert.ToDouble(Console.ReadLine());

                    inventory.AddItemAtBeginning(itemId, itemName, quantity, price);
                    break;

                case 2:
                    Console.Write("Enter Item ID: ");
                    itemId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Item Name: ");
                    itemName = Console.ReadLine();
                    Console.Write("Enter Quantity: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Price: ");
                    price = Convert.ToDouble(Console.ReadLine());

                    inventory.AddItemAtEnd(itemId, itemName, quantity, price);
                    break;

                case 3:
                    Console.Write("Enter Item ID to Remove: ");
                    itemId = Convert.ToInt32(Console.ReadLine());
                    inventory.RemoveItem(itemId);
                    break;

                case 4:
                    Console.Write("Enter Item ID: ");
                    itemId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter New Quantity: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    inventory.UpdateQuantity(itemId, quantity);
                    break;

                case 5:
                    Console.Write("Enter Item ID: ");
                    itemId = Convert.ToInt32(Console.ReadLine());
                    inventory.SearchByItemID(itemId);
                    break;

                case 6:
                    Console.Write("Enter Item Name: ");
                    itemName = Console.ReadLine();
                    inventory.SearchByItemName(itemName);
                    break;

                case 7:
                    inventory.CalculateTotalInventoryValue();
                    break;

                case 8:
                    inventory.DisplayAllItems();
                    break;

                case 9:
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 9.");
                    break;
            }
        }
    }
}
