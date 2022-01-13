using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
     public class SingleLinkedList
    {
        // entry portal for linkedlist
        private Node start;

        
        public SingleLinkedList()
        {
            start = null;
        }

        //traversal in a linkedlist
        public void Display()
        {
            if(start == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            else
            {
                Node p = start;
                while(p != null)
                {
                    Console.WriteLine(p.info);
                    p = p.link;
                        
                }
            }
        }

        public void CountNode()
        {
            int pos = 0;
            if(start == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            else
            {
                Node p = start;
                while (p != null)
                {
                    pos++;
                    Console.WriteLine(p.info);
                    p = p.link;

                }
            }
            Console.WriteLine("number of Total Node is : {0} ", pos);

        }

        public void SearchNode(int data)
        {
            int pos = 1;
            Node p = start;
            while(p!=null)
            {
                if (p.info == data)
                    break;
                pos++;
                p = p.link;
            }
            if(p==null)
            {
                Console.WriteLine("Not found ");
            }
            else
            {
                Console.WriteLine("found at position : {0} ", pos);
            }
        }

        public Node RefernceToLastNode()
        {
            Node p = start;

            //link becomes null when traversal reaches at last node.
            while(p.link != null)
            {
                p = p.link;
            }
            return p;
        }

        public Node RefernceToSecondLastNode()
        {
            Node p = start;

            //link becomes null when traversal reaches at last node.
            while (p.link.link != null)
            {
                p = p.link;
            }
            return p;
        }

        public Node RefernceToParticularInfo(int x)
        {
            Node p = start;
            while(p.link!=null)
            {
                if(p.info==x)
                {
                    break;
                }
                p = p.link;
            }
            return p;
        }

        public Node RefernceToParticularInfoPredeccsor(int x)
        {
            Node p = start;
            while (p.link != null)
            {
                //here instead of checking p info
                //we are checking the link info so that we can find predeccsor node before we reach at input node
                if (p.link.info == x)
                {
                    break;
                }
                p = p.link;
            }
            return p;
        }
        public Node RefernceToParticularPosition(int x)
        {
            Node p = start;
            int k;
            for (k = 1; k < x && p != null; k++)
                p = p.link;

            return p;
        }

        public void InsertNewNodeAtBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;
        }

        public void InsertAtEnd(int data)
        {
            //crate a node P that will act when we have to traversal to reach at last node
            Node p;

            //node that we have to insert at last
            Node temp = new Node(data);

            //if start is null than its mean that it is our first node so we have to initialise start with this temp node
            if(start==null)
            {
                start = temp;
                return;
            }
            else
            {
                //initialise p to start
                p = start;
                //we are traversal untill last node than give refernce of that last node of temp node.
                while(p.link != null)
                {
                    p = p.link;
                }

                
                p.link = temp;
            }
        }

        public void CreateList()
        {
            int i, n;
            Console.WriteLine("enter number of node You want ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
                return;
            else
            {
                for (i=1;i<=n;i++)
                {
                    Console.WriteLine("enter element to be inserted: ");
                    int data = Convert.ToInt32(Console.ReadLine());
                    InsertAtEnd(data);
                }
            }
        }


        //insert a new node after a node that conatins particular info
        public void InsertAfter(int data,int x)
        {
            Node n = RefernceToParticularInfo(x);
            if (n == null)
            {
                Console.WriteLine(x + " not found ");
            }
            else
            {
                Node temp = new Node(data);
                temp.link = n.link;
                n.link = temp;
            }
        }
        public void InsertBefore(int data,int x)
        {
            Node temp;

            //if list is empty

            if(start == null)
            {
                Console.WriteLine("list is empty ");
                return;
            }

            //if x is first node than we have to provide the info of temp to start

            if(start.info == x)
            {
                temp = new Node(data);

                // providin the link of temp to start
                temp.link = start;

                // initialize start with temp
                start = temp;
            }

            Node n= RefernceToParticularInfoPredeccsor(x);
            if(n.link == null)
            {
                Console.WriteLine("{0} not available in linkedlist ", data);
            }
            else
            {
                temp = new Node(data);
                temp.link = n.link;
                n.link = temp;
            }

        }
        public void InsertAtPosition(int data,int k)
        {
            Node temp;
            int i;

            if(k == 1)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }
            Node p = start;
            for (i = 1; i < k - 1 && p != null; i++)
                p = p.link;
            if (p == null)
            {
                Console.WriteLine("You can only insert upto {0}th position", i);
            }
            else
            {
                temp=new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void DeleteFirstNode()
        {
            if(start==null)
            {
                return;
            }
            start = start.link;
        }

        public void DeleteLastNode()
        {
            if(start==null)
            {
                return;
            }
            if(start.link==null)
            {
                start = null;
                return;
            }
            Node p = start;
            while(p.link.link !=null)
            {
                p = p.link;
            }
            p.link = null;
        }
        public void DeleteNode(int x)
        {
            if(start==null)
            {
                Console.WriteLine("linkedlist is empty");
                return;
            }
            if(start.info==x)
            {
                start = start.link;
                return;
            }
            Node p = start;
            while(p.link != null)
            {
                if(p.link.info==x)
                {
                    break;
                }
                p = p.link;
            }
        }



    }
}
