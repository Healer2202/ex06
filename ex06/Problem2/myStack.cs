using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{   
    public class Stack
    {
        private int[] Buffer;
        private int Top;

        public Stack(int number)
        {
            Buffer = new int[number];
            Top = -1;
        }
        public void Put(int item)
        {
            Buffer[Top + 1] = item;
            Top++;
        }
        public int Pop()
        {           
            return Buffer[Top];
            Top--;
        }
        public int Peek()
        {
            return Buffer[Top];
        }
        public int Count()
        {
            return Top;
        }
    }
}
