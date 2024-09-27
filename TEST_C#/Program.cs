using System;

// Базовий клас для всіх меблів
public class Furniture
{
    // Властивість для зберігання назви меблів
    public string Name { get; set; }

    // Конструктор, який приймає назву меблів
    public Furniture(string name)
    {
        Name = name;
    }

    // Віртуальний метод для виведення інформації про меблі
    // Може бути перевизначений в похідних класах
    public virtual void Print()
    {
        Console.WriteLine($"{Name}\n");
    }
}

// Клас для стільців, успадкований від Furniture
public class Seat : Furniture
{
    // Конструктор без параметрів, який встановлює назву "Стілець"
    public Seat() : base("Стілець") { }
}

// Клас для столів, успадкований від Furniture
public class Table : Furniture
{
    // Додаткова властивість для кількості ніжок
    public int LegsCount { get; set; }

    // Конструктор, який приймає кількість ніжок
    public Table(int legsCount) : base("Стіл")
    {
        LegsCount = legsCount;
    }

    // Перевизначений метод Print для виведення інформації про стіл
    public override void Print()
    {
        Console.WriteLine($"{Name}\n" + $"кількість ніжок - {LegsCount}\n");
    }
}

// Клас для столів з трьома ніжками
public class ThreeLegsTable : Table
{
    // Конструктор, який встановлює кількість ніжок на 3
    public ThreeLegsTable() : base(3) { }
}

// Клас для столів з чотирма ніжками
public class FourLegsTable : Table
{
    // Конструктор, який встановлює кількість ніжок на 4
    public FourLegsTable() : base(4) { }
}

// Клас для стільців з чотирма ніжками
public class FourLegsSeat : Seat
{
    // Властивість для кількості ніжок
    public int LegsCount { get; set; }

    // Конструктор, який встановлює кількість ніжок на 4
    public FourLegsSeat() : base()
    {
        LegsCount = 4;
    }

    // Перевизначений метод Print для виведення інформації про стілець
    public override void Print()
    {
        Console.WriteLine($"{Name}\n" + $"кількість ніжок - {LegsCount}");
    }
}

// Головний клас програми
class Program
{
    static void Main(string[] args)
    {
        Furniture furniture;

        // Створення та виведення інформації про полицю
        furniture = new Furniture("Полиця");
        furniture.Print();

        // Створення та виведення інформації про звичайний стілець
        furniture = new Seat();
        furniture.Print();

        // Створення та виведення інформації про стіл з трьома ніжками
        furniture = new ThreeLegsTable();
        furniture.Print();

        // Створення та виведення інформації про стілець з чотирма ніжками
        furniture = new FourLegsSeat();
        furniture.Print();
    }
}