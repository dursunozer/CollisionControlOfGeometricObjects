using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDPOdev2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarpisma_Click(object sender, EventArgs e)
        {
            Carpistirma carpistirma = new Carpistirma();
            carpistirma.ShowDialog();
        }

        private void btnCizdirme_Click(object sender, EventArgs e)
        {
            Cizdirme Cizdirme = new Cizdirme();
            Cizdirme.ShowDialog();
        }
    }
}
