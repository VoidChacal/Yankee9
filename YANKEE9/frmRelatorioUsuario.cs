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
    public partial class frmRelatorioUsuario : Form
    {
        public frmRelatorioUsuario()
        {
            InitializeComponent();
        }

        private void frmRelatorioUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'BdYANKEE9DataSet.tbUsuar'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarTableAdapter.Fill(this.BdYANKEE9DataSet.tbUsuar);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
