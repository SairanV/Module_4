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
            HouseholdAppliance[] appliances = new HouseholdAppliance[8];

            // Инициализируем объекты с использованием разных конструкторов
            appliances[0] = new HouseholdAppliance("Samsung", "Холодильник", 150, 12);
            appliances[1] = new HouseholdAppliance("LG", "Стиральная машина", 200);
            appliances[2] = new HouseholdAppliance("LG", "Морозильная камера", 120, 8);
            appliances[3] = new HouseholdAppliance("Bosch", "Посудомоечная машина", 180, 24);
            appliances[4] = new HouseholdAppliance("Sony", "Телевизор", 100);
            appliances[5] = new HouseholdAppliance("Panasonic", "Телевизор", 100, 12);
            appliances[6] = new HouseholdAppliance("LG", "Телевизор", 120, 7);
            appliances[7] = new HouseholdAppliance(); // Вводим (бренд, модель, потребление энергии(Вт), гарантия)

            // Включаем и выключаем некоторые устройства
            appliances[0].TogglePower(); // Включаем холодильник
            appliances[1].TogglePower(); // Включаем стиральную машину
            appliances[2].TogglePower(); // Включаем Морозильная камеру
            appliances[4].TogglePower(); // Включаем телевизор
            appliances[6].TogglePower(); // Включаем телевизор
            appliances[7].TogglePower(); // Включаем неизвестное устройство


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
            double electricityRate = 40; // стоимость электроэнергии в тенге за кВтч
            double washingMachineCost = appliances[1].CalculateMonthlyElectricityCost(electricityRate);
            Console.WriteLine($"Месячные затраты на электроэнергию для стиральной машины: {washingMachineCost} тенге"); 

            Console.ReadLine();
        }
    }
}

