using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using EntryPoint;

namespace EntryPoint
{
    public class Tree
    {
        Node<Vector2> root;
        int cd = 0;

        public Tree()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        public void Insert(Vector2 x)
        {
            root = Insert(x, root, cd);
        }

        private Node<Vector2> Insert(Vector2 x, Node<Vector2> t, int cd)
        {
            if (t == null)
            {
                t = new Node<Vector2>(x);
            }
            else if (x.X < t.Value.X)
            {
                t.left = Insert(x, t.left, (cd + 1) % 2);
            }
            else
            {
                t.right = Insert(x, t.right, (cd + 1) % 2);
            }
            return t;
        }
    }
}