using System;

class ProcessNode
{
    public int ProcessID;       // Unique ID for each process
    public int BurstTime;       // Time required for execution
    public int RemainingTime;   // Time left for execution
    public int WaitingTime;     // Waiting time
    public int TurnaroundTime;  // Turnaround time
    public ProcessNode Next;    // Pointer to next process

    // Constructor to initialize process details
    public ProcessNode(int processID, int burstTime)
    {
        ProcessID = processID;
        BurstTime = burstTime;
        RemainingTime = burstTime;
        WaitingTime = 0;
        TurnaroundTime = 0;
        Next = null;
    }
}

class RoundRobinScheduler
{
    private ProcessNode head = null; // Head of circular linked list
    private ProcessNode tail = null; // Tail of circular linked list
    private int timeQuantum;         // Time slice for each process

    // Constructor to set the time quantum
    public RoundRobinScheduler(int timeQuantum)
    {
        this.timeQuantum = timeQuantum;
    }

    // Add a new process at the end of the circular list
    public void AddProcess(int processID, int burstTime)
    {
        ProcessNode newProcess = new ProcessNode(processID, burstTime);
        if (head == null)
        {
            head = newProcess;
            tail = newProcess;
            newProcess.Next = head; // Circular link
        }
        else
        {
            tail.Next = newProcess;
            newProcess.Next = head;
            tail = newProcess;
        }
    }

    // Remove a process after execution
    private void RemoveProcess(ProcessNode process)
    {
        if (head == null)
            return;

        ProcessNode temp = head, prev = null;

        // If head is the process to be removed
        if (head == process)
        {
            if (head == tail) // If only one process is left
                head = tail = null;
            else
            {
                tail.Next = head.Next;
                head = head.Next;
            }
            return;
        }

        // Find the process in the list
        do
        {
            prev = temp;
            temp = temp.Next;
        } while (temp != head && temp != process);

        if (temp == process)
        {
            prev.Next = temp.Next;
            if (temp == tail)
                tail = prev;
        }
    }

    // Simulate the Round Robin Scheduling Algorithm
    public void ExecuteScheduling()
    {
        if (head == null)
        {
            Console.WriteLine("No processes in the queue.");
            return;
        }

        int totalTime = 0;
        ProcessNode current = head;

        Console.WriteLine("\nExecuting Round Robin Scheduling:");
        while (head != null)
        {
            Console.WriteLine("\nCurrent Processes in Queue:");
            DisplayProcesses();

            if (current.RemainingTime > timeQuantum)
            {
                totalTime += timeQuantum;
                current.RemainingTime -= timeQuantum;
            }
            else
            {
                totalTime += current.RemainingTime;
                current.WaitingTime = totalTime - current.BurstTime;
                current.TurnaroundTime = totalTime;

                Console.WriteLine("\nProcess " + current.ProcessID + " completed.");
                RemoveProcess(current);
            }

            current = current.Next;
            if (current == null) // If list is empty
                break;
        }

        Console.WriteLine("\nAll processes executed successfully.");
        CalculateAverageTimes();
    }

    // Display all processes in the circular queue
    public void DisplayProcesses()
    {
        if (head == null)
        {
            Console.WriteLine("No processes to display.");
            return;
        }

        ProcessNode temp = head;
        do
        {
            Console.WriteLine("Process " + temp.ProcessID + ": Burst Time = " + temp.BurstTime + ", Remaining Time = " + temp.RemainingTime);
            temp = temp.Next;
        } while (temp != head);
    }

    // Calculate and display average waiting time and turnaround time
    public void CalculateAverageTimes()
    {
        int totalWaitingTime = 0, totalTurnaroundTime = 0, processCount = 0;
        ProcessNode temp = head;

        while (temp != null)
        {
            totalWaitingTime += temp.WaitingTime;
            totalTurnaroundTime += temp.TurnaroundTime;
            processCount++;
            temp = temp.Next;
        }

        if (processCount > 0)
        {
            Console.WriteLine("\nAverage Waiting Time: " + (totalWaitingTime / (double)processCount));
            Console.WriteLine("Average Turnaround Time: " + (totalTurnaroundTime / (double)processCount));
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Time Quantum: ");
        int timeQuantum = Convert.ToInt32(Console.ReadLine());

        RoundRobinScheduler scheduler = new RoundRobinScheduler(timeQuantum);

        while (true)
        {
            Console.WriteLine("\nRound Robin Scheduling Menu:");
            Console.WriteLine("1. Add Process");
            Console.WriteLine("2. Execute Scheduling");
            Console.WriteLine("3. Display Processes");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            int processID, burstTime;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Process ID: ");
                    processID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Burst Time: ");
                    burstTime = Convert.ToInt32(Console.ReadLine());

                    scheduler.AddProcess(processID, burstTime);
                    break;

                case 2:
                    scheduler.ExecuteScheduling();
                    break;

                case 3:
                    scheduler.DisplayProcesses();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}
