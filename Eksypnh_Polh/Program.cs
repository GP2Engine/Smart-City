using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
ALLHLEPIDRASH ANTHRWPOU KAI YPOLOGISTH
Apallaktikh Ergasia
Onoma: Anastasios
Epwnymo: Kollias
A.M: P14075
Eksamhno: 5 
Eksetash: 2/3/2017
*/

namespace Eksypnh_Polh
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());  // To programma ekkinei apo thn SplashScreen
        }
    }

    public static class GlobalClass   // Ftiaxnoume mia global klash pou na exei mesa mia global methodo gia to button click sound.
    {
        public static void PlaySound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "beep.wav";
            player.Load();
            player.Play();
        }

        public static void PlaySound2()  // Methodos gia to startup sound.
        {
            System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
            player2.SoundLocation = "startup.wav";
            player2.Load();
            player2.Play();
        }

        public static void PlaySound3()  // Methodos gia to error sound.
        {
            System.Media.SoundPlayer player3 = new System.Media.SoundPlayer();
            player3.SoundLocation = "error.wav";
            player3.Load();
            player3.Play();
        }

        public static void PlaySound4()  // Methodos gia to help sound.
        {
            System.Media.SoundPlayer player4 = new System.Media.SoundPlayer();
            player4.SoundLocation = "help.wav";
            player4.Load();
            player4.Play();
        }
    }


}
