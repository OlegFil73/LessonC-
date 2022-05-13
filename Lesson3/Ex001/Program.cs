// Задача 1
//Напишите программу, которая принимает на вход координаты
//точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//в которой находится эта точка.

string Quarter(int x, int y)

{
  string c = String.Empty;
    if (x > 0 & y > 0) c = "1";
    if (x < 0 & y > 0) c = "2";
    if (x < 0 & y < 0) c = "3";
    if (x > 0 & y < 0) c = "4";
    return c;
}

string res = Quarter(-3, -2);
Console.WriteLine($"{res} четверть");
