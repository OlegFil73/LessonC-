// Задача 2: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.



int number = 1825;

int sum = 0;
while (number > 0)
{
    int temporary = number % 10;
    sum = sum + temporary; 
      number = number / 10;
   }
Console.WriteLine(sum);
