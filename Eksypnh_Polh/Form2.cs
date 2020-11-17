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
    public partial class Form2 : Form
    {
        public Form2()
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
            MessageBox.Show(string.Format("Για να προχωρήσετε επιλέξτε την λειτουργία που σας εξυπηρετεί κάνοντας κλίκ στο κατάλληλο κουμπί. Για τον απομακρυσμένο έλεγχο του σπιτιού σας πατήστε το κουμπί 'Έξυπνος έλεγχος σπιτιού' ενώ για την οργάνωση του πλάνου της ημέρας σας το 'Έξυπνο πλάνο ημέρας'."), "Βοήθεια", MessageBoxButtons.OK);
            this.label2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.Hide();
            Form5 form5 = new Form5();
            form5.ShowDialog();
            this.Close();
        }
    }
}
