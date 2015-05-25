 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;
using ShowLibrary;

namespace Show
{
    public partial class ShowMain : Form
    {

        private readonly ShowLib _showLib;
      
        public ShowMain()
        {

            InitializeComponent();
        
            _showLib = new ShowLib();
            Opening firstOpening = new Opening();
            firstOpening.Hide();
        }

        /* 
          
         
           **    ** *******  *********  *******  ********  **   **
            **  **  **   **     ***     **       **    **  **   **
             ****   *******     ***     **       **        *******
              **    *******     ***     *******  **        *******  
              **    **   **     ***     **       **    **  **   **
              **    **   **     ***     *******  ********  **   **
         */


        private void ShowMain_Load(object sender, EventArgs e)
        {
            Opening.ActiveForm.Hide();
            cpuManufacturerInfo.Text = _showLib.SendCpuName();
            cpuModelInfo.Text = _showLib.SendCpuName();
            cpuGhzInfo.Text = _showLib.SendCpuFrequency();
            hddSizeInfo.Text = _showLib.SendHddSize().ToString() + " GB";
            ramSizeInfo.Text = _showLib.SendRamSize() + " MB";
            hddManufacturerInfo.Text = _showLib.SendHddManuFacturer();
            gpuVramInfo.Text = _showLib.SendGpuVram().ToString() + " MB";
            gpuManufacturerInfo.Text = _showLib.SendGpuName();
            gpuFamilyInfo.Text = _showLib.SendGpuProcessor();
            mainboardInfo.Text = _showLib.SendMainBoardInfo();
            tmrInfo.Start();


         
           
           
        }

        private void tmrInfo_Tick(object sender, EventArgs e)
        {

            cpuTemperatureInfo.Text = _showLib.SendCpuTemperature().ToString() + ".00 °C ";
            cpuUsageInfo.Text = "% " + _showLib.SendCpuUsage().ToString();

            hddTemperatureInfo.Text = _showLib.SendHddTemperature().ToString() + ".00 °C";


            ramTemperatureInfo.Text = _showLib.SendRamTemperature().ToString() + ".00 °C";

            hddUsageInfo.Text = "% " + _showLib.SendHddUsage().ToString();
            ramUsageInfo.Text = _showLib.SendMemoryUsage().ToString() + " MB" + "(% " + _showLib.SendMemoryUsagePercent().ToString() + ")";

            gpuTemperatureInfo.Text = _showLib.SendGpuTemperature().ToString() + ".00 °C";

            mainBoardTemperatureInfo.Text = _showLib.SendMainBoardTemperature().ToString() + ".00 C";

     

        }

       

        private void pharmaPic_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://fatihyazici.kim");
        }

        private void ShowMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
