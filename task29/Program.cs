﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void RandMassiveInput()
{
    int[] randmassive = new int[8];
    Random rand = new Random();
    for (int i = 0; i < 8; i++)
    {
        randmassive[i] = rand.Next(1, 100);
        System.Console.Write(randmassive[i] + " ");
    }
    return;
}




RandMassiveInput();