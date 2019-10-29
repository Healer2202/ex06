using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Pham", "Ngọc", "Duy" };
            Stack myStack = new Stack(3);
            for (int i = 0; i <= array.Length; i++)
            {
                myStack.Put(array[i]);
            }


                for (int i = 0; 1 < array.Length; i++)
                    Console.Write(array[i] + " ");
        }
    }
}
