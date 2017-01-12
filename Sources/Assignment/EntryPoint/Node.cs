using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace EntryPoint
{
    class Node
    {
        private Vector2 Vector2;
        private Node left;
        private Node right;

        public Node(Vector2 v)
        {
            Vector2 = v;
        }

        public Vector2 Vec2
        {
            get { return Vector2; }
            set { Vector2 = value; }
        }

        public Node Right
        {
            get { return right; }
            set { right = value; }
        }

        public Node Left
        {
            get { return left; }
            set { left = value; }
        }
    }
}