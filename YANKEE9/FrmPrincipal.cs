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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Btusuar_Click(object sender, EventArgs e)
        {
            YANKEE9Usuar fu = new YANKEE9Usuar();
            fu.ShowDialog();
        }

        private void Relusuarios_Click(object sender, EventArgs e)
        {
            frmRelatorioUsuario fu = new frmRelatorioUsuario();
            fu.ShowDialog();
        }

        private void Relcliente_Click(object sender, EventArgs e)
        {
            frmRelatorioClients fu = new frmRelatorioClients();
            fu.ShowDialog();
        }

        private void Relfornecedores_Click(object sender, EventArgs e)
        {
            frmRelatorioProvider fu = new frmRelatorioProvider();
            fu.ShowDialog();
        }

        private void Relprodutos_Click(object sender, EventArgs e)
        {
           
        }

        private void Btcliente_Click(object sender, EventArgs e)
        {
            clients fu = new clients();
            fu.ShowDialog();
        }

        private void Btfornecedores_Click(object sender, EventArgs e)
        {
            Fornecedores fu = new Fornecedores();
            fu.ShowDialog();
        }

        private void Produtos_Click(object sender, EventArgs e)
        {
            Produtos fu = new Produtos();
            fu.ShowDialog();
        }
    }
}
