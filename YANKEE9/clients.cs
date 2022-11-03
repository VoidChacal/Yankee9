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
    public partial class clients : Form
    {
        public clients()
        {
            InitializeComponent();
        }
        private void habilitar()
        {
            textcode.Enabled = false;
            textname.Enabled = true;
            textcity.Enabled = true;
            textcellphone.Enabled = true;
            texttelephone.Enabled = true;
            textcpf.Enabled = true;
            textrg.Enabled = true;
            textcep.Enabled = true;
            textstate.Enabled = true;
            textdistrict.Enabled = true;
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
            textcode.Enabled = false;
            textname.Enabled = false;
            textcity.Enabled = false;
            textcellphone.Enabled = false;
            texttelephone.Enabled = false;
            textcpf.Enabled = false;
            textrg.Enabled = false;
            textcep.Enabled = false;
            textstate.Enabled = false;
            textdistrict.Enabled = false;
            btsalvar.Enabled = false;
            btcancelar.Enabled = true;
            btanterior.Enabled = true;
            btproximo.Enabled = true;
            btnovo.Enabled = true;
            btalterar.Enabled = true;
            btimprimir.Enabled = true;
            btsair.Enabled = true;

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdYANKEE9DataSet.tbClient'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClientTableAdapter.Fill(this.bdYANKEE9DataSet.tbClient);

        }

        private void Cd_telephoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btanterior_Click(object sender, EventArgs e)
        {
            tbClientBindingSource.MovePrevious();
        }

        private void Btnovo_Click(object sender, EventArgs e)
        {
            tbClientBindingSource.AddNew();
            habilitar();
        }

        private void Btproximo_Click(object sender, EventArgs e)
        {
            tbClientBindingSource.MoveNext();
        }

        private void Btalterar_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        private void Btexcluir_Click(object sender, EventArgs e)
        {
            tbClientBindingSource.RemoveCurrent();
        }

        private void Btsalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbClientBindingSource.EndEdit();
            tbClientTableAdapter.Update(bdYANKEE9DataSet.tbClient);
            desabilitar();
        }

        private void Btcancelar_Click(object sender, EventArgs e)
        {
            tbClientBindingSource.RemoveCurrent();
        }

        private void Btpesquisar_Click(object sender, EventArgs e)
        {

        }

        private void Btsair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
