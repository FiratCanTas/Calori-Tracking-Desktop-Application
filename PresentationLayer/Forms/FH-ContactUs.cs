using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class FH_ContactUs : Form
    {
        public FH_ContactUs()
        {
            InitializeComponent();
        }

        private void btnIletiGönder_Click(object sender, EventArgs e)
        {
            FH_MainPage.fH_SignIn.Show();
            this.Close();
        }
    }
}
