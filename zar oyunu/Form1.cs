using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zar_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int toplamben= 0;
        int toplampc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            int a = rastgele.Next(1,7);
            int b = rastgele.Next(1,7);

            toplamben = toplamben+ a + b;
            label17.Text = toplamben.ToString();

            if(a == 1)
            {
                pictureBox1.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar1.png";
            }
            if(a == 2)
            {
                pictureBox1.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar2.png";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar3.png";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar4.png";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar5.png";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar6.png";
            }

            if (b == 1)
            {
                pictureBox2.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar1.png";
            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar2.png";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar3.png";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar4.png";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar5.png";
            }
            if (b == 6)
            {
                pictureBox2.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar6.png";
            }

            label2.Text = a.ToString();
            label5.Text = b.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;

            int c = rastgele.Next(1, 7);
            int d = rastgele.Next(1, 7);

            toplampc = toplampc + c + d;
            label14.Text= toplampc.ToString();

            label11.Text = c.ToString();
            label8.Text = d.ToString();

            if (c == 1)
            {
                pictureBox1.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar1.png";
            }
            if (c == 2)
            {
                pictureBox1.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar2.png";
            }
            if (c == 3)
            {
                pictureBox1.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar3.png";
            }
            if (c == 4)
            {
                pictureBox1.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar4.png";
            }
            if (c == 5)
            {
                pictureBox1.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar5.png";
            }
            if (c == 6)
            {
                pictureBox1.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar6.png";
            }

            if (d == 1)
            {
                pictureBox2.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar1.png";
            }
            if (d == 2)
            {
                pictureBox2.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar2.png";
            }
            if (d == 3)
            {
                pictureBox2.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar3.png";
            }
            if (d == 4)
            {
                pictureBox2.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar4.png";
            }
            if (d == 5)
            {
                pictureBox2.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar5.png";
            }
            if (d == 6)
            {
                pictureBox2.ImageLocation = @"C:\Users\Nur\Desktop\pratikler\zar6.png";
            }

            if(toplamben > 100 && toplamben > toplampc)
            {
                label13.Text = "Kazanan Sizsiniz! Tebrikler :) :) !!!";
            }
            if(toplampc > 100 && toplampc> toplamben)
            {
                label13.Text = "Kazanan Bilgisayar! Kaybettiniz :( :( !!!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
