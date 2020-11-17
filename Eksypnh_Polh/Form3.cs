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
    public partial class Form3 : Form
    {
        public Form3()
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
            MessageBox.Show(string.Format("Για να προχωρήσετε στον έλεγχο της κατάστασης των ηλικιωμένων κάντε κλίκ στο κουμπί 'Έλεγχος Κατάστασης Ηλικιωμένων' ώστε να δείτε αναλυτικά την κατάσταση του καθενός."), "Βοήθεια", MessageBoxButtons.OK);
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

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.label2.Focus();
            Form12 form12 = new Form12();
            form12.ShowDialog();
        }
    }
}
