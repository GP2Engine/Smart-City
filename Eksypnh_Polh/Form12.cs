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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            this.Hide();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            MessageBox.Show(string.Format("Η κατάσταση του ηλικιωμένου που κατοικεί στο σπίτι 1 είναι OK."), "Κατάσταση OK", MessageBoxButtons.OK);
            this.label8.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound4();
            MessageBox.Show(string.Format("Ο ηλικιωμένος που κατοικεί στο σπίτι 2 ζήτησε προμήθεια τροφίμων."), "Ανάγκη Τροφίμων", MessageBoxButtons.OK);
            this.label8.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound4();
            MessageBox.Show(string.Format("Ο ηλικιωμένος που κατοικεί στο σπίτι 3 έπεσε ελαφρώς. Η κατάστασή του είναι OK αλλά ζήτησε σύντομη επίσκεψη ιατρού."), "Ανάγκη Ιατρού", MessageBoxButtons.OK);
            this.label8.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();
            MessageBox.Show(string.Format("Η κατάσταση της ηλικιωμένης που κατοικεί στο σπίτι 4 είναι OK."), "Κατάσταση OK", MessageBoxButtons.OK);
            this.label8.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound3();
            MessageBox.Show(string.Format("Η ηλικιωμένη που κατοικεί στο σπίτι 5 έπεσε και δεν έδωσε απάντηση! Έχει κληθεί ασθενοφόρο καθώς και οι άμεσοι συγγενείς της."), "Έκτακτη Κατάσταση!", MessageBoxButtons.OK);
            this.label8.Focus();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            timer1.Start();       
        }

        private void timer1_Tick(object sender, EventArgs e)  // Timer gia button 5 blink.
        {
            if (button5.BackColor == Color.Red)
            {
                button5.BackColor = Color.DimGray;
            }
            else
            {
                button5.BackColor = Color.Red;
            }
        }
    }
}
