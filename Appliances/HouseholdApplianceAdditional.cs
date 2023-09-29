using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Appliances
{
    public partial class HouseholdAppliance
    {
        // Дополнительный метод
        public void DisplayInfo()
        {
            Console.WriteLine($"Бренд: {brand}");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Потребление электроэнергии: {powerConsumption} Вт");
            Console.WriteLine($"Гарантийный срок: {warrantyPeriod} месяцев");
            Console.WriteLine($"Состояние: {(isOn ? "Включен" : "Выключен")}");
        }
    }
}

