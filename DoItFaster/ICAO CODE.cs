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
    public partial class ICAO_CODE : Form
    {
        public ICAO_CODE()
        {
            InitializeComponent();
        }

        private void ICAO_CODE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainWindow = new Form1();
           // var lineCount = mainWindow.richTextBox1.Lines.Count();
            //This to get lines number.
            int index = mainWindow.richTextBox1.SelectionStart;
            int li = mainWindow.richTextBox1.GetLineFromCharIndex(index);
            //int x = 4; //number of obstacles in ad 2.10 (hard coded for now- in future will take value from number of lines)
            string AirportCode = maskedTextBox1.Text;
            string[,] obstacle = new string[4, 6];//6 columns in chinese ad2.10
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
