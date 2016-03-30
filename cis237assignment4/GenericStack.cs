using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    public class GenericStack<T>
    {        
        //Node that will 'point' to the first node in the linked list
        public GenericNode<T> Head
        {
            get;
            set;
        }
       
        //Constructor.  Just initialize the properties to null
        public GenericStack()
        {
            Head = null;            
        }

        //This will be to add a new node to the front of the stack
        public void Push(T content)
        {
            //Make a new node
            GenericNode<T> node = new GenericNode<T>();

            //Set the data for the node to the content that was passed in
            node.Data = content;

            //if Head is null, that means that there are no nodes in the linked list.
            //We are about to add the first node
            node.Next = Head;            
            Head = node;  
        }
        public T Pop()
        {
            //Returns the node at the front of the stack
            GenericNode<T> returnNode = Head;
            GenericNode<T> tempNode = Head.Next;
            Head.Next = null;
            Head.Data = default(T);
            Head = tempNode;
            
            //We are going to use a ternary operator to do a smaller version of an if.
            //This could easily be written as a if/else.  Essentially the part in the ()
            //is the test, and the part between the ? and the : is what will happen if true.
            //The part after the : is what will happen when false.
            return (returnNode != null) ? returnNode.Data : default(T);
        }
    }
}
