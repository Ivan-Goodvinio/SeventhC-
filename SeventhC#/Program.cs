/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. */
/*
int n = 0;
int m = 0;
Console.WriteLine("Столбец");
m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Строка");
n=Convert.ToInt32(Console.ReadLine());
int [,]  mas = new int[m, n];
Random rand = new Random();
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
     mas[i,j]=rand.Next(-20,20);
     Console.Write(mas[i, j] + "    ");
    }
    Console.WriteLine();
}
*/





/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. */
/*
int n = 0;
int m = 0;
Console.WriteLine("Столбец");
m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Строка");
n=Convert.ToInt32(Console.ReadLine());
int [,]  mas = new int[m, n];
Random rand = new Random();
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
     mas[i,j]=rand.Next(-20,20);
     Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}
int f = 0;
int g = 0;
Console.WriteLine("Столбец");
f=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Строка");
g=Convert.ToInt32(Console.ReadLine());
if (m < f || n < g)
    Console.WriteLine("Нет такого знаачения");
    else 
Console.WriteLine(mas[f-1,g-1]);
*/





/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. */
/*
int n = 0;
int m = 0;
double sum=0;
Console.WriteLine("Строк");
m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Столбцов");
n=Convert.ToInt32(Console.ReadLine());
int [,]  mas = new int[ m,n ];
Random rand = new Random();
for(int i = 0; i < m; i++)
{  
    for(int j = 0; j < n; j++)
    {
     mas[i,j]=rand.Next( -20,20 );
     Console.Write(mas[i,j] + " ");     
    }
    Console.WriteLine();
}
for(int j=0 ; j<n ; j++)
{
    sum = 0;
    for(int i = 0 ; i<m ; i++)
    {
        sum+=mas[i,j];
    }
    sum=sum/m;
    Console.WriteLine("Сумма элементов стоблца = {0}", sum);
    Console.WriteLine();
}
*/