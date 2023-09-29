using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Appliances;

namespace Module_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем массив объектов HouseholdAppliance
            HouseholdAppliance[] appliances = new HouseholdAppliance[5];

            // Инициализируем объекты с использованием разных конструкторов
            appliances[0] = new HouseholdAppliance("Samsung", "Холодильник", 150, 12);
            appliances[1] = new HouseholdAppliance("LG", "Стиральная машина", 200);
            appliances[2] = new HouseholdAppliance("Bosch", "Посудомоечная машина", 180, 24);
            appliances[3] = new HouseholdAppliance("Sony", "Телевизор", 100);
            appliances[4] = new HouseholdAppliance();

            // Включаем и выключаем некоторые устройства
            appliances[0].TogglePower(); // Включаем холодильник
            appliances[1].TogglePower(); // Включаем стиральную машину
            appliances[3].TogglePower(); // Включаем телевизор
            appliances[4].TogglePower(); // Включаем неизвестное устройство

            // Выводим информацию о каждом устройстве
            foreach (var appliance in appliances)
            {
                appliance.DisplayInfo();
                Console.WriteLine();
            }

            // Выводим общее количество устройств и потребление электроэнергии
            Console.WriteLine($"Общее количество устройств: {HouseholdAppliance.GetTotalAppliances()}");
            Console.WriteLine($"Общее потребление электроэнергии: {HouseholdAppliance.GetTotalPowerConsumption()} Вт");

            // Рассчитываем месячные затраты на электроэнергию для стиральной машины
            double electricityRate = 0.15; // стоимость электроэнергии в долларах за кВтч
            double washingMachineCost = appliances[1].CalculateMonthlyElectricityCost(electricityRate);
            Console.WriteLine($"Месячные затраты на электроэнергию для стиральной машины: ${washingMachineCost}");

            Console.ReadLine();
        }
    }
}

