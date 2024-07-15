using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Remove_Duplicates
{
    public class Node
    {
        public int DataValue { get; set; }
        public Node NextNode { get; set; }

        public Node(int value)
        {
            DataValue = value;
            NextNode = null;
        }
    }
}