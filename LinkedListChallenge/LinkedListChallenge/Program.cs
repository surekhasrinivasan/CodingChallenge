using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListChallenge
{
    // Definition for singly-linked list:
    public class ListNode<T>
    {
        public T value { get; set; }
        public ListNode<T> next { get; set; }
    
    public static ListNode<int> removeKFromList(ListNode<int> l, int k)
        {
            // if the list is emp
            if (l == null)
                return l;
            else if (l.value == k)
            {
                l = l.next;
            }

            // temproray ListNode variable traverse through the list
            ListNode<int> temp = l;

            while (temp != null && temp.next != null)
            {
                if (temp.next.value == k)
                {
                    temp.next = temp.next.next;
                }
                else
                {
                    temp = temp.next;
                }
            }
            if (temp != null && temp.value == k)
            {
                l = l.next;
            }
            return l;
        }
    }      

    
    /* Given a singly linked list of integers l and an integer k, remove all elements from list l that have a value equal to k
     * For l = [3, 1, 2, 3, 4, 5] and k = 3, the output should be
     * removeKFromList(l, k) = [1, 2, 4, 5];
     * For l = [1, 2, 3, 4, 5, 6, 7] and k = 10, the output should be
     * removeKFromList(l, k) = [1, 2, 3, 4, 5, 6, 7].
     */
    class Program
    {       
        static void Main(string[] args)
        {            
        }
    }
    
}