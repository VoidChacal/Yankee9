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
    public partial class Fornecedores : Form
    {
        public Fornecedores()
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
            textie.Enabled = true;
            textcnpj.Enabled = true;
            textcep.Enabled = true;
            textstate.Enabled = true;
            textdistrict.Enabled = true;
            textaddress.Enabled = true;
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
            textie.Enabled = false;
            textcnpj.Enabled = false;
            textcep.Enabled = false;
            textstate.Enabled = false;
            textdistrict.Enabled = false;
            textaddress.Enabled = false;
            btsalvar.Enabled = false;
            btcancelar.Enabled = true;
            btanterior.Enabled = true;
            btproximo.Enabled = true;
            btnovo.Enabled = true;
            btalterar.Enabled = true;
            btimprimir.Enabled = true;
            btsair.Enabled = true;

        }

        private void Fornecedores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdYANKEE9DataSet.tbProvider'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProviderTableAdapter.Fill(this.bdYANKEE9DataSet.tbProvider);

        }

        private void Cd_providerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cd_providerLabel_Click(object sender, EventArgs e)
        {

        }

        private void Nm_districtTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nm_providerLabel_Click(object sender, EventArgs e)
        {

        }

        private void Nm_providerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nm_addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void Nm_addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cd_cellphoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void Cd_cellphoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nm_districtLabel_Click(object sender, EventArgs e)
        {

        }

        private void Nm_cityLabel_Click(object sender, EventArgs e)
        {

        }

        private void Nm_cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sg_stateLabel_Click(object sender, EventArgs e)
        {

        }

        private void Sg_stateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cd_cepLabel_Click(object sender, EventArgs e)
        {

        }

        private void Cd_telephoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void Cd_telephoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cd_cnpjLabel_Click(object sender, EventArgs e)
        {

        }

        private void Cd_cnpjTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cd_ieLabel_Click(object sender, EventArgs e)
        {

        }

        private void Cd_ieTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cd_cepTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btanterior_Click(object sender, EventArgs e)
        {
            tbProviderBindingSource.MovePrevious();
        }

        private void Btproximo_Click(object sender, EventArgs e)
        {
            tbProviderBindingSource.MovePrevious();
        }

        private void Btnovo_Click(object sender, EventArgs e)
        {
            tbProviderBindingSource.AddNew();
            habilitar();
        }

        private void Btalterar_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        private void Btexcluir_Click(object sender, EventArgs e)
        {
            tbProviderBindingSource.RemoveCurrent();
        }

        private void Btsalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbProviderBindingSource.EndEdit();
            tbProviderTableAdapter.Update(bdYANKEE9DataSet.tbProvider);
            desabilitar();
        }

        private void Btcancelar_Click(object sender, EventArgs e)
        {
            tbProviderBindingSource.RemoveCurrent();
        }

        private void Btsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string Dados;
            Graphics objImpressao = e.Graphics;

            Dados = "FICHA DO USUÁRIO" + (char)10 + (char)10;
            Dados = Dados + "----------------------------------------------------------------------------" + (char)10 + (char)10;
            Dados = Dados + "Código: " + textcode.Text + (char)10 + (char)10;
            Dados = Dados + "Nome: " + textname.Text + (char)10 + (char)10;
            Dados = Dados + "Celular: " + textcellphone.Text + (char)10 + (char)10;
            Dados = Dados + "Telephone: " + texttelephone.Text + (char)10 + (char)10;
            Dados = Dados + "Cidade: " + textcity.Text + (char)10 + (char)10;
            Dados = Dados + "Distrito: " + textdistrict.Text + (char)10 + (char)10;
            Dados = Dados + "CEP: " + textcep.Text + (char)10 + (char)10;
            Dados = Dados + "Codigo IE: " + textie.Text + (char)10 + (char)10;
            Dados = Dados + "CNPJ: " + textcnpj.Text;
            objImpressao.DrawString(Dados, new Font("Segoe Print", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }
    }
}
