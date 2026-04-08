using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Node
    {
        private int info;
        private Node link;

        public int Info
        {
            get { return info; }
            set { info = value; }
        }

        public Node Link
        {
            get { return link; }
            set { link = value; }
        }
        public Node() { }

        public Node(int info)

        {
            Info = info;
        }
        public Node(int info, Node link)
        {
            Info = info; Link = link;
        }
    }
    public class SingleLinkedList
    {
        private Node first;

        public SingleLinkedList()
        {
            first = null;
        }
        public void CreateFromInput(int[] values)
        {
            first = null;
            if (values.Length == 0) return;

            first = new Node(values[0]);
            Node last = first;

            for (int i = 1; i < values.Length; i++)
            {
                Node p = new Node(values[i]);
                last.Link = p;
                last = p;
            }
        }




        public void InsertFirst(int data)
        {
            Node p = new Node(data);
            p.Link = first;
            first = p;
        }


        public void InsertLast(int data)
        {
            Node p = new Node(data);
            if (first == null)
            {
                first = p;
                return;
            }

            Node current = first;
            while (current.Link != null)
            {
                current = current.Link;
            }
            current.Link = p;
        }

        public bool InsertAtPosition(int data, int position)
        {
            if (position < 1) return false;

            if (position == 1)
            {
                InsertFirst(data);
                return true;
            }

            Node current = first;
            int count = 1;

            while (current != null && count < position - 1)
            {
                current = current.Link;
                count++;
            }

            if (current == null) return false;

            Node p = new Node(data);
            p.Link = current.Link;
            current.Link = p;
            return true;
        }

        public bool DeleteFirst()
        {
            if (first == null) return false;
            first = first.Link;
            return true;
        }


        public bool DeleteLast()
        {
            if (first == null) return false;

            if (first.Link == null)
            {
                first = null;
                return true;
            }

            Node current = first;
            while (current.Link.Link != null)
            {
                current = current.Link;
            }
            current.Link = null;
            return true;
        }

        public bool DeleteAtPosition(int position)
        {
            if (position < 1 || first == null) return false;

            if (position == 1)
            {
                return DeleteFirst();
            }

            Node current = first;
            int count = 1;

            while (current != null && count < position - 1)
            {
                current = current.Link;
                count++;
            }

            if (current == null || current.Link == null) return false;

            current.Link = current.Link.Link;
            return true;
        }
        public void Clear()
        {
            first = null;
        }

        public void MergeSorted(SingleLinkedList L2)
        {
            if (L2.first != null)
            {
                if (first == null)
                {
                    first = L2.first;
                    L2.first = null;
                }
                else
                {
                    Node dummy = new Node();
                    Node tail = dummy;
                    Node p1 = first;
                    Node p2 = L2.first;

                    while (p1 != null && p2 != null)
                    {
                        if (p1.Info < p2.Info)
                        {
                            tail.Link = p1;
                            tail = p1;
                            int val = p1.Info;
                            p1 = p1.Link;

                            while (p1 != null && p1.Info == val)
                                p1 = p1.Link;
                        }
                        else if (p1.Info > p2.Info)
                        {
                            tail.Link = p2;
                            tail = p2;
                            int val = p2.Info;
                            p2 = p2.Link;

                            while (p2 != null && p2.Info == val)
                                p2 = p2.Link;
                        }
                        else 
                        {
                            tail.Link = p1;
                            tail = p1;
                            int val = p1.Info;
                            p1 = p1.Link;
                            p2 = p2.Link;

                            while (p1 != null && p1.Info == val)
                                p1 = p1.Link;
                            while (p2 != null && p2.Info == val)
                                p2 = p2.Link;
                        }
                    }
                    while (p1 != null)
                    {
                        tail.Link = p1;
                        tail = p1;
                        int val = p1.Info;
                        p1 = p1.Link;
                        while (p1 != null && p1.Info == val)
                            p1 = p1.Link;
                    }
                    while (p2 != null)
                    {
                        tail.Link = p2;
                        tail = p2;
                        int val = p2.Info;
                        p2 = p2.Link;
                        while (p2 != null && p2.Info == val)
                            p2 = p2.Link;
                    }  
                    tail.Link = null;
                    first = dummy.Link;
                    L2.first = null; 
                }
            }
        }

        public bool IsEmpty()
        {
            return first == null;
        }


        public bool IsSorted()
        {
            Node p = first;
            while (p != null && p.Link != null)
            {
                if (p.Info > p.Link.Info)
                    return false;
                p = p.Link;
            }
            return true;
        }

        public int[] ToArray()
        {
            if (first == null) return new int[0];

            int count = 0;
            Node p = first;
            while (p != null)
            {
                count++;
                p = p.Link;
            }

            int[] result = new int[count];
            p = first;
            for (int i = 0; i < count; i++)
            {
                result[i] = p.Info;
                p = p.Link;
            }

            return result;
        }
    }
}