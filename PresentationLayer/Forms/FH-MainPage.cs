using DataAccessLayer.Context;
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
    public partial class FH_MainPage : Form
    {
        public FH_MainPage()
        {
            InitializeComponent();
        }

        public static FH_MainPage page;
        public static FH_SignUp fH_SignUp;
        public static FH_SignIn fH_SignIn;

        private void FH_MainPage_Load(object sender, EventArgs e)
        {
            page = this;
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            fH_SignUp = new FH_SignUp();
            fH_SignUp.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            fH_SignIn = new FH_SignIn();
            fH_SignIn.Show();
            this.Hide();
        }

        private void FH_MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}