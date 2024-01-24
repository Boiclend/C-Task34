// С клавиатуры вводится число N (типа int). Используя алгоритм «Решето Эратосфена», необходимо найти все простые числа
//  (т.е. делящиеся только на себя и на единицу) в интервале [0;N].


int m, k = 0;
Console.WriteLine("Введите число");
m = Convert.ToInt32(Console.ReadLine());
int b = (int)Math.Sqrt(m) + 1;
int[] number = new int[m];
for (int i = 0; i < m; i++)
{
    number[i] = i;
}
for (int i = 0; i < m; i++) {
    for (int j = 2; j < number[i]; j++) {
        if (number[i] % j == 0)
        {
            number[i] = 0;
        }
    }
}   
for (int i = 0; i < m; i++) {
    if (number[i] > 1)
    {
        k++;
        Console.WriteLine(number[i]);
    }
} 
      
    
Console.WriteLine("количество простых чисел = " + k);