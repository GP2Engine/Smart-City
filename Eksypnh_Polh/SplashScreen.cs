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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            GlobalClass.PlaySound2();
        }

        Timer tmr;
        private void SplashScreen_Shown(object sender, EventArgs e) // Setarisma kai timers gia thn SplashScreen
        {
            tmr = new Timer();
            tmr.Interval = 3000;  // 3 deuterolepta menei h SplashScreen
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            tmr.Stop();
            Form1 mf = new Form1();
            mf.Show();
            this.Hide();
        }
    }
}
