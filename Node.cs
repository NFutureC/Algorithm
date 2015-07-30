using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Node
    {
        public Int32 Value { get; set; }
        public Boolean IsVisited { get; set; }
        public Node NextNode { get; set; }
        public override string ToString()
        {
            return string.Format("{0}->{1}", Value, NextNode == null ? "END" : NextNode.Value.ToString());
        }
    }
    public class DoublyLinkedNode
    {
        public Int32 Value { get; set; }
        public DoublyLinkedNode NextNode { get; set; }
        public DoublyLinkedNode PreNode { get; set; }
        public override string ToString()
        {
            return string.Format("{0}<->{1}", Value, NextNode == null ? "END" : NextNode.ToString());
        }
    }
}
