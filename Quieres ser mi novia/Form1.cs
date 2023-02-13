using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quieres_ser_mi_novia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox2;
            linkLabel1.Parent = pictureBox2;
            linkLabel2.Parent = pictureBox2;
            linkLabel3.Parent = pictureBox2;
            button1.Parent = pictureBox2;
            panel2.Hide();
            btNo.TabStop = false;
            btSi.TabStop = false;
        }
        public void MoverBoton()
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - btNo.Width);
            int y = r.Next(0, this.Height -btNo.Height);
            btNo.Location=new Point(x,y);
            
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            
        }

        private void btNo_MouseEnter(object sender, EventArgs e)
        {
            MoverBoton();
            if (btNo.Location == btSi.Location || btNo.Location == label1.Location)
            {
                MoverBoton();
            }
        }

        private void btNo_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if (btNo.Location == btSi.Location || btNo.Location == label1.Location)
            {
                MoverBoton();
            }
        }

        private void btSi_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/josedejesusmonroy");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/scaliby2");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://app.aluracursos.com/user/joses79-jdjm");
        }
    }
}
