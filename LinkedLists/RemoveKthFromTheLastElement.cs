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
	public static void PrintLinkedList(MyLinkedList linkedList)
	{
		var node = linkedList.Head;

		while (node != null)
		{
			Console.Write(node.Data + " -> ");
			node = node.Next;
		}

		Console.Write("null");
		Console.WriteLine();
	}

	public static void RemoveKthToTheLastElement(MyLinkedList linkedList, int k)
	{
		if (k >= linkedList.Count)
		{
			throw new InvalidOperationException("k should be smaller than the size of the linked list.");
		}

		// If say Count = 5 and we want to remove 4th to the last element, we're actually removing 5-4 = 1st element.
		var index = linkedList.Count - k;

		linkedList.Remove(index);
	}
}
