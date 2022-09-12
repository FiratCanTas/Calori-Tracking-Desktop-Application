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
    public partial class FH_ComparingPage : Form
    {
        public FH_ComparingPage()
        {
            InitializeComponent();
        }

        private void FH_ComparingPage_Load(object sender, EventArgs e)
        {
            dtpRaporBaslangic.Value = dtpRaporBitis.Value.AddDays(-7);
        }

        private void FH_ComparingPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            FH_SignIn.userMainPage.Show();
        }
    }
}
