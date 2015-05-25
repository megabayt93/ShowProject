using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Microsoft.Win32;
using OpenHardwareMonitor.Hardware;

namespace ShowLibrary
{
    public class ShowLib
    {


        private readonly Computer _hardwareComputer;
        private decimal _cpuTemps;
        private decimal _hddTemps;
        private decimal _ramTemps;
        private decimal _gpuTemps;
        private decimal _mainBoardTemps;
        private readonly RegistryKey _processorGhz;
        private string _frequency;
        private readonly PerformanceCounter _counterProcess;
        private readonly PerformanceCounter _counterDisk;
        private readonly PerformanceCounter _counterRam;
        private readonly PerformanceCounter _counterRamPercent;
        private readonly ManagementObjectSearcher _hddInfo;
        private readonly ManagementObjectSearcher _ramInfo;
        private readonly ManagementObjectSearcher _gpuInfo;
        private readonly ManagementObjectSearcher _mainBoard;
        private string _sendGpuInfo;
        private string _sendCpuInfo;
        private string _sendMainBoardInfo;
        private long _totalSize;
        private UInt64 _ramSize;
        private UInt64 _gpuSize;
        private int _processUsage;
        private int _hddUsage;
        private string _gpuProcessors;
        private string _info;
        public ShowLib()
        {
            _cpuTemps = 0;
            _mainBoardTemps = 0;
            _gpuProcessors = "";
            _sendCpuInfo = "";
            _info = "";
            _gpuTemps = 0;

            _hardwareComputer = new Computer();
            _hardwareComputer.Open();
            _hardwareComputer.CPUEnabled = true;
            _hardwareComputer.HDDEnabled = true;
            _hardwareComputer.RAMEnabled = true;
            _hardwareComputer.GPUEnabled = true;
            _hardwareComputer.MainboardEnabled = true;
            _counterProcess = new PerformanceCounter("Processor", "% Processor Time", "_Total", ".");
            _counterDisk = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total", ".");
            _counterRam = new PerformanceCounter("Memory", "Available MBytes", true);
            _counterRamPercent = new PerformanceCounter("Memory", "% Committed Bytes In Use", true);
            _hddInfo = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            _ramInfo = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            _gpuInfo = new ManagementObjectSearcher("Select * From Win32_VideoController");
            _processorGhz = Registry.LocalMachine.OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree);
            _mainBoard = new ManagementObjectSearcher("“SELECT * FROM Win32_BIOS");
        }

        public int SendCpuUsage()
        {

            return _processUsage = Convert.ToInt32(_counterProcess.NextValue());

        }

        public string SendCpuFrequency()
        {

            if (_processorGhz != null)
            {
                if (_processorGhz.GetValue("ProcessorNameString") != null)
                {
                    string cpuValue = (string)_processorGhz.GetValue("ProcessorNameString");
                    _frequency = cpuValue.Split('@')[1];

                }
            }
            return _frequency;
        }

        public string SendCpuName()
        {

            foreach (var hardware in _hardwareComputer.Hardware)
            {

                _sendCpuInfo = hardware.Name.ToString();

                return _sendCpuInfo;
            }
            return _sendCpuInfo;

        }
        public decimal SendCpuTemperature()
        {


            foreach (var hardware in _hardwareComputer.Hardware)
            {
                if (hardware.HardwareType != HardwareType.CPU)
                    continue;
                hardware.Update();
                foreach (var sensor in hardware.Sensors)
                {
                    if (sensor.Value != null && sensor.Value != 0 && sensor.Value > 20.00)

                        _cpuTemps = (decimal)sensor.Value;
                    _cpuTemps = Math.Ceiling(_cpuTemps);
                }
            }
            return _cpuTemps;
        }

        public decimal SendHddTemperature()
        {
            foreach (var hardware in _hardwareComputer.Hardware)
            {
                if (hardware.HardwareType != HardwareType.HDD)
                    continue;
                hardware.Update();
                foreach (var sensor in hardware.Sensors)
                {
                    if (sensor.Value != null && sensor.Value != 0)

                        _hddTemps = (decimal)sensor.Value;
                    _hddTemps = Math.Ceiling(_hddTemps);
                }
            }
            return _hddTemps;
        }

