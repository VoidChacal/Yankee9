using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YANKEE9
{
    public partial class frmRelatorioProdutos : Form
    {
        public frmRelatorioProdutos()
        {
            InitializeComponent();
        }

        private void FrmRelatorioProdutos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
