using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management.FORMS.Grade
{
    public class updateQueue
    {
        private Node front;
        private Node rear;

        public updateQueue()
        {
            front = null;
            rear = null;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public void Clear()
        {
            front = rear = null; // Set both front and rear to null
        }

        public void Enqueue(object item) // Add an element to the back of the queue
        {
            Node newNode = new Node(item);
            if (IsEmpty())
            {
                front = rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }

        public object Dequeue() // Remove an element from the front of the queue
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty");
            }

            object data = front.Data;
            front = front.Next;
            if (front == null)
            {
                rear = null; // If queue becomes empty after dequeue, reset both front and rear
            }
            return data;
        }

        public object Peek() // Get the element at the front of the queue without removing it
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty");
            }
            return front.Data;
        }


    }
}
