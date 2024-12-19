using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kassa
{
    public partial class Kassa : Form
    {
        public Kassa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sale saleform = new Sale();
            saleform.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            NewSupply newSupplyform = new NewSupply();
            newSupplyform.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrintingLabels printingLabelsform = new PrintingLabels();
            printingLabelsform.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void recovery_Click(object sender, EventArgs e)
        {
            Recovery recoveryform = new Recovery();
            recoveryform.Show();
            Hide();
        }
    }
}
