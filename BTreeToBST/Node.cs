﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTreeToBST
{
    public class Node
    {
        public int Value;
        public Node Left, Right;

        public Node(int value)
        {
            Value = value;
            Left = Right = null;
        }
    }
}