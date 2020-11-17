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
    public partial class Form9 : Form
    {
        int count;
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.Hide();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            label1.Text = "5";
            label5.Text = "-10";
            button7.BackColor = Color.Lime;
            button7.Text = "ON";
            count = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label1.Focus();
            int tem = Int32.Parse(label1.Text);
            if (tem < 15)
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
            if (tem > 0)
            {
                tem = tem - 1;
                string tex = tem.ToString();
                label1.Text = tex;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label1.Focus();
            int tem = Int32.Parse(label5.Text);
            if (tem < 0)
            {
                tem = tem + 1;
                string tex = tem.ToString();
                label5.Text = tex;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label1.Focus();
            int tem = Int32.Parse(label5.Text);
            if (tem > -20)
            {
                tem = tem - 1;
                string tex = tem.ToString();
                label5.Text = tex;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                GlobalClass.PlaySound3();
                MessageBox.Show(string.Format("Δεν είναι δυνατή η απενεργοποίηση του ψυγείου διότι μέσα εντοπίστηκαν 'ευαίσθητα' τρόφιμα. Αφαιρέστε τα τρόφιμα και προσπαθήστε ξανά."), "Προσοχή!", MessageBoxButtons.OK);
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
