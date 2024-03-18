using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSiparisProgram
{
    public partial class SiparisForm : Form
    {
        int _caySayisi = 0;
        int _kahveSayisi = 0;
        int _kolaSayisi = 0 ; 

        public SiparisForm()
        {
            InitializeComponent();
        }

        

        private void kahveArtıButton_Click(object sender, EventArgs e)
        {
            
            _kahveSayisi++;
            kahveSayisiLabel.Text = Convert.ToString(_kahveSayisi); 

        }

        private void kahveEksiButton_Click(object sender, EventArgs e)
        {
             
            if (_kahveSayisi > 0)
            {
                _kahveSayisi--; 

            }
            kahveSayisiLabel.Text = Convert.ToString(_kahveSayisi);
        }

        private void kolaEksiButton_Click(object sender, EventArgs e)
        {
            
            if (_kolaSayisi > 0)
            {
                _kolaSayisi--;

            }
            kolaSayısıLabel.Text = Convert.ToString(_kolaSayisi);
        }

        private void kolaArtıButton_Click(object sender, EventArgs e)
        {
            
            _kolaSayisi++;
            kolaSayısıLabel.Text = Convert.ToString(_kolaSayisi);
        }

        private void cayArtıButton_Click(object sender, EventArgs e)
        {
            
            _caySayisi++;
            caySayısıLabel.Text = Convert.ToString(_caySayisi); 
        }

        private void cayEksiButton_Click(object sender, EventArgs e)
        {
            
            if(_caySayisi > 0)
            {
                _caySayisi--; 

            }
            caySayısıLabel.Text = Convert.ToString(_caySayisi); 
        }

        private void sıfırlaButon_Click(object sender, EventArgs e)
        {
            _caySayisi = 0; 
            _kahveSayisi = 0;
            _kolaSayisi = 0; 
            caySayısıLabel.Text = "0";
            kahveSayisiLabel.Text = "0";
            kolaSayısıLabel.Text = "0"; 
        }

        private void tamamlaButon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sipariş özeti \n" +caySayısıLabel.Text + " Çay \n "
                + kahveSayisiLabel.Text + " Kahve \n" + kolaSayısıLabel.Text + " Kola \n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void cikisButon_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
     
}
