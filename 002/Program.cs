﻿// С клавиатуры вводятся два вещественных
//числа. Проверять является ли одно из 
//них квадратом второго (блок-схема)

Console.WriteLine("Hello, World!");

System.Console.WriteLine ("Введите число a:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine ("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());

if(a*a==b) System.Console.WriteLine($"{b}является квадратом {a}");
if(b*b==a) System.Console.WriteLine($"{a}является квадратом {b}");

