/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Сколько чисел будем проверять?: ");
int M = int.Parse(Console.ReadLine()!);

int count = 0;
int temp;
for(int i = 0; i < M; i++){
    Console.WriteLine($"Введите {i + 1}-й элемент из {M}: ");
    temp = int.Parse(Console.ReadLine()!);
    if(temp > 0){
        count++;
        }
    }

Console.WriteLine($"Количество положительных чисел из {M} введенных: {count}");


/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
Console.WriteLine("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine()!);
if (k1 == k2){
    Console.WriteLine($"Прямые, заданные уравнениями y = {k1} * x + ({b1}) и y = {k2} * x + ({b2}) параллельны");
    }
else{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Прямые, заданные уравнениями y = {k1} * x + ({b1}) и y = {k2} * x + ({b2}), пересекаются в точке ({x}, {y})");
    }

