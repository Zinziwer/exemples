﻿int a = 1;//new Random().Next(1,20);
int b = 2;//new Random().Next(1,20);
int c = 6;//new Random().Next(1,20);
int d = 8;//new Random().Next(1,20);
int e = 4;//new Random().Next(1,20);
// Console.WriteLine(a, b, c, d, e);
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
 Console.Write("Max = ");
 Console.WriteLine(max);