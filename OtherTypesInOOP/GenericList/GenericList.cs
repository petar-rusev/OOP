using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T> where T : IComparable<T>
    {
        private const int Capacity = 16;
        private static int count = 0;
        private T[] arr = new T[4];
        public GenericList(int lenght = Capacity)
        {
            arr = new T[lenght];
        }
        // promeni
        public void add(T element)
        {

            if (count == arr.Length)
            {
                T[] newArr = new T[arr.Length * 2];
                for (int i = 0; i < count; i++)
                {
                    newArr[i] = arr[i];
                }
                this.arr = newArr;
            }
            arr[count] = element;
            count++;

        }
        public T index(int element)
        {
            return arr[element];
        }
        public void remove(int element)
        {
            T[] newArr = new T[count - 1];
            for (int i = 0; i < count - 1; i++)
            {
                if (i >= element)
                {
                    newArr[i] = arr[i + 1];
                }
                else
                {
                    newArr[i] = arr[i];
                }
            }
            count--;
            this.arr = newArr;
        }
        public void insert(int index, T element)
        {
            if (count == arr.Length)
            {
                T[] newArrr = new T[arr.Length * 2];
                for (int i = 0; i < count; i++)
                {
                    newArrr[i] = arr[i];
                }
                this.arr = newArrr;
            }
            T[] newArr = new T[count + 1];
            for (int i = 0; i < count + 1; i++)
            {
                if (i == index)
                {
                    newArr[i] = element;
                }
                else if (i > index)
                {
                    newArr[i] = arr[i - 1];
                }
                else
                {
                    newArr[i] = arr[i];
                }
            }
            count++;
            this.arr = newArr;
        }
        public void clear()
        {
            T[] newArr = new T[0];
            count = 0;
            this.arr = newArr;
        }

        //proverki
        //-----------------
        public int finde(T value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(value))
                {
                    return i;
                }
            }
            return 00;
        }
        //-------------------
        public string chek(T value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(value))
                {
                    return "yes";
                }
            }
            return "no";
        }
        public void printing()
        {
            foreach (var item in arr)
            {
                Console.Write(item.ToString() + ",");
            }
            Console.WriteLine();
        }
        public void Max()
        {

            if (count < 1)
            {
                throw new InvalidOperationException("The list is empty");
            }

            T max = arr[0];
            for (int i = 1; i < count; i++)
            {
                if (arr[i].CompareTo(max) > 0)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);

        }
        public void Min()
        {

            if (count < 1)
            {
                throw new InvalidOperationException("The list is empty");
            }

            T min = arr[0];
            for (int i = 1; i < count; i++)
            {
                if (arr[i].CompareTo(min) < 0)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(min);

        }

    }
}
