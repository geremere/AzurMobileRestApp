using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class ItemList
    {

        
        int[] list;
        internal int number;
        public ItemList(int size,ref Random rnd)
        {

            number = 0;
            list = new int[size];
            Randomize(ref rnd);
            Print();
        }

        private void Randomize(ref Random rnd)
        {
            for (int i = 0; i < list.Length; i++)
            {
                
                list[i] = rnd.Next(1, 101);
                number++;
            }
        }

        private void Print()
        {
            int k = 0;
            foreach (int i in list)
            {
                Console.Write($"array[{k}]= {i},\t");
                k++;
            }
            Console.WriteLine();
        }

        public void AddElement(int newVal)
        {
            if (number==list.Length)
                IncreaseSize();
            list[number] = newVal;
            number++;
            Print();
           
        }

        private void IncreaseSize()
        {
            int[] ar = new int[list.Length * 2];
            for (int i = 0; i < list.Length; i++)
            {
                ar[i] = list[i];
            }
            list = ar;
        }

        public void RemoveFirst(int val)
        {
            bool flag = true;
            for (int i = 0; i < number; i++)
            {
                if (list[i]==val)
                {
                    DeliteFirst(i);
                    Print();
                    flag = false;
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine("NOT exist");
            }
        }

        public void RemoveAll(int val)
        {
            bool flag = true;
            for (int i = 0; i < number; i++)
            {
                if (list[i] == val)
                {
                    DeliteFirst(i);
                    Print();
                    flag = false;
                }
            }
            if (flag)
            {
                Console.WriteLine("NOT exist");
            }
        }

        void DeliteFirst(int i)
        {
            int[] arr = new int[list.Length];
            for (int j = 0; j < i; j++)
            {
                arr[j] = list[j];
            }
            for (int j = i+1; j < list.Length; j++)
            {
                arr[j - 1] = list[j];
            }
            list = arr;
        }
    }
}
