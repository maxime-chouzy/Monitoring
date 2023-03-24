using SysInfo.Interfaces;
using System.Management;
using SysInfo.Interfaces;

namespace SysInfo.Models
{
    public class CpuInfo : IComponentInfo
    {
        public string Name { get; private set; }
        public int NumberOfCores { get; private set; }
        public string Manufacturer { get; private set; }
        public int MaxClockSpeed { get; private set; }
        public string Description { get; private set; }
        public double Temperature { get; private set; }

        // Ajoutez ici d'autres propriétés pour les informations du CPU

        public CpuInfo()
        {
            FetchInfo();
        }

        public void FetchInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                Name = obj["Name"].ToString();
                NumberOfCores = int.Parse(obj["NumberOfCores"].ToString());
                Manufacturer = obj["Manufacturer"].ToString();
                MaxClockSpeed = int.Parse(obj["MaxClockSpeed"].ToString());
                Description = obj["Description"].ToString();
                // Récupérez ici les autres informations du CPU
            }
        }

        public void FetchTemperature()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");
                foreach (ManagementObject obj in searcher.Get())
                {
                    double temp = Convert.ToDouble(obj["CurrentTemperature"].ToString());
                    // La température est en dixièmes de kelvin, convertissez-la en Celsius
                    Temperature = (temp - 2732) / 10.0;
                    break; // On suppose qu'il n'y a qu'une seule température de CPU à récupérer
                }
            }
            catch
            {
                Temperature = -1; // Si une erreur se produit, définissez la température sur -1
            }
        }
    }
}
