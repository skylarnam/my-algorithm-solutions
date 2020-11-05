public class LinkedListNode
{
	public LinkedListNode(int data)
	{
		Data = data;
		Next = null;
	}

	public int Data { get; set; }

	public LinkedListNode Next { get; set; }
}
  
public static class LinkedListHelpers
{
    public static void DeleteMiddleNode(LinkedListNode n)
    {
        if (n == null || n.Next == null)
        {
            throw new InvalidOperationException("Only a node in the middle of the linked list can be provided.");
        }
      
        n.Data = n.Next.Data;
        n.Next = n.Next.Next;
    }
    
    public static void PrintLinkedList(LinkedListNode n)
    {
        while (n != null)
        {
            Console.Write(n.Data + " -> ");
            n = n.Next;
        }

        Console.Write("null");
        Console.WriteLine();
    }
}
