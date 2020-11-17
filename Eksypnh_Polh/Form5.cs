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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound4();
            MessageBox.Show(string.Format("Για να ελέγξετε τη συσκευή του σπιτιού που επιθυμείτε κάντε κλίκ στο κουμπί που αντιστοιχεί σ'αυτήν και ρυθμίστε τις κατάλληλες παραμέτρους για την εκάστοτε συσκευή."), "Βοήθεια", MessageBoxButtons.OK);
            this.label2.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label2.Focus();
            Form6 form6 = new Form6();
            form6.ShowDialog();         
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label2.Focus();
            Form7 form7 = new Form7();
            form7.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label2.Focus();
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label2.Focus();
            Form10 form10 = new Form10();
            form10.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label2.Focus();
            Form11 form11 = new Form11();
            form11.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label2.Focus();
            Form9 form9 = new Form9();
            form9.ShowDialog();
        }
    }
}
