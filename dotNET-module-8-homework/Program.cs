using System;
using ClassLibrary;

namespace dotNET_module_8_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача №1
            Console.WriteLine("Задача №1");

            SquaredArray arr = new SquaredArray(5);

            arr[0] = 2.5; // Установка значения и его квадрата
            arr[1] = 3.0;
            arr[2] = 1.5;

            Console.WriteLine("Значения массива:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            //Задача №2
            Console.WriteLine("Задача №2");

            Console.WriteLine("Введите метраж помещения (в квадратных метрах):");
            double squareMeterage = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество проживающих:");
            int numberOfResidents = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите сезон (осень/зима):");
            string season = Console.ReadLine();

            Console.WriteLine("Есть ли льготы (да/нет):");
            string hasDiscount = Console.ReadLine();

            double heatingRate = 5.0;  // базовый тариф на отопление за 1 м2
            double waterRate = 2.0;    // базовый тариф на воду за 1 человека
            double gasRate = 3.0;      // базовый тариф на газ за 1 человека
            double repairRate = 10.0;  // базовый тариф на текущий ремонт за 1 м2

            if (season == "зима" || season == "осень")
            {
                heatingRate *= 1.2;  // увеличиваем тариф на отопление зимой
            }

            double heatingCost = squareMeterage * heatingRate;
            double waterCost = numberOfResidents * waterRate;
            double gasCost = numberOfResidents * gasRate;
            double repairCost = squareMeterage * repairRate;

            double totalCost = heatingCost + waterCost + gasCost + repairCost;

            if (hasDiscount == "да")
            {
                Console.WriteLine("Введите тип льготы (ветеран труда/ветеран войны):");
                string discountType = Console.ReadLine();

                if (discountType == "ветеран труда")
                {
                    totalCost -= (heatingCost + waterCost + gasCost) * 0.3;
                }
                else if (discountType == "ветеран войны")
                {
                    totalCost -= (heatingCost + waterCost + gasCost) * 0.5;
                }
            }

            Console.WriteLine("Вид платежа\tНачислено\tЛьготная скидка\tИтого");
            Console.WriteLine($"Отопление\t{heatingCost:F2}\t{0:F2}\t{heatingCost:F2}");
            Console.WriteLine($"Вода\t\t{waterCost:F2}\t{0:F2}\t{waterCost:F2}");
            Console.WriteLine($"Газ\t\t{gasCost:F2}\t{0:F2}\t{gasCost:F2}");
            Console.WriteLine($"Ремонт\t\t{repairCost:F2}\t{0:F2}\t{repairCost:F2}");
            Console.WriteLine($"Итого\t\t{totalCost:F2}");
        }
    }
}
