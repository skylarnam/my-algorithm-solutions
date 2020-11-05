public class LinkedListNode
{
	public LinkedListNode(int data)
	{
		Data = data;
		Next = null;
	}

	public int Data { get; }

	public LinkedListNode Next { get; set; }
}
  
public static class LinkedListHelpers
{
	public static void RemoveDuplicates(LinkedListNode n)
	{
		var hashSet = new HashSet<int>();
		LinkedListNode previous = null;

		while (n != null)
		{
			if (hashSet.Contains(n.Data))
			{
				previous.Next = n.Next;
			}
			else
			{
                hashSet.Add(n.Data);
                previous = n;
            }

            n = n.Next;
        }
    }

    public static void RemoveDuplicatesWithoutBuffer(LinkedListNode n)
    {
        var current = n;
        
        while (current != null)
        {
            var runner = current;
            
            while (runner.Next != null)
            {
                if (runner.Next.Data == current.Data)
                {
                    runner.Next = runner.Next.Next; 
                }
                else
                {
                    runner = runner.Next;
                }
            }
            
            current = current.Next;
        }
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
