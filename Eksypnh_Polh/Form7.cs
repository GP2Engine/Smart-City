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
    public partial class Form7 : Form
    {
        int count;
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.Hide();
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label1.Text = "60";
            label5.Text = "800";
            button7.BackColor = Color.Red;
            button7.Text = "OFF";
            count = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label1.Focus();
            int tem = Int32.Parse(label1.Text);
            if (tem < 90)
            {
                tem = tem + 5;
                string tex = tem.ToString();
                label1.Text = tex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label1.Focus();
            int tem = Int32.Parse(label1.Text);
            if (tem > 30)
            {
                tem = tem - 5;
                string tex = tem.ToString();
                label1.Text = tex;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label1.Focus();
            int tem = Int32.Parse(label5.Text);
            if (tem < 1000)
            {
                tem = tem + 50;
                string tex = tem.ToString();
                label5.Text = tex;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label1.Focus();
            int tem = Int32.Parse(label5.Text);
            if (tem > 400)
            {
                tem = tem - 50;
                string tex = tem.ToString();
                label5.Text = tex;
            }
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)  // Gia na xei full mauro background olo to combobox.
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.White;
            e.DrawBackground();
            e.Graphics.DrawString(comboBox1.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                GlobalClass.PlaySound3();
                MessageBox.Show(string.Format("Το βάρος των ρούχων υπερβαίνει το μέγιστο όριο βάρους του πλυντηρίου. Αφαιρέστε μερικά ρούχα και προσπαθήστε ξανά."), "Προσοχή!", MessageBoxButtons.OK);
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
