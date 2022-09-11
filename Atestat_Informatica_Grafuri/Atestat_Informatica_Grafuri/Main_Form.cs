using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Informatica_Grafuri
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            panelSelector.Height = buttonHome.Height;
            panelSelector.Top = buttonHome.Top;
            homeUserControl.BringToFront();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelSelector.Height = buttonHome.Height;
            panelSelector.Top = buttonHome.Top;
            homeUserControl.BringToFront();
        }

        private void buttonTheory_Click(object sender, EventArgs e)
        {
            panelSelector.Height = buttonTheory.Height;
            panelSelector.Top = buttonTheory.Top;
            theoryUserControl.BringToFront();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\Test\" + "Multiple_Choice_Test.html");
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            panelSelector.Height = buttonAbout.Height;
            panelSelector.Top = buttonAbout.Top;
            aboutUserControl.BringToFront();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
