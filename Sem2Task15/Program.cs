﻿// // Напишите программу, которая принимает на вход цифру, 
// // обозначающую день недели, и проверяет, 
// // является ли этот день выходным.

// Console.Write("Введите номер дня недели: ");
// int num = int.Parse(Console.ReadLine() ?? "0");

// if(num > 0 && num < 8)
// {
//       if(num > 5)
//       {
//             Console.WriteLine("Поздравляю, выходные!");
//       }
//       //Пробую написать в строку, для экономии места... Получилось.
//       else Console.WriteLine("Пока ещё будни");
// }
// else Console.WriteLine("Не похоже на день неделиб ещё подумай...");

// //* Сделать вариант с использованием конструкции Dictionary


var day = new Dictionary<int, string>
{
      {1, "Пока ещё будни"},
      {2, "Пока ещё будни"},
      {3, "Пока ещё будни"},
      {4, "Пока ещё будни"},
      {5, "Пока ещё будни"},
      {6, "Поздравляю, выходные"},
      {7, "Поздравляю, выходные"}
};

Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine() ?? "0");

if (num > 0 && num < 8)
{
      Console.WriteLine(day[num]);
}
else
{
      Console.WriteLine("Не похоже на день неделиб ещё подумай...");
}
