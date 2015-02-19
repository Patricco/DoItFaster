using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoItFaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string refLatDir, refLatDeg, refLatMin, refLatSec, refLongDir, refLongDeg, refLongMin, refLongSec;

            // Dividing reference point coordinates into useful string
            // source string mask "L00-00-00.00 L000-00-00.00"
            refLatDir = maskedTextBox1.Text.Remove(1);
            refLatDeg = maskedTextBox1.Text.Remove(3);
            refLatDeg = refLatDeg.Remove(0, 1);
            refLatMin = maskedTextBox1.Text.Remove(6);
            refLatMin = refLatMin.Remove(0, 4);
            refLatSec = maskedTextBox1.Text.Remove(12);
            refLatSec = refLatSec.Remove(0,7);
            refLongDir = maskedTextBox1.Text.Remove(14);
            refLongDir = refLongDir.Remove(0, 12);
            refLongDeg = maskedTextBox1.Text.Remove(17);
            refLongDeg = refLongDeg.Remove(0, 14);
            refLongMin = maskedTextBox1.Text.Remove(20);
            refLongMin = refLongMin.Remove(0, 18);
            refLongSec = maskedTextBox1.Text.Remove(0,21);
            richTextBox2.Text += string.Format("\n stopnie: {0} \n minuty: {1} \n sekundy: {2} \n stopnie: {3} \n minuty: {4} \n sekundy: {5}", refLatDeg, refLatMin, refLatSec, refLongDeg, refLongMin, refLongSec);
            richTextBox2.Text += " \n ";
            richTextBox2.Text +=refLatDir;
            richTextBox2.Text += " \n ";
            richTextBox2.Text += refLongDir;
            /*saveFileDialog1.ShowDialog();
            string komunikat;
            komunikat = System.String.Format("Saved in: {0}", saveFileDialog1.FileName);
            MessageBox.Show(komunikat); */
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
