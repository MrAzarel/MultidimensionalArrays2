using System;


class MyArray
{
    public Array array;
    Random rnd = new Random();
    public void arrayConcludion(int[] upperBound, int[] lowerBound, int[] ints, ref int count, ref int c)
    {
        for (int i = lowerBound[c]; i < upperBound[c]; i++)
        {
            if (c < count)
            {
                forArr(upperBound, lowerBound, ints, ref count, ref c);
            }
            else
                Console.WriteLine(array.GetValue(i));
            if (i == upperBound[c] - 1)
                count--;
        }
    }

    public void createMultiArr(int count, int[] upperBound, int[] lowerBound)
    {
        int[] arr = new int[count];
        array = Array.CreateInstance(typeof(int), arr);

    }

    public void forArr(int[] upperBound, int[] lowerBound, int[] ints, ref int count, ref int c)
    {
       for (int i = lowerBound[c]; i < upperBound[c]; i++)
        {
            if (c < count)
            {
                forArr(upperBound, lowerBound, ints, ref count, ref c);
            }
            else
                array.SetValue(i, rnd.Next(1, 100));
            if (i == upperBound[c] - 1)
                count--;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        /*Array array = new Array();
        int[] arr = new int[5];
        array.arrayGenerate(arr, 5);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }*/

        Console.WriteLine("Введите колличество измерений: ");
        int count = Convert.ToInt32(Console.ReadLine());
        int countSave = count;

        int[] upperBound = new int[count];
        int[] lowerBound = new int[count];
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Введите верхнюю границу {0} массива: ", i);
            upperBound[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите нижнюю границу {0} массива: ", i);
            lowerBound[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] ints = new int[count];
        for (int i = 0; i < count; i++)
        {
            ints[i] = 0;
        }
        int c = 0;
        MyArray myArray = new MyArray();
        myArray.forArr(upperBound, lowerBound, ints, ref count, ref c);
        count = countSave;
        c = 0;
        myArray.arrayConcludion(upperBound, lowerBound, ints, ref count, ref c);
    }
}