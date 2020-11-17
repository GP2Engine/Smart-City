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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.label2.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();      // Gia na kleinei to app otan kleinei kai h Form1.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound4();
            MessageBox.Show(string.Format("Για να εισαχθείτε θα πρέπει να πατήσετε το κατάλληλο κουμπί. Εαν είστε κάτοικος της έξυπνης πόλης κάντε κλίκ στο κουμπί 'Κατοίκους Πόλης' ενώ αν είστε υπάλληλος του δήμου στο 'Υπαλλήλους Δήμου'."), "Βοήθεια", MessageBoxButtons.OK);
            this.label2.Focus();
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
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }
    }
}
