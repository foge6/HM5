// // // Задайте массив заполненный случайными положительными трёхзначными числами. 
// // // Напишите программу, которая покажет количество чётных чисел в массиве.
// // // [345, 897, 568, 234] -> 2
// int[] Array (int size)
// {
//     int[] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//     }
//     return array;
// }
// void PrintArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " "); 
//     }
//     System.Console.WriteLine(" ");
// }
// void Find (int[] array)
// {
//     int count = 0;
//    for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] %2 == 0)
//         {
//             count +=1;
//         } 
//     } 
//     System.Console.WriteLine(count);
// }
// System.Console.WriteLine("Write size");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] massive = Array(size);
// PrintArray(massive);
// Find(massive);

// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] Array ()
// {
//     int[] array = new int [123];
//     for (int i = 0; i < 123; i++)
//     {
//         array[i] = new Random().Next(1,124);
//     }
//     return array;
// }
// void PrintArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " "); 
//     }
//     System.Console.WriteLine(" ");
// }
// void Find (int[] array)
// {
//     int count = 0;
//    for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 9 && array[i] < 100)
//         {
//             count +=1;
//         } 
//     } 
//     System.Console.WriteLine(count);
// }

// int[] massive = Array();
// PrintArray(massive);
// Find(massive);


// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] Array ()
// {
//     int[] array = new int [5];
//     for (int i = 0; i < 5; i++)
//     {
//         array[i] = new Random().Next(1,101);
//     }
//     return array;
// }
// void PrintArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " "); 
//     }
//     System.Console.WriteLine(" ");
// }
// void FindSumm (int[] array)
// {
//     int summ =0;
//    for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2==1)
//         {
//             summ  += array[i];
//         } 
//     } 
//     System.Console.WriteLine(summ);
// }
// int[] massive = Array();
// PrintArray(massive);
// FindSumm(massive);


// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] Array ()
// {
//     double[] array = new double [5];
//     for (int i = 0; i < 5; i++)
//     {
//         array[i] = Convert.ToDouble(new Random().Next(10,101)/10.0);
//     }
//     return array;
// }
// void PrintArray (double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " "); 
//     }
//     System.Console.WriteLine(" ");
// }
// void difference (double[] array)
// {
//     double max = array[0];
//     double min = array[0];
//    for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i]>max)
//         max = array[i];
//         if (array[i]<min)
//         min = array[i];
//     } 
//     System.Console.WriteLine($" max - min = {Math.Round(max-min,2)}");
// }
// double[] massive = Array();
// PrintArray(massive);
// difference(massive);


// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] Array (int size)
// {
//     int[] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(1,11);
//     }
//     return array;
// }

// void PrintArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " "); 
//     }
//     System.Console.WriteLine(" ");
// }
// int[] Multiplication (int[] array)
// {
//     int[] arr = new int[array.Length / 2];
//     int count = 0;
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         arr[count] = (array[i] * array[array.Length - i - 1]);
//         count++;
//     }
//     return arr;
// }
// int[] Multiplication1 (int[] array)
// {
//     int[] arr = new int[array.Length / 2 + 1];
//     int count = 0;
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         arr[count] = (array[i] * array[array.Length - i - 1]);
//         count++;
//     }
//     arr [arr.Length - 1] = array[array.Length/2];
//     return arr;
// }
// System.Console.WriteLine("Write size");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] massive = Array(size);
// PrintArray(massive);
// if (massive.Length %2==0)
// PrintArray(Multiplication(massive));
// else
// PrintArray(Multiplication1(massive));

