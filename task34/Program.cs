// С клавиатуры вводится число N (типа int). Используя алгоритм «Решето Эратосфена», необходимо найти все простые числа
//  (т.е. делящиеся только на себя и на единицу) в интервале [0;N].

Console.Write("Введите число - N: ");
int n = Convert.ToInt32(Console.ReadLine());
int size_array = n - 1;
int[] arrayPtr = new int[size_array];
for (int i = 0; i < size_array; i++)
{
    arrayPtr[i] = i + 2;
}
int p = 2;
int index = 0;

while (p < n - 1)
{
    try
    {
        for (int i = p * p - 2; i < size_array; i += p)
        {
            arrayPtr[i] = -1;
        }

        while (arrayPtr[index] <= p )
        {
            index++;
        }
        p = arrayPtr[index];
    }
    catch
    {
        for (int i = 0; i < size_array; i++)
        {       
            if (arrayPtr[i] != -1)
            {
                Console.Write($"{arrayPtr[i]} ");
            }
        }
        return;
    }
}

for (int i = 0; i < size_array; i++)
{
    if (arrayPtr[i] != -1)
    {
        Console.Write($"{arrayPtr[i]} ");
    }
}
Console.WriteLine();
Console.ReadKey();