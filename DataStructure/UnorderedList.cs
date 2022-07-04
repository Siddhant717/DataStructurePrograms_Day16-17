using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class UnorderedList
    {
        public class Node
        {
            public string data;
            public Node next;
            public Node(string data)
            {
                this.data = data;
            }
        }
        //Head Creation
        private Node head;

        //Createing  Method to add element at last position 
        public bool append(string data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return true;
            }

            Node t = head;
            while (t.next != null)
            {
                t = t.next;
            }
            t.next = n;
            return true;
        }
        //Creating method for add ing element at first postion - add()
        public bool addFirst(string data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return true;
            }
            n.next = head;
            head = n;
            return true;
        }
        // Creating Method to Display the data in lIst
        public void diplayData()
        {
            if (head == null)
            {
                Console.WriteLine("Linkedlist is Empty");
            }
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        // Create method for Removing the latest entered item - pop()
        public string pop()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            Node t = head, p = head;
            while (t.next != null)
            {
                p = t;
                t = t.next;
            }
            string obj = t.data;
            p.next = null;
            return obj;
        }

        // CReating method for getting latest added item - peek()
        public string peek()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }

            Node t = head, p = head;
            while (t.next != null)
            {
                p = t;
                t = t.next;
            }

            string obj = t.data;
            return obj;
        }

        // Creating method for searching - search()
        public bool search(string data)
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            Node t = head;
            while (t != null)
            {
                if (t.data.Equals(data))
                    return true;
                t = t.next;
            }
            return false;
        }
        //Creating method for checking the list is empty or not - IsEmpty()
        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }

            return false;
        }
        //Craeting method for checking the size of the list - size()
        public int size()
        {
            if (head == null)
                return 0;
            Node t = head; int count = 0;
            while (t != null)
            {
                count++;
                t = t.next;
            }
            return count;
        }

        public override string ToString()
        {
            if (head == null)
            {

                return null;
            }
            Node t = head;
            string s = "";
            while (t != null)
            {
                s = s + t.data + " ";
                t = t.next;
            }
            return s;
        }
        //Creating method for getting the index of specified data
        public int index(string data)
        {
            int count = -1;
            if (head == null)
                return -1;
            Node t = head;
            while (t != null)
            {
                count++;
                if (t.data.Equals(data))
                    return count;
                t = t.next;
            }
            return -1;
        }
        //Creating method for inserting the data inthe specified index position
        public bool insert(int ind, string data)
        {
            Node n = new Node(data);
            if (ind == 0)
            {
                n.next = head.next;
                head = n;
                return true;
            }
            Node t = head, pre = null;
            while (ind > 0 && t != null)
            {
                ind--;
                pre = t;
                t = t.next;
            }
            if (ind == 0)
            {
                pre.next = n;
                n.next = t;
                return true;
            }
            else
            {
                Console.WriteLine("Index is not in the specified Range");
                return false;
            }
        }
        
        public bool remove(string data)
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            if (head.next == null)
                head = null;
            Node t = head, pre = null;
            while (t != null)
            {
                if (t.data.Equals(data))
                {
                    pre.next = t.next;
                    return true;
                }
                pre = t;
                t = t.next;
            }
            return false;
        }
    }
}
