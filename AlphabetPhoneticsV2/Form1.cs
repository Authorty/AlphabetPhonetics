using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphabetPhoneticsV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IWavePlayer waveOutDevice;
        AudioFileReader audioFileReader;
        WaveOut output = new WaveOut();
        string sourceLocation = @"C:\Users\Authorty\Desktop\AlphabetSounds";

        private void playSound(object sender)
        {
            Label lbl = (Label)sender;

            if (String.IsNullOrEmpty(comboBox1.Text.ToString()) || comboBox1.Text.ToString() == "Sound")
            {
                


                audioFileReader = new AudioFileReader(Path.Combine(sourceLocation, lbl.Text.ToString() + ".m4a"));
                output.Init(audioFileReader);
                output.Play();
            }
            if (comboBox1.Text.ToString() == "ABC")
            {
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Volume = 100;
                synthesizer.Rate = -2;
                synthesizer.Speak(lbl.Text);
            }
        }
        private void A_Click(object sender, EventArgs e)
        {
            playSound(sender);

        }

        private void B_Click(object sender, EventArgs e)
        {
            playSound(sender);

        }

        private void C_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void D_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void E_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void F_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void G_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void H_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void J_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void K_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void L_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void M_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void N_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void O_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void P_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void Q_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void S_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void T_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void U_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void V_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void W_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void X_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void label24_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void Z_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void I_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void R_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void EE_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void CH_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void TH_Click(object sender, EventArgs e)
        {
            playSound(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;
            synthesizer.Rate = -2;
            synthesizer.Speak(textBox1.Text.ToString());
        }
    }
}
  