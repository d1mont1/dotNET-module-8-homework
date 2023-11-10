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

            //Класс UtilityRates хранит тарифы в массиве и предоставляет доступ к ним через индексатор.
            ////UtilityPaymentCalculator использует этот класс для расчета платежей.

            UtilityRates rates = new UtilityRates(0.1, 20, 15, 0.05);
            UtilityPaymentCalculator calculator = new UtilityPaymentCalculator(rates);

            int area = 100;
            int occupants = 4;
            bool isWinter = true;
            bool hasPrivilege = true;

            calculator.CalculatePayments(area, occupants, isWinter, hasPrivilege);
        }
    }
}
