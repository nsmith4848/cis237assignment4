using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    public class GenericQueue<T>
    {
        //Node that will 'point' to the current node we are looking at
        public GenericNode<T> Current
        {
            get;
            set;
        }

        //Node that will 'point' to the first node in the linked list
        public GenericNode<T> Head
        {
            get;
            set;
        }

        //Node that will 'point' to the last node in the linked list
        public GenericNode<T> Tail
        {
            get;
            set;
        }

        //Constructor.  Just initialize the properties to null
        public GenericQueue()
        {
            Head = null;
            Tail = null;
            Current = null;
        }

        //This will be to add a new node to the linked list
        public void Enqueue(T content)
        {
            //Make a new node
            GenericNode<T> node = new GenericNode<T>();

            //Set the data for the node to the content that was passed in
            node.Data = content;

            //if Head is null, that means that there are no nodes in the linked list.
            //We are about to add the first node
            if (Head == null)
            {
                Head = node;
            }

            //This is the case whre there is already at least 1 node in the linked list
            else
            {
                //Take the Tail Node, which is the last one in the list, and set it's Next property
                //Which was null, to the new node we just created.
                Tail.Next = node;
            }
            Tail = node;
        }
        public T Dequeue()
        {            
            //Used to hold the node at the index indicated by the passed in position
            GenericNode<T> returnNode = Head;
            GenericNode<T> tempNode = Head.Next;
            Head.Next = null;
            Head.Data = default(T);
            tempNode = Head;        
            //We are going to use a ternary operator to do a smaller version of an if.
            //This could easily be written as a if/else.  Essentially the part in the ()
            //is the test, and the part between the ? and the : is what will happen if true.
            //The part after the : is what will happen when false.
            return (returnNode != null) ? returnNode.Data : default(T);
        }       
    }
}
