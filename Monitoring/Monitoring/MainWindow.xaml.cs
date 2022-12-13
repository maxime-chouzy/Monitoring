using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Management;
using Microsoft.Win32;

namespace Monitoring
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SystemInfo si = new SystemInfo();
            OS_name.Content = si.GetOsInfos("os") + " " + si.GetOsInfos("arch");
            procName.Content = "Processeur " + si.GetInformations("Name");
            Number_of_cpu_core_physical.Content = si.GetCoreCpu() + " coeurs";
            Number_of_cpu_core_logical.Content = si.GetCoreCpuLogical() + " threads";
            // Nom_ram.Content = si.GetMemoryInformations("OtherIdentifyingInfo");
            Size_Disk.Content = si.GetDiskSize();
            Name_Disk.Content = si.GetDiskName();
        }
    }

    public class SystemInfo
    {
        // Récupération infos OS
        public string GetOsInfos(string pInfos)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
            foreach(ManagementObject mo in mos.Get())
            {
                switch (pInfos)
                {
                    case "os":
                        return mo["Caption"].ToString();
                    case "arch":
                        return mo["OSArchitecture"].ToString();
                    case "osv":
                        return mo["CSDVersion"].ToString();

                }
            }
            return "";
        }

        /// <summary>
        /// Récup nom CPU
        /// </summary>
        /// <returns></returns>
        public string GetCpuName()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select NAME from win32_processor");
            foreach (ManagementObject name in searcher.Get())
            {
                string processor_name = (name["Name"].ToString());
                return processor_name;
            }
            return "";
            
        }

        public int GetCoreCpu()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select NumberOfCores from win32_processor");
            foreach (ManagementObject numberofcore in searcher.Get())
            {
                int cpu_core = Convert.ToInt32(numberofcore["NumberOfCores"]);
                return cpu_core;
            }
            return 0;
        }

        public int GetCoreCpuLogical()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select NumberOfLogicalProcessors from win32_processor");
            foreach (ManagementObject numberofcorelogical in searcher.Get())
            {
                int cpu_core = Convert.ToInt32(numberofcorelogical["NumberOfLogicalProcessors"]);
                return cpu_core;
            }
            return 0;
        }

        public string GetInformations(string param)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select " + param + " from win32_processor");
            foreach (ManagementObject zz in searcher.Get())
            {
                string cpu_core = zz[param].ToString();
                return cpu_core;
            }
            return "";
        }

        public string GetMemoryInformations(string param)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_PhysicalMemory");
            foreach (ManagementObject zzz in searcher.Get())
            {
                string cpu_core = zzz[param].ToString();
                return cpu_core;
            }
            return "";
        }

        public string GetDiskSize()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select Size from Win32_DiskDrive");
            foreach (ManagementObject Size in searcher.Get())
            {
                long cpu_core = Convert.ToInt64(Size["Size"]);
                string t = FormatBytes(cpu_core);
                return t;
            }
            return "";
        }

        private static string FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }

        public string GetDiskName()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select SystemName from Win32_DiskDrive");
            foreach (ManagementObject disk in searcher.Get())
            {
                string disk_name = (disk["SystemName"].ToString());
                return disk_name;
            }
            return "";
        }
    }
}
