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
            //ICAO_CODE myNewForm = new ICAO_CODE(); LEFT FOR FUTURE FOR IMPLEMENTATION OF AIRPORT CODE
            //myNewForm.Show();
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
            refLongDir = refLongDir.Remove(0, 13);
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


            //label8.Text = richTextBox1.Lines.Length.ToString();
            string[,] obstacle = new string[richTextBox1.Lines.Length, 6];//6 columns in chinese ad2.10, and number of lines equal to number of obstacles

            string inputData = richTextBox1.Text;
            char[] delimiters1 = new char[] { '\r', '\n' };
            string[] parts1 = inputData.Split(delimiters1, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < parts1.Length; i++)
            {
                //Console.WriteLine(parts[i]);
                char[] delimiters2 = new char[] {' ', ' '};
                string[] parts2 = parts1[i].Split(delimiters2, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < parts2.Length; j++)
                {
                    obstacle[i, j] = parts2[j];
                    if (j >= 5)
                        break;
                }
                
            }

            
            /*saveFileDialog1.ShowDialog();
            string komunikat;
            komunikat = System.String.Format("Saved in: {0}", saveFileDialog1.FileName);
            MessageBox.Show(komunikat); */


            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Graphics graphicsObj = Graphics.FromImage(bmp);
            Pen MapBorder = new Pen(System.Drawing.Color.Black, 3);
            graphicsObj.DrawRectangle(MapBorder, 0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1); // rysuje obramowanie mapy
            pictureBox1.Image = bmp;  //this makes your changes visible
            pictureBox1.Image.Save(@"C:\Users\Patryk\DoItFaster\DoItFaster\mapa.png", System.Drawing.Imaging.ImageFormat.Png); //zapisywanie mapy do png SCIEZKA NA SZTYWNO!!!
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tEST2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
