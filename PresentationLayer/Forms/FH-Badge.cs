using PresentationLayer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FH_Badge : Form
    {
        public FH_Badge()
        {
            InitializeComponent();
        }

        //BURAYA ŞAHİN UZUN GÖNDERME YAPTI
        private void FH_Badge_FormClosed(object sender, FormClosedEventArgs e)
        {
            FH_SignIn.userMainPage.Show();
        }

        private void FH_Badge_Load(object sender, EventArgs e)
        {

        }
    }
}
