
class MyArray
{
    public Array array;
    public Random rnd = new Random();
    public void concludion(int[] hArr, int count, int place)
    {
        for (int i = array.GetLowerBound(place); i <= array.GetUpperBound(place); i++)
        {
            hArr[place] = i;

            if (place != count - 1)
            {
                if (place == count - 2)
                    Console.WriteLine();
                else
                    Console.WriteLine("\n");
                place++;
                concludion(hArr, count, place);
                place--;
            }
            else Console.Write(array.GetValue(hArr) + " ");
        }
        hArr[place] = 0;
    }

    public void createMultiArr(int[] upperBound, int[] lowerBound)
    {
        array = Array.CreateInstance(typeof(Int32), upperBound, lowerBound);

    }

    public void filling(int[] hArr, int count, int place)
    {
        for (int i = array.GetLowerBound(place); i <= array.GetUpperBound(place); i++)
        {
            hArr[place] = i;
            if (place < count - 1)
            {           
                place++;
                filling(hArr, count, place);
                place--;
            }
            else
                array.SetValue(rnd.Next(1, 100), hArr);
            hArr[place] = 0;
        }
    }
}

class Program
{
    static int Main(string[] args)
    {
        Console.WriteLine("Введите колличество измерений: ");
        int count = Convert.ToInt32(Console.ReadLine());

        if (count <= 0)
        {
            throw new ArgumentException("Array must be greater then zero");
            return 0;
        }

        int[] upperBound = new int[count];
        int[] lowerBound = new int[count];
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Введите верхнюю границу {0} массива: ", i);
            upperBound[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите нижнюю границу {0} массива: ", i);
            lowerBound[i] = Convert.ToInt32(Console.ReadLine());
            if (upperBound[i] < lowerBound[i])
            {
                throw new ArgumentException("Upper bound must be grater than lower bound");
                return 0;
            }
        }

        int[] hArr = new int[count];
        for (int i = 0; i < count; i++)
        {
            hArr[i] = 0;
        }
        int place = 0;
        MyArray myArray = new MyArray();
        myArray.createMultiArr(upperBound, lowerBound);
        myArray.filling(hArr, count, place);
        myArray.concludion(hArr, count, place);
        return 0;
    }
}.CreateInstance(typeof(int), arr);

    }

    public void forArr(int[] upperBound, int[] lowerBound, int[] ints, ref int count, ref int c)
    {
       for (int i = lowerBound[c]; i < upperBound[c]; i++)
        {
            if (c < count-1)
            {
                c++;
                forArr(upperBound, lowerBound, ints, ref count, ref c);
            }
            else
                array.SetValue(rnd.Next(1, 100), i);
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
