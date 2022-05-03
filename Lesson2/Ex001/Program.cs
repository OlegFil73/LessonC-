// Задача 1
int More(int x)
{

    int a = x / 10;
    int b = x % 10;

    //System.Console.WriteLine($"value: {x} a:{a} b:{b}");
    int max = a;
    if (b > max) max = b;
    //Console.WriteLine(max);
    return max;

}
int value = new Random().Next(10, 100);
System.Console.WriteLine(value);
System.Console.WriteLine(More(value));
