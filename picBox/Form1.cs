using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.Image = Image.FromFile("PIHALLA.jpg");

            }
            else if (radioButton2.Checked)
            {
                pictureBox1.Image = Properties.Resources.POLKU;
            }
            else if (radioButton3.Checked)
            {
                pictureBox1.Image = Properties.Resources.MANTY;
                // pictureBox1.Image = Image.FromFile(@"C:\asdasd\asdasd\asdasd.jpg");
            }
            else if (radioButton4.Checked)
            {
                pictureBox1.Image = imageList1.Images[0];
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
