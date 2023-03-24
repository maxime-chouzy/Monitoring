using SysInfo.Models;
using System.Windows.Forms;
using SysInfo.Models;

namespace SysInfo
{
    public partial class Form1 : Form
    {
        private CpuInfo _cpuInfo;
        private GpuInfo _gpuInfo;
        // Déclarez les autres objets d'information ici

        public Form1()
        {
            InitializeComponent();
            InitializeSystemInfoObjects();
            DisplayInfo();
        }

        private void InitializeSystemInfoObjects()
        {
            _cpuInfo = new CpuInfo();;
            _gpuInfo = new GpuInfo();
            // Initialisez les autres objets d'information ici
        }

        private void DisplayInfo()
        {
            // Informations sur le CPU
            cpuNameTextBox.Text = _cpuInfo.Name;
            cpuCoresTextBox.Text = _cpuInfo.NumberOfCores.ToString();
            txtManufacturer.Text = _cpuInfo.Manufacturer;
            txtMaxClockSpeed.Text = _cpuInfo.MaxClockSpeed.ToString();
            txtDescription.Text = _cpuInfo.Description;

            // Informations sur le GPU
            txtGpuName.Text = _gpuInfo.Name;
            txtAdapterRAM.Text = _gpuInfo.AdapterRAM;
            txtDriverVersion.Text = _gpuInfo.DriverVersion;

            // Température du CPU
            _cpuInfo.FetchTemperature();
            txtCpuTemperature.Text = _cpuInfo.Temperature >= 0 ? $"{_cpuInfo.Temperature} °C" : "N/A";
        }

        private void timerTemperatureUpdate_Tick(object sender, EventArgs e)
        {
            // Mettez à jour la température du CPU
            _cpuInfo.FetchTemperature();
            txtCpuTemperature.Text = _cpuInfo.Temperature >= 0 ? $"{_cpuInfo.Temperature} °C" : "N/A";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeSystemInfoObjects();
            DisplayInfo();
            timerTemperatureUpdate.Start();
        }
    }
}
