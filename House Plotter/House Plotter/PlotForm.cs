using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plotter.Source;

namespace Plotter
{
    public partial class PlotForm : Form
    {
        public int housePos1;
        public int housePos2;
        public int housePos3;
        private uint houseID;
        housePlotter plotter;

        public PlotForm()
        {
            InitializeComponent();
        }

        public void setPlotter(housePlotter obj)
        {
            plotter = obj;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plotter.markHouseOnMap(housePos1, housePos2, housePos3);
        }

        private void PlotForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            housePos1 = Int32.Parse(this.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            housePos2 = Int32.Parse(this.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            housePos3 = Int32.Parse(this.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) houseID = 21168;
            else if (comboBox1.SelectedIndex == 1) houseID = 21172;
            else if (comboBox1.SelectedIndex == 2) houseID = 21171;
            else if (comboBox1.SelectedIndex == 3) houseID = 15566;
            else houseID = 21165;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plotter.spamHouse(houseID, housePos1, housePos2, housePos3);
        }
    }
}
