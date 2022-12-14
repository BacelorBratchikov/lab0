// Даны действительные числа х1, у1, х2, у2, ..., х10, у10.
// Найти периметр десятиугольника, вершины которого имеют координаты
// (х1, у1), (х2, у2), ..., (х10, у10).

// Определить функцию вычисления расстояния между двумя точками,
// заданными своими координатами.

// Генерация массива n x m
int n = 10;
int m = 2;
double result = 0;

int[,] array = new int[n, m];
var random = new Random();
Console.WriteLine("Сгенерированный массив:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = random.Next(0, 100);
        Console.Write("{0}\t", array[i, j]);
    }

    Console.WriteLine();

    // Первая строка и ее связь с последней считаются отдельно
    if (i > 0)
    {
        // Коментарии ниже - координаты точек для опредления расстояния
        // Console.WriteLine($"{array[i-1, 0]}\t {array[i-1, 1]}\t");
        // Console.WriteLine($"{array[i, 0]}\t {array[i, 1]}\t");
        result += Distance(array[i, 0], array[i, 1],
                 array[i - 1, 0], array[i - 1, 1]);
    }

    // Коментарий ниже позволит смотреть промежуточные результаты
    // Console.WriteLine($"Расстояние отрезков {result}");
}

// Console.WriteLine($"{array[n - 1, 0]}\t {array[n - 1, 1]}\t");
// Console.WriteLine($"{array[0, 0]}\t {array[0, 1]}\t");
result += Distance(array[0, 0], array[0, 1],
         array[n - 1, 0], array[n - 1, 1]);

// Функция расчета расстояния отрезка
double Distance(int x1, int y1, int x2, int y2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) +
                      Math.Pow(y2 - y1, 2));
    return distance;
}

Console.WriteLine($"Периметр многоугольника равен: {result}");

