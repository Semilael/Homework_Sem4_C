// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Данная программа принимает на вход два числа (A и B) и возводит число A в натуральную степень B. \nВведите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2e число: ");
int degree = int.Parse(Console.ReadLine());

Console.WriteLine($"{num} ^ {degree} = " + Math.Pow(num, degree));
