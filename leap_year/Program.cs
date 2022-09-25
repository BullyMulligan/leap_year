using System;

public class Program
{
    public static void Main()
    {
        bool yearIsLeap = false;
        Console.WriteLine("Введите год:");
        int year = Convert.ToInt32(Console.ReadLine());
        yearIsLeap=IsLeapYear(year);
        if (yearIsLeap)
        {
            Console.Write($"Да, {year} високосный.");
        }
        else
        {
            Console.Write($"Нет, {year} не високосный.");
        }
        

    }

    private static bool IsLeapYear(int a) //Метод, принимающий год, и возвращащий булевое значение
    {
        bool year = false;
        if (a%4==0)//все года, кратные 4 - високосныы
        {
            year = true;
        }

        if (a%100==0 && a%400 != 0)//все года, кратные 100, но не кратные 400 - не високосны
        {
            year = false;
        }

        return year;
    }
}