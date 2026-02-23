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
            Console.WriteLine("ФИО: Леонтьев Денис Александрович");
            
            // Группа
            Console.WriteLine("Группа: ИС-21");
            
            // Текущая дата и время
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
                
                // Здесь будет логика выбора (добавим позже)
            }
        }
    }
}
