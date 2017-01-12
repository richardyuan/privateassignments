using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace EntryPoint
{
    class Tree
    {
        List<Vector2> nodeList = new List<Vector2>();
        private Node rootNode = null;
        public Tree(Vector2[] Vector2)
        {
            if (Vector2 != null)
            {
                foreach (Vector2 vectorList in Vector2)
                {
                    Insert(vectorList);
                }
            }
        }

        public static double Euclidean(Vector2 building, Vector2 house)
        {
            double distance = Math.Sqrt(Math.Pow(house.X - building.X, 2) + Math.Pow(house.Y - building.Y, 2));
            return distance;
        }

        public void Insert(Vector2 Vector2)
        {
            Node current = rootNode;
            Node previous = null;
            bool traversable = false;
            bool useLeftSubtree = false;

            while (current != null)
            {
                previous = current;
                if (traversable)
                {
                    if (useLeftSubtree = Vector2.X < current.Vec2.X)
                    {
                        current = current.Left;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
                else
                {
                    if (useLeftSubtree = Vector2.Y < current.Vec2.Y)
                        current = current.Left;
                    else
                        current = current.Right;
                }
                traversable = !traversable;
            }

            if (rootNode == null)
                rootNode = new Node(Vector2);
            else
            {
                if (useLeftSubtree)
                    previous.Left = new Node(Vector2);
                else
                    previous.Right = new Node(Vector2);
            }
        }

        public List<Vector2> TraverseInOrder(Node node, Tuple<Vector2, float> i)
        {
            if (node != null)// Geen nieuwe lijst maken in recursion
            {
                TraverseInOrder(node.Left, i);
                if (InRange(i, node))
                {
                    nodeList.Add(node.Vec2);
                }
                TraverseInOrder(node.Right, i);
                if (InRange(i, node))
                {
                    nodeList.Add(node.Vec2);
                }
            }
            return nodeList;
        }

        public IEnumerable<IEnumerable<Vector2>> Traverse(Tree root, IEnumerable<Tuple<Vector2, float>> housesAndDistances)
        {
            IEnumerable<IEnumerable<Vector2>> specialNodesArr;
            var specialNodes = new List<List<Vector2>>();
            List<Vector2> nodes = new List<Vector2>();
            if (root != null)
            {
                foreach (var item in housesAndDistances)
                {
                    nodes = TraverseInOrder(root.rootNode, item);
                    specialNodes.Add(nodes);
                }
            }
            else
            {
                specialNodesArr = specialNodes.ToArray();
                return specialNodesArr;
            }
            specialNodesArr = specialNodes.ToArray();
            return specialNodesArr;
        }

        public bool InRange(Tuple<Vector2, float> house, Node node)
        {
            double range = Euclidean(node.Vec2, house.Item1);
            if (range < house.Item2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
