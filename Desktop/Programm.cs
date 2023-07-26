// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами


void PrintArray(string[] array)
{
     for (int i = 0; i < array.Length; i++)
     {
         System.Console.Write(array[i] + " ");
     }
     System.Console.WriteLine();
 }
void Array(string[] array1, string[] array2)
 {
     int n = 0;
     for (int i = 0; i < array1.Length; i++)
     {
         if (array1[i].Length < 3)
         {
             array2[n] = arrauy[i];
             n++;
         }
     }
 }
 string[] array1 = new string[9] { "art", "start", "first", "1", "low", "234", "type", "of", "classic" };
 string[] array2 = new string[array1.Lenght];
 PrintArray(array2);
