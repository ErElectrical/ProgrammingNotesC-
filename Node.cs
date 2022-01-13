using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
     public class Node
    {

        //in case of SingleLinkedList Node class
        //only Contains the a info varible and a link varible.
        //info to store value
        //link to store ref of next node.
        public int info;
        public Node link;

        public Node(int i)
        {
            //when constructor is called we provide the input i to info varible.
            info = i;
            //and initially link is null
            link = null;
        }
    }
}
