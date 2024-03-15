﻿using ConsoleApp3;

Console.WriteLine("Какой проект запустить? 1? 2? 3? 4?");
Console.WriteLine("Чтобы вйти введите -2");
int proj = -1;
do
{
    Console.Write("Номер проекта: ");
    try
    {
        proj = Convert.ToInt32(Console.ReadLine());
               
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message + "\n00.Введите корректные данные!");
        return;
    }
    switch (proj)
    {
        case 1:
            Console.WriteLine("Project-1");
            try
            {
                Console.WriteLine("Введите минимальную температуру в C (Цельсиях) за день");
                int min = 0;
                min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите максимальную температуру в C (Цельсиях) за день");
                int max = 0;
                max = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Среднесуточная температура: {(max + min) / 2}C");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n01.Введите коректные данные!");
                return;
            }

            break;
        case 2:
            Task2.Main();
            break;
        case 3:
            Task3.Main();
            break;
        case 4:
            Task4.Main();
            break;
        default:
            break;
    }

} while (proj != -2);





