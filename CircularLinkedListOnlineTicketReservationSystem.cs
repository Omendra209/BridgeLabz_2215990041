using System;

class TicketNode
{
    public int TicketID;         // Unique ticket ID
    public string CustomerName;  // Name of the customer
    public string MovieName;     // Name of the movie
    public string SeatNumber;    // Seat number
    public DateTime BookingTime; // Time of booking
    public TicketNode Next;      // Pointer to the next ticket (Circular link)

    // Constructor to initialize a new ticket node
    public TicketNode(int ticketID, string customerName, string movieName, string seatNumber)
    {
        TicketID = ticketID;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = DateTime.Now; // Automatically set booking time
        Next = null;
    }
}

class TicketReservationSystem
{
    private TicketNode head;  // Head node of the circular linked list
    private int ticketCount = 0; // Total booked tickets

    // Add a new ticket at the end of the circular list
    public void AddTicket(string customerName, string movieName, string seatNumber)
    {
        ticketCount++;
        TicketNode newTicket = new TicketNode(ticketCount, customerName, movieName, seatNumber);

        if (head == null)
        {
            head = newTicket;
            head.Next = head; // Circular link to itself
        }
        else
        {
            TicketNode temp = head;
            while (temp.Next != head) // Traverse to the last node
            {
                temp = temp.Next;
            }
            temp.Next = newTicket;
            newTicket.Next = head; // Maintain circular link
        }

        Console.WriteLine("Ticket booked successfully! Ticket ID: " + ticketCount);
    }

    // Remove a ticket by Ticket ID
    public void RemoveTicket(int ticketID)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        TicketNode current = head, prev = null;

        do
        {
            if (current.TicketID == ticketID)
            {
                if (current == head && head.Next == head) // Only one node
                {
                    head = null;
                }
                else if (current == head) // Head node deletion
                {
                    TicketNode last = head;
                    while (last.Next != head)
                    {
                        last = last.Next;
                    }
                    head = head.Next;
                    last.Next = head;
                }
                else // Middle or last node deletion
                {
                    prev.Next = current.Next;
                }

                Console.WriteLine("Ticket ID " + ticketID + " has been cancelled.");
                return;
            }

            prev = current;
            current = current.Next;
        } while (current != head);

        Console.WriteLine("Ticket ID not found.");
    }

    // Display all tickets in the circular list
    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        TicketNode temp = head;
        Console.WriteLine("\nBooked Tickets:");
        do
        {
            Console.WriteLine("Ticket ID: " + temp.TicketID + ", Customer: " + temp.CustomerName +
                              ", Movie: " + temp.MovieName + ", Seat: " + temp.SeatNumber +
                              ", Time: " + temp.BookingTime);
            temp = temp.Next;
        } while (temp != head);
    }

    // Search for a ticket by Customer Name or Movie Name
    public void SearchTicket(string searchQuery)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        TicketNode temp = head;
        bool found = false;

        do
        {
            if (temp.CustomerName.Equals(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                temp.MovieName.Equals(searchQuery, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Ticket ID: " + temp.TicketID + ", Customer: " + temp.CustomerName +
                                  ", Movie: " + temp.MovieName + ", Seat: " + temp.SeatNumber +
                                  ", Time: " + temp.BookingTime);
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
        {
            Console.WriteLine("No tickets found for '" + searchQuery + "'.");
        }
    }

    // Calculate the total number of booked tickets
    public void CountTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        int count = 0;
        TicketNode temp = head;

        do
        {
            count++;
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("Total booked tickets: " + count);
    }
}

class Program
{
    static void Main()
    {
        TicketReservationSystem system = new TicketReservationSystem();

        while (true)
        {
            Console.WriteLine("\nOnline Ticket Reservation System:");
            Console.WriteLine("1. Book a Ticket");
            Console.WriteLine("2. Cancel a Ticket");
            Console.WriteLine("3. View Booked Tickets");
            Console.WriteLine("4. Search Ticket by Customer/Movie Name");
            Console.WriteLine("5. Count Total Booked Tickets");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Customer Name: ");
                    string customerName = Console.ReadLine();
                    Console.Write("Enter Movie Name: ");
                    string movieName = Console.ReadLine();
                    Console.Write("Enter Seat Number: ");
                    string seatNumber = Console.ReadLine();
                    system.AddTicket(customerName, movieName, seatNumber);
                    break;

                case 2:
                    Console.Write("Enter Ticket ID to cancel: ");
                    int ticketID;
                    if (int.TryParse(Console.ReadLine(), out ticketID))
                    {
                        system.RemoveTicket(ticketID);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Ticket ID.");
                    }
                    break;

                case 3:
                    system.DisplayTickets();
                    break;

                case 4:
                    Console.Write("Enter Customer Name or Movie Name: ");
                    string searchQuery = Console.ReadLine();
                    system.SearchTicket(searchQuery);
                    break;

                case 5:
                    system.CountTickets();
                    break;

                case 6:
                    return;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}
