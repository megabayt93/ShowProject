using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Show
{
    public partial class Opening : Form
    {
       
        public Opening()
        {
            InitializeComponent();
                this.Visible = false;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Opening_Load(object sender, EventArgs e)
        {
           backgroundWorkerYatech.RunWorkerAsync();
       
        }

        private void backgroundWorkerYatech_DoWork(object sender, DoWorkEventArgs e)
        {
            
            Application.Run(new ShowMain());
        


        }

        private void backgroundWorkerYatech_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
         
        }
    }
}
