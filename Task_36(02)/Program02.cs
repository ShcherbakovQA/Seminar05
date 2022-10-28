// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void HaveMassiv(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-1000, 1001);
    }
}
void TypeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
int HaveSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum+=arr[i];
        }
    }
    return sum;
}

int[] massiv = new int[4];
HaveMassiv(massiv);
TypeArray(massiv);
Console.WriteLine("Сумма чисел на нечетных позициях = " + HaveSum(massiv));

