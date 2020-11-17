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
    public partial class Form10 : Form
    {
        int count;
        int count2;
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.Hide();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                GlobalClass.PlaySound3();
                MessageBox.Show(string.Format("Οι λάμπες του χώλ είναι καμμένες. Αντικαταστήστε τις και προσπαθήστε ξανά."), "Προσοχή!", MessageBoxButtons.OK);
                count++;
            }
            else
            {
                GlobalClass.PlaySound();
                this.label1.Focus();

                if (button1.BackColor == Color.Red)
                {
                    button1.BackColor = Color.Lime;
                    button1.Text = "ON";
                }
                else
                {
                    button1.BackColor = Color.Red;
                    button1.Text = "OFF";
                }
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            button7.BackColor = Color.Red;
            button7.Text = "OFF";
            button1.BackColor = Color.Red;
            button1.Text = "OFF";
            button3.BackColor = Color.Red;
            button3.Text = "OFF";
            button4.BackColor = Color.Red;
            button4.Text = "OFF";
            button5.BackColor = Color.Red;
            button5.Text = "OFF";
            count = 0;
            count2 = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (count2 == 0)
            {
                GlobalClass.PlaySound3();
                MessageBox.Show(string.Format("Οι λάμπες της τουαλέτας είναι καμμένες. Αντικαταστήστε τις και προσπαθήστε ξανά."), "Προσοχή!", MessageBoxButtons.OK);
                count2++;
            }
            else
            {
                GlobalClass.PlaySound();
                this.label1.Focus();

                if (button5.BackColor == Color.Red)
                {
                    button5.BackColor = Color.Lime;
                    button5.Text = "ON";
                }
                else
                {
                    button5.BackColor = Color.Red;
                    button5.Text = "OFF";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label1.Focus();

            if (button3.BackColor == Color.Red)
            {
                button3.BackColor = Color.Lime;
                button3.Text = "ON";
            }
            else
            {
                button3.BackColor = Color.Red;
                button3.Text = "OFF";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label1.Focus();

            if (button4.BackColor == Color.Red)
            {
                button4.BackColor = Color.Lime;
                button4.Text = "ON";
            }
            else
            {
                button4.BackColor = Color.Red;
                button4.Text = "OFF";
            }
        }
    }
}
