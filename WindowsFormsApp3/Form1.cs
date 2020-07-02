using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flir.Atlas.Image;
using Flir.Atlas.Image.Palettes;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            //create an instance of the Thermal object called image1
            var image1 = new ThermalImageFile(@"C:\Users\sarosh.niazi\Desktop\Images\IR_2019-05-06_0007.jpg");

            //set the image in pictureBox1 to the one in the path
            pictureBox1.Image = image1.Image;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            //create an instance of the Thermal object called image1
            var image1 = new ThermalImageFile(@"C:\Users\sarosh.niazi\Desktop\Images\IR_2019-05-06_0007.jpg");

            //changes the palette of image1
            image1.Palette = PaletteManager.Arctic;

            //set the image in pictureBox1 to the one with a new palette
            pictureBox1.Image = image1.Image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //create an instance of the Thermal object called image1
            var image1 = new ThermalImageFile(@"C:\Users\sarosh.niazi\Desktop\Images\IR_2019-05-06_0007.jpg");


            //get emissivity for image1; returns the value in label1
            label1.Text = image1.ThermalParameters.Emissivity.ToString("F2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //create an instance of the Thermal object called image1
            var image1 = new ThermalImageFile(@"C:\Users\sarosh.niazi\Desktop\Images\IR_2019-05-06_0007.jpg");

            //get relative temperature for image1; returns the value in label2
            label2.Text = image1.ThermalParameters.ReflectedTemperature.ToString("F2") + ("° C");
        }

    }
}