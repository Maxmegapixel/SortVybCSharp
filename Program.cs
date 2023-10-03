// Сортировка выбором O(n^2)

int[] inputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

int[] sortVybor(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int indexMin = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] < array[indexMin])
                indexMin = j;

        }
        if (array[indexMin] == array[i])
            continue;
        int temp = array[i];
        array[i] = array[indexMin];
        array[indexMin] = temp;    
    }
    return array;
}


Console.Write("Введите количество элементов: ");
int num = int.Parse(Console.ReadLine()!);
int[] array = new int[num];
Console.WriteLine($"Массив: [{String.Join(", ", inputArray(array))}]");
sortVybor(array);

Console.WriteLine($"Массив: [{String.Join(", ", array)}]");