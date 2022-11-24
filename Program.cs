/*Задача 21:
Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/
/*
double Lenth3D (double x1, double x2, double y1, double y2, double z1, double z2)
{
   double Lenth3D = Math.Sqrt((x2 - x1)*(x2 - x1)+(y2 - y1)*(y2 - y1)+(z2 - z1)*(z2 - z1));
   return Lenth3D;
}
Console.Write("Введите значение координаты х точки 1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты х точки 2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты y точки 1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты y точки 2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты z точки 1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты z точки 2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Lenth = Lenth3D(x1, x2, y1, y2, z1, z2);
Console.WriteLine($"Расстояние между точками = {Lenth}");
*/


/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125


void NambersCube (int num)
{
   int current = 1;
   while(current<=num)
   {
      Console.WriteLine($"{current} = {current*current*current}");
      current++;
   }
}
Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
NambersCube(number);




/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

void Polindrom (int number)
{  
   while(number!=0)
   {
     int mun = number % 10;
     {
        if(mun==number) Console.Write("введенное число является полиндромом ");
        else Console.Write("введенное число не является полиндромом: ");

      }
      
   }
}
Console.Write("Введите целое положительное пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Polindrom (number);




