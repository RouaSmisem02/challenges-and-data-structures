namespace Linked_List_Remove_Duplicates
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(20);
            list.Insert(20);
            list.Insert(10);
            list.Insert(5);
            list.Insert(10);
            Console.WriteLine("List before Removing Duplicates:");
            list.PrintList();

            list.DeleteDuplicates();
            Console.WriteLine("List after Removing Duplicates:");
            list.PrintList();
        }
    }
}