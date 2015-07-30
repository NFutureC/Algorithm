using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Algorithm
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            // Console.WriteLine(new Fibonacci(100).Value);
            //Console.WriteLine(string.Format("LinkedList has circle?{0}", IsCycleLinkedList(CreateLinkedList()) ? true : false));
            //Console.WriteLine(string.Format("LinkedList has circle?{0}", IsCycleLinkedList(CreateLinkedList2()) ? true : false));
            //Console.WriteLine(string.Format("LinkedList has circle?{0}", IsCycleLinkedList(CreateLinkedList3()) ? true : false));
            //Console.WriteLine(string.Format("LinkedList has circle?{0}", IsCycleLinkedList(CreateLinkedList4()) ? true : false));
            watch.Stop();
            Console.WriteLine(string.Format("It takes {0} ticks to finish.", watch.ElapsedTicks));
            Console.Read();
        }
        public static DoublyLinkedNode ReverseDoublyLinkedList(DoublyLinkedNode head)
        {
            if (head == null) return null;
            DoublyLinkedNode current = head;
            DoublyLinkedNode temp;
            while(current!=null)
            {
                temp=current.NextNode;
                current.NextNode = current.PreNode;
                current.PreNode = temp;
                head = current;
                current = temp;
            }
            return head;
        }
        public static long Fibonacci(long n)
        {
            //if (n <= 0)
            //    return 0;
            //if (n == 1)
            //    return 1;
            //return new Fibonacci(n - 1).Value + new Fibonacci(n - 2).Value;
            if (n <= 0)
                return 0;
            if (n == 1)
                return 1;
            long fibNMinusOne = 1;
            long fibNMinusTwo = 0;
            long fibN = 0;
            for (int i = 2; i <= n; ++i)
            {
                fibN = fibNMinusOne + fibNMinusTwo;
                fibNMinusTwo = fibNMinusOne;
                fibNMinusOne = fibN;
            }

            return fibN;
        }
        public static bool IsCycleLinkedList(Node head)
        {
            //Node current = root;
            //while (current != null)
            //{
            //    if (current.IsVisited)
            //    {
            //        Console.WriteLine(string.Format("First Cycle Node: {0}", current.ToString()));
            //        return true;
            //    }
            //    current.IsVisited = true;
            //    current = current.NextNode;
            //}
            Node n1 = head;
            var n2 = head;
            do
            {
                if (n1 == null || n2 == null || n2.NextNode == null) break;
                n1 = n1.NextNode;
                n2 = n2.NextNode.NextNode;
            }
            while (n1 != n2);
            if (n1 != null && n2 != null && n1 == n2)
            {
                Console.WriteLine(string.Format("First Cycle Node: {0}", n1.ToString()));
                return true;
            }

            return false;
        }
    }
}
