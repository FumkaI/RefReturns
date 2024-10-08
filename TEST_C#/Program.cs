﻿using System;

class RoundProgram
{
    static void Main(string[] args)
    {
        // Оголошуємо змінну для зберігання числа
        float number;

        // Запитуємо користувача ввести дробове число
        Console.WriteLine("Введіть дробове число (наприклад: 3,14):");

        // Зчитуємо введене значення та перевіряємо його коректність
        while (!float.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Помилка! Введіть коректне дробове число:");
        }

        // Виводимо початкове значення
        Console.WriteLine($"Ваше число: {number}");

        // Викликаємо метод Round, передаючи число посиланням
        Round(ref number);

        // Виводимо округлене значення
        Console.WriteLine($"Округлене число: {number}");
    }

    // Метод для округлення числа
    // Параметр value передається посиланням (ref),
    // що дозволяє змінити оригінальне значення
    static void Round(ref float value)
    {
        // Якщо число додатне
        if (value > 0)
        {
            // Додаємо 0,5 і відкидаємо дробову частину
            value = (float)(int)(value + 0.5);
        }
        // Якщо число від'ємне
        else if (value < 0)
        {
            // Віднімаємо 0,5 і відкидаємо дробову частину
            value = (float)(int)(value - 0.5);
        }
        // Якщо число ціле або рівне нулю, нічого не робимо
    }
}