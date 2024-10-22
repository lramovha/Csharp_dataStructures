using System;

public class LinkedList
{
    private Node head; // Reference to the head of the list

    // Private inner class to represent a node in the linked list
    private class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null; // Initialize next as null
        }
    }

    // Insert a new node at the head of the list
    public void Insert(int data)
    {
        Node newNode = new Node(data);
        newNode.next = head;
        head = newNode;
    }

    // Delete the first occurrence of a given value
    public void Delete(int key)
    {
        Node temp = head, prev = null;

        // If head node itself holds the key to be deleted
        if (temp != null && temp.data == key)
        {
            head = temp.next; // Change head
            return;
        }

        // Search for the key to be deleted, keeping track of the previous node
        while (temp != null && temp.data != key)
        {
            prev = temp;
            temp = temp.next;
        }

        // If the key was not present in the linked list
        if (temp == null) return;

        // Unlink the node from the linked list
        prev.next = temp.next;
    }

    // Traverse and print the list
    public void PrintList()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.data + " ");
            current = current.next;
        }
        Console.WriteLine();
    }

    // Main method for testing the linked list implementation
    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        // Insert elements
        list.Insert(10);
        list.Insert(20);
        list.Insert(30);
        list.Insert(40);

        Console.WriteLine("Linked List after insertion:");
        list.PrintList();

        // Delete an element
        list.Delete(20);

        Console.WriteLine("Linked List after deletion of 20:");
        list.PrintList();
    }
}
