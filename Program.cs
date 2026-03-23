using System;

public class Node
{
    public int info;
    public Node? Link;

    public Node(int data)
    {
        info = data;
        Link = null;
    }

    public Node(int data, Node? next)
    {
        info = data;
        Link = next;
    }
}

public class SingleLinkedList
{
    private Node? first;

    public SingleLinkedList()
    {
        first = null;
    }


    public void Create1(int[] dates)
    {
        first = null;
        for (int i = 0; i < dates.Length; i++)
        {
            Node p = new Node(dates[i]);
            p.Link = first;
            first = p;
        }
    }

    public void Print()
    {
        Node? p = first;
        while (p != null)
        {
            Console.WriteLine(p.info);
            p = p.Link;
        }
    }
    public void Concat(SingleLinkedList L2)
    {
        if (first == null)
        {
            first = L2.first;
        }
        else if (L2.first != null)
        {
            Node p = first;
            while (p.Link != null)
            {
                p = p.Link;
            }

            p.Link = L2.first;
        }
    }
}

class Program
{
    static void Main()
    {
        SingleLinkedList L1 = new SingleLinkedList();
        L1.Create1(new int[] { 1, 2, 3 });

        SingleLinkedList L2 = new SingleLinkedList();
        L2.Create1(new int[] { 4, 5, 6 });

        Console.WriteLine("Список L1:");
        L1.Print();

        Console.WriteLine("\nСписок L2:");
        L2.Print();

        L1.Concat(L2);

        Console.WriteLine("\nСписок L1 после конкатенации с L2:");
        L1.Print();
    }
}
