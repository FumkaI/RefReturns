using System;

public class TextProcessor
{
    public static void Run()
    {
        // Приклад тексту для обробки
        string text = "Привіт! Це простий текст. Він містить кілька речень... Можливо це останнє речення?";

        // Змінна для зберігання кількості речень
        int sentenceCount;

        // Викликаємо метод і зберігаємо результат
        string[] sentences = ToSentences(text, out sentenceCount);

        // Виводимо результати
        Console.WriteLine($"Знайдено речень: {sentenceCount}");
        Console.WriteLine("Речення:");

        // Виводимо кожне речення на новому рядку
        foreach (string sentence in sentences)
        {
            Console.WriteLine(sentence.Trim());
        }
    }

    // Метод для розбиття тексту на речення
    // параметри:
    //   text - вхідний текст для обробки
    //   sentenceCount - вихідний параметр, що містить кількість знайдених речень
    // повертає:
    //   масив рядків, де кожен рядок - окреме речення
    public static string[] ToSentences(string text, out int sentenceCount)
    {
        // Перевіряємо, чи текст не пустий
        if (string.IsNullOrEmpty(text))
        {
            sentenceCount = 0;
            return new string[0];
        }

        // Визначаємо символи, які можуть закінчувати речення
        char[] sentenceEndings = { '.', '!', '?' };

        // Розбиваємо текст на речення
        // Використовуємо метод Split, вказуючи символи кінця речення
        // StringSplitOptions.RemoveEmptyEntries видаляє пусті елементи
        string[] sentences = text.Split(sentenceEndings, StringSplitOptions.RemoveEmptyEntries);

        // Зберігаємо кількість речень у вихідний параметр
        sentenceCount = sentences.Length;

        return sentences;
    }
}

// Основний клас програми
class Program
{
    static void Main(string[] args)
    {
        // Викликаємо метод Run з класу TextProcessor
        TextProcessor.Run();
    }
}