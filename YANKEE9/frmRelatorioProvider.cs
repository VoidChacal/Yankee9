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
    public partial class frmRelatorioProvider : Form
    {
        public frmRelatorioProvider()
        {
            InitializeComponent();
        }

        private void frmRelatorioProvider_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'BdYANKEE9DataSet.tbProvider'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProviderTableAdapter.Fill(this.BdYANKEE9DataSet.tbProvider);

            this.reportViewer1.RefreshReport();
        }
    }
}
