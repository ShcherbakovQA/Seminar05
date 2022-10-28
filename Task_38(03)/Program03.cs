// Задача 38: Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и минимальным элементами массива.

void FillingMassiv(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 101);
    }
}
void TypeMassiv(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
void Differ(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
        if (min > arr[i])
        {
            min = arr[i];
        }
    }
    Console.WriteLine("Разница между максимальным числом " + max + " и минимальным числом " + min + " = " + (max - Math.Abs(min)));
}
double[] massiv = new double[5];
FillingMassiv(massiv);
TypeMassiv(massiv);
Differ(massiv);


