int x = 0;
int a = 0;

while (true)
{
    x = 0;
    Console.WriteLine("1. Создать строковый массив");
    Console.WriteLine("2. Создать числовой массив");
    Console.WriteLine("6. Выход");
    
    x = int.Parse(Console.ReadLine());
    switch (x)
    {
        case 1:
            List<string> stringList = new List<string>();
            while (true)
            {
                Console.WriteLine("1. Добавить значение в массив");
                Console.WriteLine("2. Удалить значение из массива");
                Console.WriteLine("3. Показать массив");
                Console.WriteLine("4. Выход");
                
                x = int.Parse(Console.ReadLine());
                
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Введите строку");
                        stringList.Add(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Введите число");
                        stringList.Remove(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine(stringList.ArrayToString());
                        break;
                }
                
                if (x == 4)
                {
                    break;
                }
            }
            
            break;
        case 2:
            List<int> intList = new List<int>();
            while (true)
            {
                x = 0;
                Console.WriteLine("1. Добавить значение в массив");
                Console.WriteLine("2. Удалить значение из массива");
                Console.WriteLine("3. Показать массив");
                Console.WriteLine("4. Выход");

                x = int.Parse(Console.ReadLine());
                
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Введите число");
                        intList.Add(int.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("Введите число");
                        intList.Remove(int.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine(intList.ArrayToString());
                        break;
                }

                if (x == 4)
                {
                    break;
                }
            }
            
            break;
    }

    if (x == 0 || x == 6)
    {
        break;
    }
}

public class List<T> where T: struct
{
    public T[] Array { get; set; }

    /// <summary>
    /// array initialization
    /// </summary>
    public List()
    {
        Array = new T[0];
    }
    
    /// <summary>
    /// add any item in array
    /// </summary>
    /// <param name="varriable"></param>
    public void Add(T varriable)
    {
        T[] newArray = new T[Array.Length + 1];

        for (int i = 0; i < Array.Length; i++)
        {
            newArray[i] = Array[i];
        }

        newArray[Array.Length] = varriable;
        Array = newArray;
    }
    
    /// <summary>
    /// array as a string
    /// </summary>
    /// <returns></returns>
    public string ArrayToString()
    {
        string result = "";
        for (int i = 0; i < Array.Length; i++)
        {
            result += Array[i].ToString() + ", ";
        }

        return result;
    }

    /// <summary>
    /// Remove any item from array
    /// </summary>
    /// <param name="varriable"></param>
    public void Remove(T varriable)
    {
        int index = -1;

        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i].Equals(varriable))
            {
                index = i;
                break;
            }
        }

        if (index > -1)
        {
            T[] newArray = new T[Array.Length - 1];
            for (int i = 0, j = 0; i < Array.Length; i++)
            {
                if (i == index) continue;
                newArray[j] = Array[i];
                j++;
            }
            Array = newArray;
        }
    }
    /// <summary>
    /// Get item from array
    /// </summary>
    /// <param name="index">item index</param>
    /// <returns></returns>
    /// <exception cref="IndexOutOfRangeException"></exception>
    public T GetItem(int index)
    {
        if (index >-1 && index < Array.Length)
        {
            return Array[index];
        }
        else throw new IndexOutOfRangeException();
    }

    public int Count()
    {
        return Array.Length;
    }
}