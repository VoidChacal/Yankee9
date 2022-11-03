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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void habilitar()
        {
            textcode.Enabled = false;
            textname.Enabled = true;
            textunity.Enabled = true;
            textprice.Enabled = true;
            textsell.Enabled = true;
            textinventory.Enabled = true;
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
            textunity.Enabled = false;
            textprice.Enabled = false;
            textsell.Enabled = false;
            textinventory.Enabled = false;
            btsalvar.Enabled = false;
            btcancelar.Enabled = true;
            btanterior.Enabled = true;
            btproximo.Enabled = true;
            btnovo.Enabled = true;
            btalterar.Enabled = true;
            btimprimir.Enabled = true;
            btsair.Enabled = true;

        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdYANKEE9DataSet.tbProduct'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProductTableAdapter.Fill(this.bdYANKEE9DataSet.tbProduct);

        }

        private void Nm_productTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btanterior_Click(object sender, EventArgs e)
        {
            tbProductBindingSource.MovePrevious();
        }

        private void Btproximo_Click(object sender, EventArgs e)
        {
            tbProductBindingSource.MoveNext();
        }

        private void Btnovo_Click(object sender, EventArgs e)
        {
            tbProductBindingSource.AddNew();
        }

        private void Btalterar_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        private void Btexcluir_Click(object sender, EventArgs e)
        {
            tbProductBindingSource.RemoveCurrent();
        }

        private void Btsalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbProductBindingSource.EndEdit();
            tbProductTableAdapter.Update(bdYANKEE9DataSet.tbProduct);
            desabilitar();
        }

        private void Btcancelar_Click(object sender, EventArgs e)
        {
            tbProductBindingSource.RemoveCurrent();
        }

        private void Btsair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
