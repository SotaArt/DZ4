//ДЗ Сергей Калмыков.

/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Vozvedenie(int numberA, int numberB)
    {
    int result = 1;
        for(int i=1; i <= numberB; i++)
    {
    result = result * numberA;
        }
// int result = Math.Pow(numberA, numberB);
    return result;
    }
Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());
  int rez = Vozvedenie(numberA, numberB);
Console.WriteLine("Ответ: " + rez);
*/


/*
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введи число N: ");
    int numN = Convert.ToInt32(Console.ReadLine());
        int sumNum = SumNum(numN);
Console.WriteLine("Сумма цифр числа N: " + sumNum);
  int SumNum(int numN){
    int count = Convert.ToString(numN).Length;
     int advance = 0;
     int result = 0;
        for (int i = 0; i < count; i++){
            advance = numN - numN % 10;
             result = result + (numN - advance);
                 numN = numN / 10;
             }
   return result;
  }
*/



/*
// Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Лови массив из 8 рандомных элементов");
PrintArr(8);
void PrintArr(int quantity){
    int[] array = new int[quantity]; 
    for(int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(1, 34);
    }
Console.Write("[");
    for(int i = 0; i < 5; i++) {
        Console.Write(array[i]);
        if(i + 1 < 5)Console.Write(",");
    }
Console.Write("]");
Console.WriteLine();
Console.Write("[");
    for(int i = 5; i < quantity; i++) {
        Console.Write(array[i]);
        if(i + 1 < quantity)Console.Write(",");
    }
Console.Write("]");
}
*/