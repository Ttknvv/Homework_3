int[] mas = {1, 2, 3, 2, 1};
int N = mas.Length;
int i = 0;

while(i < (N / 2))
{
    if(mas[i] == mas[N - i - 1])
    {
        i++;
    }
    else
    {
        Console.WriteLine("Нет");
        break;
    }
}

Console.WriteLine("Да");