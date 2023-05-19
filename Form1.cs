using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace değikenlerin_kapsamı
{
    public partial class Form1 : Form
    {
        int sayac;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnArttır_Click(object sender, EventArgs e)
        {
            sayac++;
            lblSayac.Text = Convert.ToString(sayac);
        }

        private void btnazalt_Click(object sender, EventArgs e)
        {
            sayac--;
            lblSayac.Text = Convert.ToString(sayac);
        }
    }
}
