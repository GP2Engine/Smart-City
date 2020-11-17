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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            DateTime time = DateTime.Today;   // Briskoume tis wres apo twra (1 wra meta) kai ana misawra mexri tis 12 to bradi kai tis bazoume sto combobox2.
            for (DateTime _time = time.AddHours(DateTime.Now.AddHours(1).Hour); _time < time.AddHours(24); _time = _time.AddMinutes(30))
            {
                comboBox2.Items.Add(_time.ToShortTimeString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound4();
            MessageBox.Show(string.Format("Για να υπολογιστεί η διαδρομή σας θα πρέπει να συμπληρώσετε όλα τα ζητούμενα στοιχεία και να κάνετε κλίκ στο κουμπί 'Πλοήγηση'. Με το κουμπί 'Reset' γίνεται επαναφορά στην αρχική θέση και διαγράφονται όλα τα εισηγμένα στοιχεία."), "Βοήθεια", MessageBoxButtons.OK);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label4.Text= DateTime.Now.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalClass.PlaySound();

            if (comboBox1.SelectedItem == null) { GlobalClass.PlaySound3(); MessageBox.Show(string.Format("Επιλέξτε προορισμό."), "Προσοχή!", MessageBoxButtons.OK);  this.comboBox1.Focus(); }  // Elegxos gia adeia comboboxes.
            if (comboBox2.SelectedItem == null) { GlobalClass.PlaySound3(); MessageBox.Show(string.Format("Επιλέξτε ώρα άφιξης."), "Προσοχή!", MessageBoxButtons.OK); this.comboBox2.Focus(); }
            if (comboBox3.SelectedItem == null) { GlobalClass.PlaySound3(); MessageBox.Show(string.Format("Επιλέξτε τρόπο μετάβασης."), "Προσοχή!", MessageBoxButtons.OK);  this.comboBox3.Focus(); }

            if (comboBox1.Text=="Πανεπιστήμιο Πειραιώς" && comboBox2.SelectedItem!=null)   // Gia proorismo panepisthmio peiraiws.
            {
                DateTime dt = new DateTime();                // Pairnoume thn wra tou combobox2 kai thn metatrepoume apo string se DateTime gia na kanoume meta ypologismous.
                DateTime.TryParse(comboBox2.Text, out dt);

                if (comboBox3.Text== "Αυτοκίνητο")
                {
                    if (checkBox1.Checked)
                    {
                        DateTime ideal = dt.AddMinutes(-30);
                        int temp = DateTime.Compare(ideal, DateTime.Now);
                        if (temp < 0)      // Kanoume elegxo wste h proteinomenh idanikh wra ekkinishs na mhn einai prin thn trexousa wra.
                        {
                            GlobalClass.PlaySound3();
                            MessageBox.Show(string.Format("Δεν είναι εφικτή η μετάβασή σας στον συγκεκριμένο προορισμό με τον συγκεκριμένο τρόπο μετάβασης διότι δεν θα φτάσετε εγκαίρως. Επιλέξτε αργότερη ώρα ή διαφορετικό τρόπο μετάβασης."), "Προσοχή!", MessageBoxButtons.OK);
                            label1.Text = "Τρέχουσα τοποθεσία:";           // Girname kai merika pragmata se default state gia na diorthwsei o xrhsths ta "lathi" tou.
                            pictureBox1.ImageLocation = "current.jpg";
                            comboBox2.SelectedIndex = -1;
                            comboBox3.SelectedIndex = -1;
                        }
                        else
                        {
                            pictureBox1.ImageLocation = "aroutec2.jpg";
                            label1.Text = "Διαδρομή:";
                            MessageBox.Show(string.Format("Η διαδρομή σας μέχρι το Πανεπιστήμιο Πειραιώς με το αυτοκίνητο, συμπεριλαμβανομένης στάσης για καφέ στα 'Mikel' Πειραιά, θα διαρκέσει 30 λεπτά. Η κίνηση στους δρόμους είναι μέτρια και η κοντινότερη θέση στάθμευσης είναι στο parking του Πανεπιστημίου. Η ιδανική ώρα εκκίνησής σας θα είναι στις {0} .", ideal.ToShortTimeString()), "Υπολογισμός Διαδρομής", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        DateTime ideal = dt.AddMinutes(-28);
                        int temp = DateTime.Compare(ideal, DateTime.Now);
                        if (temp < 0)
                        {
                            GlobalClass.PlaySound3();
                            MessageBox.Show(string.Format("Δεν είναι εφικτή η μετάβασή σας στον συγκεκριμένο προορισμό με τον συγκεκριμένο τρόπο μετάβασης διότι δεν θα φτάσετε εγκαίρως. Επιλέξτε αργότερη ώρα ή διαφορετικό τρόπο μετάβασης."), "Προσοχή!", MessageBoxButtons.OK);
                            label1.Text = "Τρέχουσα τοποθεσία:";
                            pictureBox1.ImageLocation = "current.jpg";
                            comboBox2.SelectedIndex = -1;
                            comboBox3.SelectedIndex = -1;
                        }
                        else
                        {
                            pictureBox1.ImageLocation = "aroutec.jpg";
                            label1.Text = "Διαδρομή:";
                            MessageBox.Show(string.Format("Η διαδρομή σας μέχρι το Πανεπιστήμιο Πειραιώς με το αυτοκίνητο θα διαρκέσει 28 λεπτά. Η κίνηση στους δρόμους είναι μέτρια και η κοντινότερη θέση στάθμευσης είναι στο parking του Πανεπιστημίου. Η ιδανική ώρα εκκίνησής σας θα είναι στις {0} .", ideal.ToShortTimeString()), "Υπολογισμός Διαδρομής", MessageBoxButtons.OK);
                        }
                    }
                }

                if (comboBox3.Text == "Ηλεκτρικός / Μετρό")
                {
                    if (checkBox1.Checked)
                    {
                        DateTime ideal = dt.AddMinutes(-45);
                        int temp = DateTime.Compare(ideal, DateTime.Now);
                        if (temp < 0)
                        {
                            GlobalClass.PlaySound3();
                            MessageBox.Show(string.Format("Δεν είναι εφικτή η μετάβασή σας στον συγκεκριμένο προορισμό με τον συγκεκριμένο τρόπο μετάβασης διότι δεν θα φτάσετε εγκαίρως. Επιλέξτε αργότερη ώρα ή διαφορετικό τρόπο μετάβασης."), "Προσοχή!", MessageBoxButtons.OK);
                            label1.Text = "Τρέχουσα τοποθεσία:";
                            pictureBox1.ImageLocation = "current.jpg";
                            comboBox2.SelectedIndex = -1;
                            comboBox3.SelectedIndex = -1;
                        }
                        else
                        {
                            pictureBox1.ImageLocation = "aroutem2.jpg";
                            label1.Text = "Διαδρομή:";
                            MessageBox.Show(string.Format("Η διαδρομή σας μέχρι το Πανεπιστήμιο Πειραιώς με τον Ηλεκτρικό, συμπεριλαμβανομένης στάσης για καφέ στα 'Mikel' Πειραιά, θα διαρκέσει 45 λεπτά. Η γραμμή που σας εξυπηρετεί είναι η 1, από τον σταθμό 'Ομόνοια' μέχρι τον σταθμό 'Πειραιάς'. Εισιτήρια μπορείτε να προμηθευτείτε από τους σταθμούς. Η ιδανική ώρα εκκίνησής σας θα είναι στις {0} .", ideal.ToShortTimeString()), "Υπολογισμός Διαδρομής", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        DateTime ideal = dt.AddMinutes(-42);
                        int temp = DateTime.Compare(ideal, DateTime.Now);
                        if (temp < 0)
                        {
                            GlobalClass.PlaySound3();
                            MessageBox.Show(string.Format("Δεν είναι εφικτή η μετάβασή σας στον συγκεκριμένο προορισμό με τον συγκεκριμένο τρόπο μετάβασης διότι δεν θα φτάσετε εγκαίρως. Επιλέξτε αργότερη ώρα ή διαφορετικό τρόπο μετάβασης."), "Προσοχή!", MessageBoxButtons.OK);
                            label1.Text = "Τρέχουσα τοποθεσία:";
                            pictureBox1.ImageLocation = "current.jpg";
                            comboBox2.SelectedIndex = -1;
                            comboBox3.SelectedIndex = -1;
                        }
                        else
                        {
                            pictureBox1.ImageLocation = "aroutem.jpg";
                            label1.Text = "Διαδρομή:";
                            MessageBox.Show(string.Format("Η διαδρομή σας μέχρι το Πανεπιστήμιο Πειραιώς με τον Ηλεκτρικό θα διαρκέσει 42 λεπτά. Η γραμμή που σας εξυπηρετεί είναι η 1, από τον σταθμό 'Ομόνοια' μέχρι τον σταθμό 'Πειραιάς'. Εισιτήρια μπορείτε να προμηθευτείτε από τους σταθμούς. Η ιδανική ώρα εκκίνησής σας θα είναι στις {0} .", ideal.ToShortTimeString()), "Υπολογισμός Διαδρομής", MessageBoxButtons.OK);
                        }
                    }
                }

                if (comboBox3.Text == "Περπατώντας")
                {
                    if (checkBox1.Checked)
                    {
                        DateTime ideal = dt.AddMinutes(-114);
                        int temp = DateTime.Compare(ideal, DateTime.Now);
                        if (temp < 0)
                        {
                            GlobalClass.PlaySound3();
                            MessageBox.Show(string.Format("Δεν είναι εφικτή η μετάβασή σας στον συγκεκριμένο προορισμό με τον συγκεκριμένο τρόπο μετάβασης διότι δεν θα φτάσετε εγκαίρως. Επιλέξτε αργότερη ώρα ή διαφορετικό τρόπο μετάβασης."), "Προσοχή!", MessageBoxButtons.OK);
                            label1.Text = "Τρέχουσα τοποθεσία:";
                            pictureBox1.ImageLocation = "current.jpg";
                            comboBox2.SelectedIndex = -1;
                            comboBox3.SelectedIndex = -1;
                        }
                        else
                        {
                            pictureBox1.ImageLocation = "aroutew2.jpg";
                            label1.Text = "Διαδρομή:";
                            MessageBox.Show(string.Format("Η διαδρομή σας μέχρι το Πανεπιστήμιο Πειραιώς με τα πόδια, συμπεριλαμβανομένης στάσης για καφέ στα 'Mikel' Πειραιά, θα διαρκέσει 1 ώρα και 54 λεπτά. Η ιδανική ώρα εκκίνησής σας θα είναι στις {0} .", ideal.ToShortTimeString()), "Υπολογισμός Διαδρομής", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        DateTime ideal = dt.AddMinutes(-110);
                        int temp = DateTime.Compare(ideal, DateTime.Now);
                        if (temp < 0)
                        {
                            GlobalClass.PlaySound3();
                            MessageBox.Show(string.Format("Δεν είναι εφικτή η μετάβασή σας στον συγκεκριμένο προορισμό με τον συγκεκριμένο τρόπο μετάβασης διότι δεν θα φτάσετε εγκαίρως. Επιλέξτε αργότερη ώρα ή διαφορετικό τρόπο μετάβασης."), "Προσοχή!", MessageBoxButtons.OK);
                            label1.Text = "Τρέχουσα τοποθεσία:";
                            pictureBox1.ImageLocation = "current.jpg";
                            comboBox2.SelectedIndex = -1;
                            comboBox3.SelectedIndex = -1;
                        }
                        else
                        {
                            pictureBox1.ImageLocation = "aroutew.jpg";
                            label1.Text = "Διαδρομή:";
                            MessageBox.Show(string.Format("Η διαδρομή σας μέχρι το Πανεπιστήμιο Πειραιώς με τα πόδια θα διαρκέσει 1 ώρα και 50 λεπτά. Η ιδανική ώρα εκκίνησής σας θα είναι στις {0} .", ideal.ToShortTimeString()), "Υπολογισμός Διαδρομής", MessageBoxButtons.OK);
                        }
                    }
                }
            }

            if (comboBox1.Text == "Public Συντάγματος" && comboBox2.SelectedItem != null)   // Gia proorismo Public sintagmatos.
            {
                DateTime dt = new DateTime();                // Pairnoume thn wra tou combobox2 kai thn metatrepoume apo string se DateTime gia na kanoume meta ypologismous. (omoia me prin)
                DateTime.TryParse(comboBox2.Text, out dt);

                if (comboBox3.Text == "Αυτοκίνητο")
                {
                    if (checkBox1.Checked)
                    {
                        DateTime ideal = dt.AddMinutes(-8);
                        int temp = DateTime.Compare(ideal, DateTime.Now);
                        if (temp < 0)
                        {
                            GlobalClass.PlaySound3();
                            MessageBox.Show(string.Format("Δεν είναι εφικτή η μετάβασή σας στον συγκεκριμένο προορισμό με τον συγκεκριμένο τρόπο μετάβασης διότι δεν θα φτάσετε εγκαίρως. Επιλέξτε αργότερη ώρα ή διαφορετικό τρόπο μετάβασης."), "Προσοχή!", MessageBoxButtons.OK);
                            label1.Text = "Τρέχουσα τοποθεσία:";
                            pictureBox1.ImageLocation = "current.jpg";
                            comboBox2.SelectedIndex = -1;
                            comboBox3.SelectedIndex = -1;
                        }
                        else
                        {
                            pictureBox1.ImageLocation = "broutec2.jpg";
                            label1.Text = "Διαδρομή:";
                            MessageBox.Show(string.Format("Η διαδρομή σας μέχρι το Public Συντάγματος με το αυτοκίνητο, συμπεριλαμβανομένης στάσης για καφέ στα 'Coffee Island' Σταδίου, θα διαρκέσει 8 λεπτά. Η κίνηση στους δρόμους είναι χαμηλή και η κοντινότερη θέση στάθμευσης είναι, προς το παρών, διαθέσιμη στην οδό Καραγιώργης Σερβίας 10. Η ιδανική ώρα εκκίνησής σας θα είναι στις {0} .", ideal.ToShortTimeString()), "Υπολογισμός Διαδρομής", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        DateTime ideal = dt.AddMinutes(-5);
                        int temp = DateTime.Compare(ideal, DateTime.Now);
                        if (temp < 0)
                        {
                            GlobalClass.PlaySound3();
                            MessageBox.Show(string.Format("Δεν είναι εφικτή η μετάβασή σας στον συγκεκριμένο προορισμό με τον συγκεκριμένο τρόπο μετάβασης διότι δεν θα φτάσετε εγκαίρως. Επιλέξτε αργότερη ώρα ή διαφορετικό τρόπο μετάβασης."), "Προσοχή!", MessageBoxButtons.OK);
                            label1.Text = "Τρέχουσα τοποθεσία:";
                            pictureBox1.ImageLocation = "current.jpg";
                            comboBox2.SelectedIndex = -1;
                            comboBox3.SelectedIndex = -1;
                        }
                        else
                        {
                            pictureBox1.ImageLocation = "broutec.jpg";
                            label1.Text = "Διαδρομή:";
                            MessageBox.Show(string.Format("Η διαδρομή σας μέχρι το Public Συντάγματος με το αυτοκίνητο θα διαρκέσει 5 λεπτά. Η κίνηση στους δρόμους είναι χαμηλή και η κοντινότερη θέση στάθμευσης είναι, προς το παρών, διαθέσιμη στην οδό Καραγιώργης Σερβίας 10. Η ιδανική ώρα εκκίνησής σας θα είναι στις {0} .", ideal.ToShortTimeString()), "Υπολογισμός Διαδρομής", MessageBoxButtons.OK);
                        }
                    }
                }

                if (comboBox3.Text == "Ηλεκτρικός / Μετρό")
                {
                    if (checkBox1.Checked)
                    {
                        DateTime ideal = dt.AddMinutes(-8);
                        int temp = DateTime.Compare(ideal, DateTime.Now);
                        if (temp < 0)
                        {
                            GlobalClass.PlaySound3();
                            MessageBox.Show(string.Format("Δεν είναι εφικτή η μετάβασή σας στον συγκεκριμένο προορισμό με τον συγκεκριμένο τρόπο μετάβασης διότι δεν θα φτάσετε εγκαίρως. Επιλέξτε αργότερη ώρα ή διαφορετικό τρόπο μετάβασης."), "Προσοχή!", MessageBoxButtons.OK);
                            label1.Text = "Τρέχουσα τοποθεσία:";
                            pictureBox1.ImageLocation = "current.jpg";
                            comboBox2.SelectedIndex = -1;
                            comboBox3.SelectedIndex = -1;
                        }
                        else
                        {
                            pictureBox1.ImageLocation = "broutem2.jpg";
                            label1.Text = "Διαδρομή:";
                            MessageBox.Show(string.Format("Η διαδρομή σας μέχρι το Public Συντάγματος με τον Ηλεκτρικό, συμπεριλαμβανομένης στάσης για καφέ στα 'Coffee Island' Σταδίου, θα διαρκέσει 8 λεπτά. Η γραμμή που σας εξυπηρετεί είναι η 2, από τον σταθμό 'Πανεπιστήμιο' μέχρι τον σταθμό 'Σύνταγμα'. Εισιτήρια μπορείτε να προμηθευτείτε από τους σταθμούς. Η ιδανική ώρα εκκίνησής σας θα είναι στις {0} .", ideal.ToShortTimeString()), "Υπολογισμός Διαδρομής", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        DateTime ideal = dt.AddMinutes(-5);
                        int temp = DateTime.Compare(ideal, DateTime.Now);
                        if (temp < 0)
                        {
                            GlobalClass.PlaySound3();
                            MessageBox.Show(string.Format("Δεν είναι εφικτή η μετάβασή σας στον συγκεκριμένο προορισμό με τον συγκεκριμένο τρόπο μετάβασης διότι δεν θα φτάσετε εγκαίρως. Επιλέξτε αργότερη ώρα ή διαφορετικό τρόπο μετάβασης."), "Προσοχή!", MessageBoxButtons.OK);
                            label1.Text = "Τρέχουσα τοποθεσία:";
                            pictureBox1.ImageLocation = "current.jpg";
                            comboBox2.SelectedIndex = -1;
                            comboBox3.SelectedIndex = -1;
                        }
                        else
                        {
                            pictureBox1.ImageLocation = "broutem.jpg";
                            label1.Text = "Διαδρομή:";
                            MessageBox.Show(string.Format("Η διαδρομή σας μέχρι το Public Συντάγματος με τον Ηλεκτρικό θα διαρκέσει 5 λεπτά. Η γραμμή που σας εξυπηρετεί είναι η 2, από τον σταθμό 'Πανεπιστήμιο' μέχρι τον σταθμό 'Σύνταγμα'. Εισιτήρια μπορείτε να προμηθευτείτε από τους σταθμούς. Η ιδανική ώρα εκκίνησής σας θα είναι στις {0} .", ideal.ToShortTimeString()), "Υπολογισμός Διαδρομής", MessageBoxButtons.OK);
                        }
                    }
                }

                if (comboBox3.Text == "Περπατώντας")
                {
                    if (checkBox1.Checked)
                    {
                        DateTime ideal = dt.AddMinutes(-13);
                        int temp = DateTime.Compare(ideal, DateTime.Now);
                        if (temp < 0)
                        {
                            GlobalClass.PlaySound3();
                            MessageBox.Show(string.Format("Δεν είναι εφικτή η μετάβασή σας στον συγκεκριμένο προορισμό με τον συγκεκριμένο τρόπο μετάβασης διότι δεν θα φτάσετε εγκαίρως. Επιλέξτε αργότερη ώρα ή διαφορετικό τρόπο μετάβασης."), "Προσοχή!", MessageBoxButtons.OK);
                            label1.Text = "Τρέχουσα τοποθεσία:";
                            pictureBox1.ImageLocation = "current.jpg";
                            comboBox2.SelectedIndex = -1;
                            comboBox3.SelectedIndex = -1;
                        }
                        else
                        {
                            pictureBox1.ImageLocation = "broutew2.jpg";
                            label1.Text = "Διαδρομή:";
                            MessageBox.Show(string.Format("Η διαδρομή σας μέχρι το Public Συντάγματος με τα πόδια, συμπεριλαμβανομένης στάσης για καφέ στα 'Coffee Island' Σταδίου, θα διαρκέσει 13 λεπτά. Η ιδανική ώρα εκκίνησής σας θα είναι στις {0} .", ideal.ToShortTimeString()), "Υπολογισμός Διαδρομής", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        DateTime ideal = dt.AddMinutes(-9);
                        int temp = DateTime.Compare(ideal, DateTime.Now);
                        if (temp < 0)
                        {
                            GlobalClass.PlaySound3();
                            MessageBox.Show(string.Format("Δεν είναι εφικτή η μετάβασή σας στον συγκεκριμένο προορισμό με τον συγκεκριμένο τρόπο μετάβασης διότι δεν θα φτάσετε εγκαίρως. Επιλέξτε αργότερη ώρα ή διαφορετικό τρόπο μετάβασης."), "Προσοχή!", MessageBoxButtons.OK);
                            label1.Text = "Τρέχουσα τοποθεσία:";
                            pictureBox1.ImageLocation = "current.jpg";
                            comboBox2.SelectedIndex = -1;
                            comboBox3.SelectedIndex = -1;
                        }
                        else
                        {
                            pictureBox1.ImageLocation = "broutew.jpg";
                            label1.Text = "Διαδρομή:";
                            MessageBox.Show(string.Format("Η διαδρομή σας μέχρι το Public Συντάγματος με τα πόδια θα διαρκέσει 9 λεπτά. Η ιδανική ώρα εκκίνησής σας θα είναι στις {0} .", ideal.ToShortTimeString()), "Υπολογισμός Διαδρομής", MessageBoxButtons.OK);
                        }
                    }
                }
            }

            this.label2.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.label2.Focus();
        }

        private void button6_Click(object sender, EventArgs e)  // Reset
        {
            GlobalClass.PlaySound();
            comboBox1.SelectedIndex = -1;  // default value sta comboboxes me -1 index.
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            checkBox1.Checked = false;
            label1.Text = "Τρέχουσα τοποθεσία:";
            pictureBox1.ImageLocation = "current.jpg";
            this.label2.Focus();
        }
    }
}