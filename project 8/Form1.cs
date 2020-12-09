using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        int saat = 0, dakika = 0, saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label6.Text = saniye.ToString();
            if (saniye == 60)
            {
                dakika++;
                label5.Text = dakika.ToString();
                saniye = 0;
            }
            if (dakika == 60)
            {
                saat++;
                label4.Text = saat.ToString();
                dakika = 0;
            }

        }
    }
}
