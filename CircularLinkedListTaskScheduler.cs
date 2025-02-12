using System;

class TaskNode
{
    public int TaskID;        // Unique Task ID
    public string TaskName;   // Task Name
    public int Priority;      // Task Priority
    public DateTime DueDate;  // Task Due Date
    public TaskNode Next;     // Pointer to next task

    // Constructor to initialize task details
    public TaskNode(int taskId, string taskName, int priority, DateTime dueDate)
    {
        TaskID = taskId;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}

class TaskScheduler
{
    private TaskNode head;  // First task in the circular list
    private TaskNode current; // Pointer to track the current task

    // Add a task at the beginning
    public void AddTaskAtBeginning(int taskId, string taskName, int priority, DateTime dueDate)
    {
        TaskNode newTask = new TaskNode(taskId, taskName, priority, dueDate);

        if (head == null)
        {
            head = newTask;
            newTask.Next = head; // Circular reference
        }
        else
        {
            TaskNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            newTask.Next = head;
            temp.Next = newTask;
            head = newTask;
        }
    }

    // Add a task at the end
    public void AddTaskAtEnd(int taskId, string taskName, int priority, DateTime dueDate)
    {
        TaskNode newTask = new TaskNode(taskId, taskName, priority, dueDate);

        if (head == null)
        {
            head = newTask;
            newTask.Next = head; // Circular reference
        }
        else
        {
            TaskNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            temp.Next = newTask;
            newTask.Next = head;
        }
    }

    // Remove a task by Task ID
    public void RemoveTask(int taskId)
    {
        if (head == null)
        {
            Console.WriteLine("Task list is empty.");
            return;
        }

        TaskNode temp = head;
        TaskNode prev = null;

        do
        {
            if (temp.TaskID == taskId)
            {
                if (prev != null)
                {
                    prev.Next = temp.Next;
                }
                else
                {
                    TaskNode last = head;
                    while (last.Next != head)
                    {
                        last = last.Next;
                    }
                    head = head.Next;
                    last.Next = head;
                }
                Console.WriteLine("Task removed successfully.");
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("Task not found.");
    }

    // View the current task and move to the next task in the circular list
    public void ViewAndMoveToNextTask()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        if (current == null)
        {
            current = head;
        }

        Console.WriteLine("Current Task: ID: " + current.TaskID + ", Name: " + current.TaskName + ", Priority: " + current.Priority + ", Due Date: " + current.DueDate);
        current = current.Next; // Move to the next task
    }

    // Search for tasks by priority
    public void SearchTaskByPriority(int priority)
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        TaskNode temp = head;
        bool found = false;

        do
        {
            if (temp.Priority == priority)
            {
                Console.WriteLine("ID: " + temp.TaskID + ", Name: " + temp.TaskName + ", Due Date: " + temp.DueDate);
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
        {
            Console.WriteLine("No tasks found with priority " + priority);
        }
    }

    // Display all tasks in the circular list
    public void DisplayAllTasks()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        TaskNode temp = head;
        do
        {
            Console.WriteLine("ID: " + temp.TaskID + ", Name: " + temp.TaskName + ", Priority: " + temp.Priority + ", Due Date: " + temp.DueDate);
            temp = temp.Next;
        } while (temp != head);
    }
}

class Program
{
    static void Main()
    {
        TaskScheduler taskScheduler = new TaskScheduler();

        while (true)
        {
            Console.WriteLine("\nTask Scheduler Menu:");
            Console.WriteLine("1. Add Task at Beginning");
            Console.WriteLine("2. Add Task at End");
            Console.WriteLine("3. Remove Task by Task ID");
            Console.WriteLine("4. View and Move to Next Task");
            Console.WriteLine("5. Search Task by Priority");
            Console.WriteLine("6. Display All Tasks");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            int taskId, priority;
            string taskName;
            DateTime dueDate;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Task ID: ");
                    taskId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Task Name: ");
                    taskName = Console.ReadLine();
                    Console.Write("Enter Priority: ");
                    priority = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Due Date (yyyy-MM-dd): ");
                    dueDate = DateTime.Parse(Console.ReadLine());

                    taskScheduler.AddTaskAtBeginning(taskId, taskName, priority, dueDate);
                    break;

                case 2:
                    Console.Write("Enter Task ID: ");
                    taskId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Task Name: ");
                    taskName = Console.ReadLine();
                    Console.Write("Enter Priority: ");
                    priority = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Due Date (yyyy-MM-dd): ");
                    dueDate = DateTime.Parse(Console.ReadLine());

                    taskScheduler.AddTaskAtEnd(taskId, taskName, priority, dueDate);
                    break;

                case 3:
                    Console.Write("Enter Task ID to Remove: ");
                    taskId = Convert.ToInt32(Console.ReadLine());
                    taskScheduler.RemoveTask(taskId);
                    break;

                case 4:
                    taskScheduler.ViewAndMoveToNextTask();
                    break;

                case 5:
                    Console.Write("Enter Priority to Search: ");
                    priority = Convert.ToInt32(Console.ReadLine());
                    taskScheduler.SearchTaskByPriority(priority);
                    break;

                case 6:
                    taskScheduler.DisplayAllTasks();
                    break;

                case 7:
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 7.");
                    break;
            }
        }
    }
}
