// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int arrayLenght = 5;
// int []array = new int[arrayLenght];
// int count = 0;

// for (int i = 0; i < arrayLenght; i++){
//     array[i] = new Random().Next(100, 1000);
//     if (array[i]%2 == 0){
//         count++;
//     }
//     Console.Write(array[i] + " "); 
// }
// Console.WriteLine();

// Console.WriteLine("Количество четных чисел: " + count);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int arrayLenght = 4;
// int []array = new int[arrayLenght];
// int sum = 0;
// int i = 0;

// for (i = 0; i < arrayLenght; i++){
//     array[i] = new Random().Next();
//     Console.Write(array[i] + " "); 
// }

// for (i = 1; i < arrayLenght; i+=2){
//     sum += array[i];
// }
// Console.WriteLine();
// Console.WriteLine(sum);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


// int arrayLenght = 6;
// double []array = new double[arrayLenght];
// double result = 0;
// int i = 0;

// for (i = 0; i < arrayLenght; i++){
//     array[i] = new Random().Next(100) + new Random().Next(100)/100.0;
//     Console.Write(array[i] + "   "); 
// }
// Console.WriteLine();
// double max = array[0], min = array[0];

// for (i = 1; i < arrayLenght; i++) {
//     if (array[i]> max){
//         max = array[i];
//     }
//     else if(array[i]<min){
//         min = array[i];
//     }
// }

// result = max - min;

// Console.WriteLine(result);

