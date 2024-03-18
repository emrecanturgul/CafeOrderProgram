using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSiparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cayArtıLabel_Click(object sender, EventArgs e)
        {
            int _caySayisi = Convert.ToInt32(caySayısıLabel.Text);
            _caySayisi++;
            caySayısıLabel.Text = Convert.ToString(_caySayisi); 


        }
    }
}
