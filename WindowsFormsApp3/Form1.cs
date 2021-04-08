using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        const string path= @"..\..\image";
       // string path1 = Directory.GetCurrentDirectory();
        
        List<string> pathImages =new List<string>();
        Random r = new Random();
        int sum = 0;
        int face1;
        int face2;


        public Form1()
        {
            InitializeComponent();
           // Console.WriteLine("path is ::: "+path1);
            for (int i = 1; i <=6; i++)
            {
                pathImages.Add(path+@"\"+i+".png");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int index1 = r.Next(pathImages.Count);
            sum += (index1+1);
            face1 = index1;

            pictureBox3.ImageLocation = pathImages[index1];
            index1 = r.Next(pathImages.Count);
            sum += (index1+1);
            face2 = index1;
            pictureBox4.ImageLocation = pathImages[index1];

            if(sum ==7 || sum == 11)
            {
                button1.Enabled = true;
                button2.Enabled = false;
                label1.Text = "You win !!!";
                sum = 0;
            }
            else if (sum==2 || sum==3||sum==12)
            {
                button1.Enabled = true;
                button2.Enabled = false;
                label1.Text = "sorry. you lose. ";
                sum = 0;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = true;
                label1.Text = "rool again.";
                groupBox1.Text = "point is " + sum + " ";
                pictureBox1.ImageLocation= pathImages[face1];
                pictureBox2.ImageLocation = pathImages[face2];

            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum1 = 0;
            int index1 = r.Next(pathImages.Count);
            sum1 += (index1 + 1);
            pictureBox3.ImageLocation = pathImages[index1];

            index1 = r.Next(pathImages.Count);
            sum1 += (index1 + 1);
             pictureBox4.ImageLocation = pathImages[index1];
            if (sum1 == 7)
            {
                button1.Enabled = true;
                button2.Enabled = false;
                label1.Text = "sorry. you lose. ";
                sum = 0;
            }
            else if (sum1==sum)
            {
                button1.Enabled = true;
                button2.Enabled = false;
                label1.Text = "You win !!!";
                sum = 0;
            }
        }
    }
}
