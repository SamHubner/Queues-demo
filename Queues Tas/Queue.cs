using System;
using System.Collections.Generic;
using System.Text;

namespace Queues_Tas
{
    class Queue
    {
        int front;
        int back;
        int count;
        string[] Q;

        public Queue()
        {
            front = 0;back = 0;count = 0;

            Q = new string[8];
        }

        public void add(string x)
        {
            if (count < 8)
            {
                Q[back] = x;

                back = back + 1;
                count = count + 1;
            }
            else
            {
                Console.WriteLine("Queue is full");
            }
        }

        public void pop()
        {
            if (count > 0)
            {
                Q[front] = null;
                front = front + 1;
                count = count - 1;
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }
        }
        public void Print()
        {
            for (int x = 0; x < Q.Length; x = x + 1)
            {
                Console.WriteLine(Q[x]);
            }
        }

        public int size()
        {
            Console.WriteLine(Convert.ToString(count));
            return count;
        }
    }
}
