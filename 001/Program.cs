﻿//С клавиатуры вводится целое число. Вывести квадрат числа (блок-схема)
int a;
a=10;
System.Console.Write ("Введите число");
string? s=Console.ReadLine ();
a=Convert.ToInt32 (s);
int b=a*a;
System.Console.WriteLine (b);
System.Console.WriteLine ($"{a}^2={b}");

