using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithDataStructures
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private TreeNode<T> _root;

        //return a TreeNode by searching for a value
        public TreeNode<T> Get(T value)
        {
            return _root?.Get(value); //? = if _root is not null
        }

        public T Min()
        {
            if (_root == null)
            {
                throw new InvalidOperationException(message: "Tree is empty");
            }
            return _root.Min();
        }

        public T Max()
        {
            if (_root == null)
            {
                throw new InvalidOperationException(message: "Tree is empty");
            }
            return _root.Max();
        }

        public void Insert(T value)
        {
            if (_root == null) //tree is empty so initialize it
            {
                _root = new TreeNode<T>(value);
            }
            else
            {
                _root.Insert(value);
            }
        }

        public IEnumerable<T> TraverseInOrder()
        {
            if(_root != null)
            {
                return _root.TraverseInOrder();
            }

            return Enumerable.Empty<T>(); //best practice, instead of returning null
        }
    }
}