        public double SendHddSize()
        {

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                    _totalSize += drive.TotalSize / 1024 / 1024 / 1024;
            }

            return _totalSize;
        }

        public string SendHddManuFacturer()
        {
            foreach (ManagementBaseObject hdd in _hddInfo.Get())
            {
                _info = hdd["Model"].ToString();
            }
            return _info;
        }

        public int SendHddUsage()
        {
            _hddUsage = Convert.ToInt32(_counterDisk.NextValue());
            if (_hddUsage <= 100)
            {
                return _hddUsage;
            }
            else
            {
                _hddUsage = 100;
            }
            return _hddUsage;
        }
        public decimal SendRamTemperature()
        {
            foreach (var hardware in _hardwareComputer.Hardware)
            {
                if (hardware.HardwareType != HardwareType.RAM)
                    continue;
                hardware.Update();
                foreach (var sensor in hardware.Sensors)
                {
                    if (sensor.Value != null && sensor.Value != 0)

                        _ramTemps = (decimal)sensor.Value;
                    _ramTemps = Math.Ceiling(_ramTemps);
                }
            }
            return _ramTemps;
        }

        public string SendRamSize()
        {

            foreach (ManagementBaseObject ramSize in _ramInfo.Get())
            {
                _ramSize += Convert.ToUInt64(ramSize.Properties["Capacity"].Value) / 1024 / 1024;
            }

            return Convert.ToString(_ramSize);
        }

        public int SendMemoryUsage()
        {

            return (int)_ramSize - Convert.ToInt32(_counterRam.NextValue());
        }

        public int SendMemoryUsagePercent()
        {

            return 100 + (Convert.ToInt32((_ramSize - (_counterRam.NextValue()) * 100) / _ramSize)); ;
        }

        public string SendGpuName()
        {


            foreach (var hardware in _hardwareComputer.Hardware)
            {
                if (hardware.HardwareType != HardwareType.GpuAti & hardware.HardwareType != HardwareType.GpuNvidia)
                    continue;
                hardware.Update();

                _sendGpuInfo = hardware.Name.ToString();

            }
            return _sendGpuInfo;

        }

        public int SendGpuVram()
        {
            foreach (ManagementBaseObject gpu in _gpuInfo.Get())
            {

                _gpuSize = Convert.ToUInt64(gpu["AdapterRam"]) / 1024 / 1024;

            }

            return (int)_gpuSize;
        }

        public string SendGpuProcessor()
        {
            foreach (ManagementBaseObject gpu in _gpuInfo.Get())
            {
                _gpuProcessors = gpu["VideoProcessor"].ToString();

                break;



            }
            return _gpuProcessors;
        }

        public decimal SendGpuTemperature()
        {
            foreach (var hardware in _hardwareComputer.Hardware)
            {
                if (hardware.HardwareType != HardwareType.GpuAti & hardware.HardwareType != HardwareType.GpuNvidia)
                    continue;
                hardware.Update();
                foreach (var sensor in hardware.Sensors)
                {
                    if (sensor.Value != null && sensor.Value != 0 && sensor.Value > 10&&sensor.Value<100)

                        _gpuTemps = (decimal)sensor.Value;
                    _gpuTemps = Math.Ceiling(_gpuTemps);
                }
            }
            return _gpuTemps;
        }


        public string SendMainBoardInfo()
        {

            foreach (var hardware in _hardwareComputer.Hardware)
            {
                if (hardware.HardwareType != HardwareType.Mainboard)
                    continue;
                hardware.Update();
                _sendMainBoardInfo = hardware.Name;

            }
            return _sendMainBoardInfo;


        }

        public decimal SendMainBoardTemperature()
        {
            foreach (var hardware in _hardwareComputer.Hardware)
            {
                if (hardware.HardwareType != HardwareType.Mainboard)
                    continue;
                hardware.Update();
                foreach (var sensor in hardware.Sensors)
                {
                    if (sensor.Value != null && sensor.Value != 0)

                        _mainBoardTemps = (decimal)sensor.Value;
                    _mainBoardTemps = Math.Ceiling(_mainBoardTemps);
                }
            }
            return _mainBoardTemps;
        }

    }
}
