using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Speech.AudioFormat;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Text_To_Speech_Source
{

    public partial class Form1 : Form
    {
       
        

        public Form1()
        {
            InitializeComponent();

            

        }
        SpeechSynthesizer reader = new SpeechSynthesizer();
        
            
        private void txtText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //foreach (InstalledVoice voice in reader.GetInstalledVoices())
            //{
            //VoiceInfo info = voice.VoiceInfo;
            //string AudioFormats = "";
            //foreach (SpeechAudioFormatInfo fmt in info.SupportedAudioFormats)
            //{
            //    AudioFormats += String.Format("{0}\n",
            //    fmt.EncodingFormat.ToString());
            //}
            //reader.SelectVoiceByHints(VoiceGender.Female);

            foreach (var voice in reader.GetInstalledVoices(new CultureInfo("vi-VN")))
            {
                var info = voice.VoiceInfo;
                reader.SelectVoice("Microsoft An Desktop");

            }

            reader.SetOutputToDefaultAudioDevice();



            if (txtText.Text != "")
            {
                reader.SpeakAsync(txtText.Text);

            }
            else
            {
                MessageBox.Show("Please enter text!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
       

private void btnPause_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                
                    reader.Pause();
                

            }    
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            if(reader != null)
                reader.Resume();
        }
    }
}
