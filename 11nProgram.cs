//*******************************************************************************
//* Практическая работа № 11                                                    *
//* Выполнила: Конюхова М.Н., группа 2ИСП                                       *
//* Задание: получить навыки работы с символьными данными и операциями над ними *
//*******************************************************************************
using System;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Title = "Практическая работа № 11";
                    Console.WriteLine("Здравствуйте");
                    Console.Write("Введите строку ");
                    string String = Console.ReadLine();
                    if (String.IsNullOrEmpty(String))
                    {
                        Console.WriteLine("Строка пустая.");
                    }
                    string newString = String.Replace("a", "").Replace("A", "").Replace("а", "").Replace("А", "");
                    Console.WriteLine(newString);
                    Console.WriteLine("Хотите выполнить команду ещё раз?\nНажмите Y для продолжения программы," +
                           "иначе любую другую кнопку для завершения");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Программа завершена\tДо свидания.");
                        break;

                    }
                }


                catch (FormatException fex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Исключение: {fex.Message}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Исключение: {ex.Message}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.ReadKey();

            }
        }
    }
}
        
    
        
    

