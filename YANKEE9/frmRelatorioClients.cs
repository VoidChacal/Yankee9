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
    public partial class frmRelatorioClients : Form
    {
        public frmRelatorioClients()
        {
            InitializeComponent();
        }

        private void frmRelatorioClients_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'BdYANKEE9DataSet.tbClient'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClientTableAdapter.Fill(this.BdYANKEE9DataSet.tbClient);

            this.reportViewer1.RefreshReport();
        }
    }
}
