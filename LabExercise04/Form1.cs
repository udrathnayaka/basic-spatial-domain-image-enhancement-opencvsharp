using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace LabExercise04
{
    
    public partial class Form1 : Form
    {
        LogicOperations lo = new LogicOperations();
        OpenFileDialog ofd = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ofd.Title = "Select an Image";
            ofd.Filter = "Images (*.BMP; *.JPG; *.GIF) | *.BMP; *.JPG; *.GIF|" + "All Files(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lo.LoadOriginalImage(ofd.FileName);
                String path = ofd.FileName.ToString();
                pictureBox1.ImageLocation = path;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ofd.Title = "Select an Image";
            ofd.Filter = "Images (*.BMP; *.JPG; *.GIF) | *.BMP; *.JPG; *.GIF|" + "All Files(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lo.LoadMaskImage(ofd.FileName);
                String path = ofd.FileName.ToString();
                pictureBox2.ImageLocation = path;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index =comboBox1.SelectedIndex;

            if (index == 0)
            {
                lo.ANDOperation();
                pictureBox3.ImageLocation = "3.jpg";
            }
            else if (index == 1)
            {
                lo.OROperation();
                pictureBox3.ImageLocation = "4.jpg";
            }
            else if (index == 2)
            {
                lo.Subtraction();
                pictureBox3.ImageLocation = "5.jpg";
            }
            else
            {
                MessageBox.Show("ERROR !");
            }


        }
    }
}
