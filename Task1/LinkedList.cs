using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class LinkedList<T>
    {
        private Node<T> head;
        private int count;
        public LinkedList()
        {
            head = null;
            count = 0;
        }
        public void Add(T value)
        {
            Node<T> tmp = new Node<T>(value);

            if(head == null)
            {
                head = tmp;
            }
            else
            {
                Node<T> currentNode = head;
                while(currentNode.NextNode != null)
                {
                    currentNode = currentNode.NextNode;
                }
                currentNode.NextNode = tmp;
                count++;
            }
        }
        public bool Delete(T value)
        {
            if (head == null)
                return false;
            if(head.Value.Equals(value))
            {
                head = head.NextNode;
                count--;
                return true;
            }
            Node<T> previousNode = head;
            Node<T> currentNode = head.NextNode;

            while(currentNode!=null)
            {
                if(currentNode.Value.Equals(value))
                {
                    previousNode.NextNode = currentNode.NextNode;
                    count--;
                    return true;
                }
                previousNode = currentNode;
                currentNode = currentNode.NextNode;
            }
            return false;
        }
        public int Size()
        {
            return count;
        }
        public bool Contains(T value)
        {
            Node<T> tmp = head;
            while (tmp != null)
            {
                if(tmp.Value.Equals(value))
                {
                    return true;
                }
                tmp = tmp.NextNode;
            }
            return false;
        }
        public void Print()
        {
            if (head == null)
                Console.WriteLine("Empty list");
            Node<T> tmp = head;
            while (tmp != null)
            {
                Console.WriteLine(tmp.Value.ToString());
                tmp = tmp.NextNode;
            }
        }

    }
}
