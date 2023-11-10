using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class UtilityPaymentCalculator
    {
        private UtilityRates rates;

        public UtilityPaymentCalculator(UtilityRates utilityRates)
        {
            rates = utilityRates;
        }

        public void CalculatePayments(int area, int occupants, bool isWinter, bool hasPrivilege)
        {
            double totalHeating = area * rates[0] * (isWinter ? 1.2 : 1.0);
            double totalWater = occupants * rates[1];
            double totalGas = occupants * rates[2];
            double totalMaintenance = area * rates[3];

            double total = totalHeating + totalWater + totalGas + totalMaintenance;

            double discount = 0;
            if (hasPrivilege)
            {
                // Применение льгот
                discount = total * (occupants > 1 ? 0.5 : 0.3);
            }

            double finalTotal = total - discount;

            // Вывод таблицы
            Console.WriteLine("Вид платежа\tНачислено\tЛьготная скидка\tИтого");
            Console.WriteLine($"Отопление\t{totalHeating:C}\t\t0\t\t\t{totalHeating:C}");
            Console.WriteLine($"Вода\t\t{totalWater:C}\t\t0\t\t\t{totalWater:C}");
            Console.WriteLine($"Газ\t\t{totalGas:C}\t\t0\t\t\t{totalGas:C}");
            Console.WriteLine($"Текущий ремонт\t{totalMaintenance:C}\t\t0\t\t\t{totalMaintenance:C}");
            Console.WriteLine($"\nИтог\t\t{total:C}\t\t{discount:C}\t\t{finalTotal:C}");
        }
    }
}
