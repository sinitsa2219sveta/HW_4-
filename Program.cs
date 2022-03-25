// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Задача №1 семинар 4
/*
Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int result = 1;
int i;
for (i = 1; i <= number1; i ++ )
{
    result = result * number;
}
Console.WriteLine(result);
*/
//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int result = 1;
int i;
for (i = 1; i <= number1; i ++ )
{
    result = result * number;
}
Console.WriteLine(result);
*/
//Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
 int [] MayArray = {3, 4, 6, 8, 78, 22, 33, 12};
  for(int i = 0; i <  MayArray.Length; i++)
  {
      Console.WriteLine(MayArray[i]);
  }
    
Console.ReadLine();
*/
//Второй вариант решения задачи
/*

Console.Write("Введите количество элементов массива:\t");

int elementsCounts = int.Parse(Console.ReadLine());

int[] myArray = new int[elementsCounts];

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"\nВведите элемент массива под индексом {i}:\t");

    myArray[i] = int.Parse(Console.ReadLine());

}
Console.Write("\nВывод массива:\t");
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}
Console.ReadLine();
*/