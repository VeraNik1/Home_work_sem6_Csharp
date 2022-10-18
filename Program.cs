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
if(k1 == k2 && b1 == b2){
    Console.WriteLine($"Задана одна и та же прямая");}
else if (k1 == k2){
    Console.WriteLine($"Прямые, заданные уравнениями y = {k1} * x + ({b1}) и y = {k2} * x + ({b2}) параллельны");
    }
else{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Прямые, заданные уравнениями y = {k1} * x + ({b1}) и y = {k2} * x + ({b2}), пересекаются в точке ({x}, {y})");
}


/*Доп.Задача (Если вдруг не можете решить 43, либо хотите решить для интереса)

Найти произведение всех элементов массива целых 
чисел, меньших заданного числа. Размерность массива –10. 
Заполнение массива осуществить случайными числами от 50 до 100.*/
int[] myArray = GetArray(10, 50, 100);
Console.WriteLine($"Сгенерированный массив: {String.Join("|", myArray)}");
Console.WriteLine("Введите число N: ");
int Num = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetMultiply(Num, myArray));



String GetMultiply(int n, int[] array){
    double total = 1;
    int count = 0;
    foreach(int item in array){
        if(item < n){
            total*=item;
            count++;
        }
    }
    if(count > 0){
    return $"Произведение элементов массива меньше {n} равно {total}";}
    else{
    return $"Элементы меньше {n} отсутствуют в заданном массиве";
}
}


int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}