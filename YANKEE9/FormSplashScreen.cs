using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace YANKEE9
{
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
            FormSplashScreen frmSplashScreen = new FormSplashScreen();
            frmSplashScreen.Show();
            Thread.Sleep(3000);
            frmSplashScreen.Close();
        }

        private void FormSplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
