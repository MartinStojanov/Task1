using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            LinkedList<int> numberLinkedList = new LinkedList<int>();
            numberLinkedList.Add(5);
            numberLinkedList.Add(7);
            numberLinkedList.Add(9);
            numberLinkedList.Print();
            Console.WriteLine(numberLinkedList.Contains(10));
            Console.WriteLine(numberLinkedList.Contains(7));
            numberLinkedList.Delete(7);
            Console.WriteLine(numberLinkedList.Contains(7));
            Console.WriteLine("Print after deleted node with value 7");
            numberLinkedList.Print();
            numberLinkedList.Add(20);
            numberLinkedList.Add(25);
            numberLinkedList.Delete(5);
            Console.WriteLine("Print after deleted head node");
            numberLinkedList.Print();

        }
    }
}
