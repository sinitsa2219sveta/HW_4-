// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] array = new int[100];


FillArray(array);

Solve(array);

void FillArray(int[] goose)
{
    Random random = new Random();

    for (int i = 0; i < goose.Length; i++)
    {
        goose[i] = random.Next(100, 1000);
    }
}

void Solve(int[] goose)
{
    int counter = 0;

    for (int i = 0; i < goose.Length; i++)
    {
        if (goose[i] % 2 == 0)
        {
            counter++;
        }
    }

    System.Console.WriteLine(counter);
}
*/
//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int SummNechetElement()
{
    int[] array = new int[10];
    int summa = 0;

    for (int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(1, 11);
        System.Console.Write(array[i] + " ");
    }

    for (int i = 0; i < 10; i++)
    {
        if(i % 2 != 0) summa = summa + array[i];
    }

    System.Console.WriteLine();
    return summa;
}


System.Console.WriteLine($"сумма с нечётными индексами = {SummNechetElement()}");
*/
//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[100];
FillArray(array);
Delta(array);

void FillArray(double[] goose)
{
    Random random = new Random();

    for (int i = 0; i < goose.Length; i++)
    {
        goose[i] = 1000 * random.NextDouble();
    }
}

void Delta(double[] goose)
{
    double min = double.MaxValue, max = double.MinValue;
    for (int i = 0; i < goose.Length; i++)
    {
        if (goose[i] < min) min = goose[i];
        if (goose[i] > max) max = goose[i];
    }

    System.Console.WriteLine(max - min);
}
