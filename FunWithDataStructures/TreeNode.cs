﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithDataStructures
{
    public class TreeNode<T> where T : IComparable<T>
    {
        public T Value { get; private set; }
        public TreeNode<T> Left { get; private set; }
        public TreeNode<T> Right { get; private set; }

        public TreeNode(T value)
        {
            Value = value;
        }

        public void Insert(T newValue)
        {
            int compare = newValue.CompareTo(Value);
            if(compare == 0)
            {
                return;
            }
            if (compare < 0)
            {
                if(Left == null)
                {
                    Left = new TreeNode<T>(newValue);
                }
                else
                {
                    Left.Insert(newValue);
                }
            }
            else
            {
                if(Right == null)
                {
                    Right = new TreeNode<T>(newValue);
                }
                else
                {
                    Right.Insert(newValue);
                }
            }
        }

        public TreeNode<T> Get(T value)
        {
            int compare = value.CompareTo(Value);

            if (compare == 0) //return current node
            {
                return this;
            }

            if (compare < 0)
            {
                if (Left != null) //Recursively going down the tree
                {
                    return Left.Get(value);
                }
            }
            else
            {
                if (Right != null)
                {
                    return Right.Get(value);
                }

            }
            return null; //if value not found
        }

        public IEnumerable<T> TraverseInOrder()
        {
            var list = new List<T>();
            InnerTraverse(list);
            return list;
        }

        private void InnerTraverse(List<T> list)
        {
            if(Left != null)
            {
                Left.InnerTraverse(list);
            }
            list.Add(Value);

            if(Right != null)
            {
                Right.InnerTraverse(list);
            } 
        }
        public T Min() //go down the leftmost node and get value
        {
            if(Left != null)
            {
                return Left.Min();
            }
            return Value;
        }
        public T Max() //go down the rightmost node and get value
        {
            if (Right != null)
            {
                return Right.Max();
            }
            return Value;
        }
    }
}
