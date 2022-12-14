// Сгенерировать одномерный массив из 10 целых чисел
// (и положительных и отрицательных(оформить в виде функции).
// Вывести исходные данные и результат на экран (оформить в виде функции).
// Выполнить сортировку массива Методом «пузырька». По возрастанию

// Тестовый массив
/*int[] numbers = { 7, 2, 9, 4, 1, 0};
SortArray(numbers);*/

int n = 10;
int[] array = new int[n];
GenArray(n, array);
Console.WriteLine("Сгенерированный массив:");
SeeArray(array);
Console.WriteLine("Выполним сортировку!");
SortArray(array);
Console.WriteLine("Итого отсортированный массив:");
SeeArray(array);

// Генерация массива длиной n
int[] GenArray(in int n, int[] array)
{
    var random = new Random();

    // Массив пишется в обратной последовательности
    array[n - 1] = random.Next(-100, 100);

    // Console.Write("{0}\t", array[n-1]);
    // Console.WriteLine();
    if (n == 1)
    {
        return array;
    }

    return GenArray(n - 1, array);
}

// Сортировка массива методом пузырька
int[] SortArray(int[] arr)
{
    int tempValue;
    int tempCounter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                tempCounter++;
                tempValue = arr[j + 1];
                arr[j + 1] = arr[j];
                arr[j] = tempValue;
                Console.Write("Этап сортировки:\t");
                SeeArray(arr);
            }

            // break;
        }

        /*
        if (i == arr.Length - 1 && tempCounter != 0)
        {
            return SortArray(arr);
        }*/
    }

    return arr;
}

// Показать массив
void SeeArray(int[] arr)
{
    foreach (int i in arr)
    {
        Console.Write("{0}\t", i);
    }

    Console.WriteLine();
}
