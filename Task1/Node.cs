﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
   public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> NextNode { get; set; }

        public Node(T value)
        {
            this.Value = value;
            this.NextNode = null;
        }
    }
}
