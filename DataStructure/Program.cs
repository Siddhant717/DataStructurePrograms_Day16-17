using System;

namespace DataStructure
{
    public class Program
    {
        static void Main(string[] args)
        {
            UnorderedList list = new UnorderedList();
            list.addFirst("Sid");
            list.addFirst("Riya");
            list.addFirst("Ajay");
            list.addFirst("Priya");
            list.addFirst("Mohit");
            list.addFirst("Taniya");

            Console.WriteLine("Enter Student Name:");
            string input = Console.ReadLine();

            bool check = list.search(input);

            if (check == true)
            {
                // if input data is present in the list then then that data is removed from the list
                list.remove(input);
            }
            else
            {
                //if input data is not present in the list then that data is added into the list
                list.addFirst(input);
            }

            //Display the data present in the list after the completing the above  operations.
            list.diplayData();
        }
    }
}
