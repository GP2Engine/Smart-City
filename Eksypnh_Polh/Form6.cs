using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eksypnh_Polh
{
    public partial class Form6 : Form
    {
        int count;
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.Hide();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label1.Focus();
            int tem= Int32.Parse(label1.Text);
            if (tem<30)
            {
                tem = tem + 1;
                string tex = tem.ToString();
                label1.Text = tex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label1.Focus();
            int tem = Int32.Parse(label1.Text);
            if (tem > 16)
            {
                tem = tem - 1;
                string tex = tem.ToString();
                label1.Text = tex;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label1.Focus();
            int tem = Int32.Parse(label5.Text);
            if (tem < 5)
            {
                tem = tem + 1;
                string tex = tem.ToString();
                label5.Text = tex;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label1.Focus();
            int tem = Int32.Parse(label5.Text);
            if (tem > 1)
            {
                tem = tem - 1;
                string tex = tem.ToString();
                label5.Text = tex;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Text = "25";
            label5.Text = "3";
            pictureBox1.ImageLocation = "cool.png";
            button7.BackColor = Color.Red;
            button7.Text = "OFF";
            count = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label1.Focus();

            if (pictureBox1.ImageLocation == "cool.png")
            {
                pictureBox1.ImageLocation = "heat.png";
            }
            else if (pictureBox1.ImageLocation == "heat.png")
            {
                pictureBox1.ImageLocation = "fan.png";
            }
            else
            {
                pictureBox1.ImageLocation = "cool.png";
            }
           
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                GlobalClass.PlaySound3();
                MessageBox.Show(string.Format("Απαιτείται καθαρισμός των φίλτρων διότι εντοπίστηκε πολύ σκόνη σε αυτά. Καθαρίστε τα και προσπαθήστε ξανά."), "Προσοχή!", MessageBoxButtons.OK);
                count++;
            }
            else
            {
                GlobalClass.PlaySound();
                this.label1.Focus();

                if (button7.BackColor == Color.Red)
                {
                    button7.BackColor = Color.Lime;
                    button7.Text = "ON";
                }
                else
                {
                    button7.BackColor = Color.Red;
                    button7.Text = "OFF";
                }
            }
        }
    }
}
