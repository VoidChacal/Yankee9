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
    public partial class YANKEE9Usuar : Form
    {
        public YANKEE9Usuar()
        {
            InitializeComponent();
        }

        private void habilitar()
        {
            textcodigo.Enabled = false;
            textnome.Enabled = true;
            textlevel.Enabled = true;
            textlogin.Enabled = true;
            btsalvar.Enabled = true;
            btcancelar.Enabled = false;
            btanterior.Enabled = false;
            btproximo.Enabled = false;
            btnovo.Enabled = false;
            btalterar.Enabled = false;
            btimprimir.Enabled = false;
            btsair.Enabled = false;
        }
        private void desabilitar()
        {
            textcodigo.Enabled = false;
            textnome.Enabled = false;
            textlevel.Enabled = false;
            textlogin.Enabled = false;
            btsalvar.Enabled = false;
            btcancelar.Enabled = true;
            btanterior.Enabled = true;
            btproximo.Enabled = true;
            btnovo.Enabled = true;
            btalterar.Enabled = true;
            btimprimir.Enabled = true;
            btsair.Enabled = true;

        }
        private void YANKEE9Usuar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdYANKEE9DataSet.tbUsuar'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarTableAdapter.Fill(this.bdYANKEE9DataSet.tbUsuar);
            desabilitar();

        }

        private void cd_usuarLabel_Click(object sender, EventArgs e)
        {

        }

        private void cd_usuarTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nm_usuarLabel_Click(object sender, EventArgs e)
        {

        }

        private void nm_usuarTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sg_levelLabel_Click(object sender, EventArgs e)
        {

        }

        private void sg_levelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nm_loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void nm_loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cd_passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void cd_passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbUsuarBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnovo_Click(object sender, EventArgs e)
        {
            tbUsuarBindingSource.AddNew();
            habilitar();
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbUsuarBindingSource.EndEdit();
            tbUsuarTableAdapter.Update(bdYANKEE9DataSet.tbUsuar);
            desabilitar();
        }

        private void Btanterior_Click(object sender, EventArgs e)
        {
            tbUsuarBindingSource.MovePrevious();
        }

        private void Btproximo_Click(object sender, EventArgs e)
        {
            tbUsuarBindingSource.MoveNext();
        }

        private void Btalterar_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        private void Btexcluir_Click(object sender, EventArgs e)
        {
            tbUsuarBindingSource.RemoveCurrent();

        }

        private void Btcancelar_Click(object sender, EventArgs e)
        {
            tbUsuarBindingSource.CancelEdit();
            desabilitar();
        }

        private void Btsair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
