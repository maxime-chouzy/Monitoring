using SysInfo.Interfaces;
using System.Management;
using SysInfo.Interfaces;

namespace SysInfo.Models
{
    public class GpuInfo : IComponentInfo
    {
        public string Name { get; private set; }
        public string AdapterRAM { get; private set; }
        public string DriverVersion { get; private set; }
        // Ajoutez ici d'autres propriétés pour les informations du GPU

        public GpuInfo()
        {
            FetchInfo();
        }

        public void FetchInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject obj in searcher.Get())
            {
                Name = obj["Name"].ToString();
                AdapterRAM = obj["AdapterRAM"].ToString();
                DriverVersion = obj["DriverVersion"].ToString();
                // Récupérez ici les autres informations du GPU
            }
        }
    }
}
