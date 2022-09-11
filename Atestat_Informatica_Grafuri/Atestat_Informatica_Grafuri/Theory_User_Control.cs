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
    public partial class Theory_User_Control : UserControl
    {
        public Theory_User_Control()
        {
            InitializeComponent();
        }

        private void buttonUndirectedTheory_Click(object sender, EventArgs e)
        {
            panelTerminologyTheory.Height = 45;
            panelDirectedTheory.Height = 45;
            panelWeightedTheory.Height = 45;
            panelTreesTheory.Height = 45;
            if (panelUndirectedTheory.Height == 135)
                panelUndirectedTheory.Height = 45;
            else
                panelUndirectedTheory.Height = 135;
        }

        private void buttonDirectedTheory_Click(object sender, EventArgs e)
        {
            panelTerminologyTheory.Height = 45;
            panelUndirectedTheory.Height = 45;
            panelWeightedTheory.Height = 45;
            panelTreesTheory.Height = 45;
            if (panelDirectedTheory.Height == 225)
                panelDirectedTheory.Height = 45;
            else
                panelDirectedTheory.Height = 225;
        }

        private void buttonWeightedTheory_Click(object sender, EventArgs e)
        {
            panelTerminologyTheory.Height = 45;
            panelUndirectedTheory.Height = 45;
            panelDirectedTheory.Height = 45;
            panelTreesTheory.Height = 45;
            if (panelWeightedTheory.Height == 225)
                panelWeightedTheory.Height = 45;
            else
                panelWeightedTheory.Height = 225;
        }

        private void Theory_User_Control_Load(object sender, EventArgs e)
        {
            panelTerminologyTheory.Height = 45;
            panelUndirectedTheory.Height = 45;
            panelDirectedTheory.Height = 45;
            panelWeightedTheory.Height = 45;
            panelTreesTheory.Height = 45;
        }

        private void buttonTerminologyTheory_Click(object sender, EventArgs e)
        {
            webBrowserTheory.Navigate(Application.StartupPath + @"\Theory\" + "Index.html");
            panelUndirectedTheory.Height = 45;
            panelDirectedTheory.Height = 45;
            panelWeightedTheory.Height = 45;
            panelTreesTheory.Height = 45;
        }

        private void buttonTreesTheory_Click(object sender, EventArgs e)
        {
            webBrowserTheory.Navigate(Application.StartupPath + @"\Theory\" + "Trees_Theory.html");
            panelTerminologyTheory.Height = 45;
            panelUndirectedTheory.Height = 45;
            panelDirectedTheory.Height = 45;
            panelWeightedTheory.Height = 45;
        }

        private void buttonUndirectedSub1Theory_Click(object sender, EventArgs e)
        {
            webBrowserTheory.Navigate(Application.StartupPath + @"\Theory\" + "Undirected_Theory.html");
            panelUndirectedTheory.Height = 45;
        }

        private void buttonUndirectedSub2Theory_Click(object sender, EventArgs e)
        {
            webBrowserTheory.Navigate(Application.StartupPath + @"\Theory\" + "Crossing_Undirected_Theory.html");
            panelUndirectedTheory.Height = 45;
        }

        private void buttonDirectedSub1Theory_Click(object sender, EventArgs e)
        {
            webBrowserTheory.Navigate(Application.StartupPath + @"\Theory\" + "Directed_Theory.html");
            panelDirectedTheory.Height = 45;
        }

        private void buttonDirectedSub2Theory_Click(object sender, EventArgs e)
        {
            webBrowserTheory.Navigate(Application.StartupPath + @"\Theory\" + "Plus_Minus_Algorithm_Theory.html");
            panelDirectedTheory.Height = 45;
        }

        private void buttonDirectedSub3Theory_Click(object sender, EventArgs e)
        {
            webBrowserTheory.Navigate(Application.StartupPath + @"\Theory\" + "Kosaraju_Algorithm_Theory.html");
            panelDirectedTheory.Height = 45;
        }

        private void buttonDirectedSub4Theory_Click(object sender, EventArgs e)
        {
            webBrowserTheory.Navigate(Application.StartupPath + @"\Theory\" + "Roy_Warshall_Algorithm_Theory.html");
            panelDirectedTheory.Height = 45;
        }

        private void buttonWeightedSub1Theory_Click(object sender, EventArgs e)
        {
            webBrowserTheory.Navigate(Application.StartupPath + @"\Theory\" + "Roy_Floyd_Algorithm_Theory.html");
            panelWeightedTheory.Height = 45;
        }

        private void buttonWeightedSub2Theory_Click(object sender, EventArgs e)
        {
            webBrowserTheory.Navigate(Application.StartupPath + @"\Theory\" + "Dijkstra_Algorithm_Theory.html");
            panelWeightedTheory.Height = 45;
        }

        private void buttonWeightedSub3Theory_Click(object sender, EventArgs e)
        {
            webBrowserTheory.Navigate(Application.StartupPath + @"\Theory\" + "Prim_Algorithm_Theory.html");
            panelWeightedTheory.Height = 45;
        }

        private void buttonWeightedSub4Theory_Click(object sender, EventArgs e)
        {
            webBrowserTheory.Navigate(Application.StartupPath + @"\Theory\" + "Kruskal_Algorithm_Theory.html");
            panelWeightedTheory.Height = 45;
        }
    }
}