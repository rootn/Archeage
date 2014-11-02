using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Plotter.Source;

namespace Plotter
{
    public partial class PlotForm : Form
    {
        public int housePosX = 0;
        public int housePosY = 0;
        public int housePosZ = 0;
        private uint houseID = 0;
        housePlotter plotter;

        public PlotForm()
        {
            InitializeComponent();
            this.designList.SelectedIndex = 0;
        }

        public void setPlotter(housePlotter obj)
        {
            plotter = obj;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plotter.markHouseOnMap(housePosX, housePosY, housePosZ);
        }

        private void PlotForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (designList.SelectedIndex == 0) houseID = 21168;
            else if (designList.SelectedIndex == 1) houseID = 21172;
            else if (designList.SelectedIndex == 2) houseID = 21171;
            else if (designList.SelectedIndex == 3) houseID = 15566;
            else houseID = 21165;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plotter.spamHouse(houseID, housePosX, housePosY, housePosZ);
        }

        private void formX_Click(object sender, EventArgs e)
        {
            housePosX = Int32.Parse(xBox.Text);
        }

        private void formY_Click(object sender, EventArgs e)
        {
            housePosY = Int32.Parse(yBox.Text);
        }

        private void formZ_Click(object sender, EventArgs e)
        {
            housePosZ = Int32.Parse(zBox.Text);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            plotter.bCancelRequested = true;
        }
    }
}
