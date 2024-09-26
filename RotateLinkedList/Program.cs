namespace RotateLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a new LinkedList
            LinkedList list = new LinkedList();

            // Adding some nodes to the linked list
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);
            list.Append(6);

            Console.WriteLine("Original List:");
            list.Display(); // Displays the list before rotation

            // Rotate the list by k positions
            int k = 2;
            Console.WriteLine($"\nRotating the list to the left by {k} positions:");
            list.RotateLeft(k);

            // Display the rotated list
            Console.WriteLine("Rotated List:");
            list.Display();

            // Test another rotation
            k = 4;
            Console.WriteLine($"\nRotating the list to the left by {k} positions:");
            list.RotateLeft(k);

            // Display the second rotation result
            Console.WriteLine("Rotated List:");
            list.Display();

            // Pause the console window
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
