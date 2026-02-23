using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Лабораторная работа №4 ===");
            Console.WriteLine("Приветствую в программе!");
            
            // ФИО
            string fio = "Леонтьев Денис Александрович";
            string group = "ИС-21";
            
            Console.WriteLine($"ФИО: {fio}");
            Console.WriteLine($"Группа: {group}");
            Console.WriteLine($"Текущая дата и время: {DateTime.Now}");
            
            bool isRunning = true;
            
            while (isRunning)
            {
                Console.WriteLine("\n--- МЕНЮ ---");
                Console.WriteLine("1 — Показать ФИО");
                Console.WriteLine("2 — Показать группу");
                Console.WriteLine("3 — Показать дату");
                Console.WriteLine("4 — Выход");
                Console.Write("Выберите пункт: ");
                
                string choice = Console.ReadLine();
                
                // ЛОГИКА ВЫБОРА
                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"ФИО: {fio}");
                        break;
                    case "2":
                        Console.WriteLine($"Группа: {group}");
                        break;
                    case "3":
                        Console.WriteLine($"Текущая дата и время: {DateTime.Now}");
                        break;
                    case "4":
                        Console.WriteLine("Выход из программы. До свидания!");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}
