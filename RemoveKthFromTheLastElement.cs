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

public class MyLinkedList
{
public MyLinkedList()
    {
      Head = null;
      Count = 0;
    }
    
    public LinkedListNode Head { get; private set; }
    
    public int Count { get; private set; }
    
    public void Add(LinkedListNode node)
    {
      if (Head == null)
      {
        Head = node;
      }
      else
      {
        var current = Head;
        
        while (current.Next != null)
        {
          current = current.Next;
        }
        
        current.Next = node;
      }
      
      Count++;
    }
    
    public void Remove(int index)
    {
      if (index >= Count)
      {
        throw new InvalidOperationException("The index needs to be smaller than the size of the linked list.");
      }
      
      var current = Head;
      
      for (int i = 0; i < index - 1; i++)
      {
        current = current.Next;
      }
      
      current.Next = current.Next.Next;
      Count--;
    }
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
