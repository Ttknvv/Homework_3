int[] mas = {1, 2, 3, 2, 1};
int N = mas.Length;
int i = 0;
bool t = true;

while(i < (N / 2))
{
    if(mas[i] != mas[N - i - 1])
    {
        t = false;
        break;
    }
    i++;
}

if(t == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}