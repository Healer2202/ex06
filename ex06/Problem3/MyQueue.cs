using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class MyQueue
    {
        private int[] space;
        private int count = 0;
        private int ele;
        private int statue = 0;
        static void Main(string[] args)
        {
        }
        public MyQueue(int number)
        {
            space = new int[number];
        }
        public void Enqueue(int number)
        {
            ele = number;
            space[count] = ele;
            count++;
            statue++;
        }
        public int Dequeue()
        {
            int temp = count;
            count--;
            Console.WriteLine(space[statue - temp]);
            return space[statue - temp];

        }
        public int peek()
        {
            Console.WriteLine(space[statue - count]);
            return space[statue - count];
        }
        public int checkCount()
        {
            Console.WriteLine(count);
            return count;
        }
        public void print()
        {
            for (int i = 0; i < space.Length; i++)
            {
                Console.Write(space[i]);
            }
        }
    }
}
