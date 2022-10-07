/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4

int[] array = Numbers();
int count = countAboveZero(array);
Console.WriteLine($"{string.Join(", ", array)}");
Console.WriteLine($"Количество чисел больше нуля составило: {count}");
int[] Numbers() 
{
    Console.Write("Введите числа через запятую и пробел: ");
    return Console.ReadLine().Split(", ").Select(x => int.Parse(x)).ToArray();
}
int countAboveZero(int[] array){
return array.Where(x => x > 0).Count();
}

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");
printResult(Numbers());

int[] Numbers() {
    Console.Write("Введите b1, k1, b2, k2 по порядку через запятую и пробел, после чего нажмите Ввод: ");
    return Console.ReadLine().Split(", ").Select(x => int.Parse(x)).ToArray();
}
void printResult(int[] array) {
    double x = ((double) array[2] - array[0]) / ((double) array[1] - array[3]);
    double y = array[3] * x + array[2];
    Console.WriteLine($"b1 = {array[0]}, k1 = {array[1]}, b2 = {array[2]}, k2 = {array[3]} , и точка пересечения находится в координатах: ({x}; {y})");
}