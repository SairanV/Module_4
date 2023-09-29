using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliances
{
    public partial class HouseholdAppliance
    {
        // Закрытые поля для характеристик бытовой техники
        private string brand;
        private string model;
        private double powerConsumption;
        private bool isOn;
        private int warrantyPeriod;

        // Статические поля для общих характеристик
        private static int totalAppliances = 0;
        private static double totalPowerConsumption = 0;

        // Конструктор по умолчанию
        public HouseholdAppliance()
        {
            brand = "Unknown";
            model = "Unknown";
            powerConsumption = 0;
            isOn = false;
            warrantyPeriod = 0;
            totalAppliances++;
        }

        // Перегруженные конструкторы
        public HouseholdAppliance(string brand, string model, double powerConsumption, int warrantyPeriod)
        {
            this.brand = brand;
            this.model = model;
            this.powerConsumption = powerConsumption;
            this.isOn = false;
            this.warrantyPeriod = warrantyPeriod;
            totalAppliances++;
            totalPowerConsumption += powerConsumption;
        }

        public HouseholdAppliance(string brand, string model, double powerConsumption)
            : this(brand, model, powerConsumption, 0)
        {
        }

        // Методы доступа к закрытым полям
        public string GetBrand()
        {
            return brand;
        }

        public string GetModel()
        {
            return model;
        }

        public double GetPowerConsumption()
        {
            return powerConsumption;
        }

        public int GetWarrantyPeriod()
        {
            return warrantyPeriod;
        }

        public bool IsOn()
        {
            return isOn;
        }

        // Метод для включения или выключения прибора
        public void TogglePower()
        {
            isOn = !isOn;
            if (isOn)
            {
                Console.WriteLine($"{brand} {model} включен.");
            }
            else
            {
                Console.WriteLine($"{brand} {model} выключен.");
            }
        }

        // Метод для рассчета месячных затрат на электроэнергию
        public double CalculateMonthlyElectricityCost(double electricityRate)
        {
            return powerConsumption * 30 * electricityRate;
        }

        // Статический конструктор
        static HouseholdAppliance()
        {
            totalAppliances = 0;
            totalPowerConsumption = 0;
        }

        // Статические методы доступа к общим характеристикам
        public static int GetTotalAppliances()
        {
            return totalAppliances;
        }

        public static double GetTotalPowerConsumption()
        {
            return totalPowerConsumption;
        }
    }
}
