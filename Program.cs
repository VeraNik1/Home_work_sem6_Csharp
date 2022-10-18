﻿/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Сколько числе будем проверять: ");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Вы ввели {CountPositiveNums(M)} положительных числа из {M}");

int CountPositiveNums(int N){
    int count = 0;
    int temp;
    for(int i = 0; i < N; i++){
        Console.WriteLine($"Введите {i + 1}-й элемент из {N}: ");
        temp = int.Parse(Console.ReadLine()!);
        if(temp > 0){
            count++;
        }
    }
    return count;
}



/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/