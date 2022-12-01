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
        private bool validacpf(string cpf)
        {
            bool resp = false;
            int dig1 = 0, dig2 = 0;
            dig1 += int.Parse(cpf.Substring(10, 1)) * 2;
            dig1 += int.Parse(cpf.Substring(9, 1)) * 3;
            dig1 += int.Parse(cpf.Substring(8, 1)) * 4;
            dig1 += int.Parse(cpf.Substring(6, 1)) * 5;
            dig1 += int.Parse(cpf.Substring(5, 1)) * 6;
            dig1 += int.Parse(cpf.Substring(4, 1)) * 7;
            dig1 += int.Parse(cpf.Substring(2, 1)) * 8;
            dig1 += int.Parse(cpf.Substring(1, 1)) * 9;
            dig1 += int.Parse(cpf.Substring(0, 1)) * 10;
            dig1 = dig1 % 11;
            dig1 = dig1 < 2 ? 0 : 11 - dig1;
            dig2 += int.Parse(cpf.Substring(12, 1)) * 2;
            dig2 += int.Parse(cpf.Substring(10, 1)) * 3;
            dig2 += int.Parse(cpf.Substring(9, 1)) * 4;
            dig2 += int.Parse(cpf.Substring(8, 1)) * 5;
            dig2 += int.Parse(cpf.Substring(6, 1)) * 6;
            dig2 += int.Parse(cpf.Substring(5, 1)) * 7;
            dig2 += int.Parse(cpf.Substring(4, 1)) * 8;
            dig2 += int.Parse(cpf.Substring(2, 1)) * 9;
            dig2 += int.Parse(cpf.Substring(1, 1)) * 10;
            dig2 += int.Parse(cpf.Substring(0, 1)) * 11;
            dig2 = dig2 % 11;
            dig2 = dig2 < 2 ? 0 : 11 - dig2;
            if (dig1 == int.Parse(cpf.Substring(12, 1)) && dig2 == int.Parse(cpf.Substring(13, 1)))
            {
                resp = true;
            }

            return resp;
        }
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

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cd_clientTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btimprimir_Click(object sender, EventArgs e)
        {
            

        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string Dados;
            Graphics objImpressao = e.Graphics;

            Dados = "FICHA DO USUÁRIO" + (char)10 + (char)10;
            Dados = Dados + "----------------------------------------------------------------------------" + (char)10 + (char)10;
            Dados = Dados + "Código: " + textcode.Text + (char)10 + (char)10;
            Dados = Dados + "Nome: " + textname.Text + (char)10 + (char)10;
            Dados = Dados + "Cidade: " + textcity.Text + (char)10 + (char)10;
            Dados = Dados + "Celular: " + textcellphone.Text + (char)10 + (char)10;
            Dados = Dados + "Telephone: " + texttelephone.Text + (char)10 + (char)10;
            Dados = Dados + "CPF: " + textcpf.Text + (char)10 + (char)10;
            Dados = Dados + "RG: " + textrg.Text + (char)10 + (char)10;
            Dados = Dados + "CEP: " + textcep.Text + (char)10 + (char)10;
            Dados = Dados + "state: " + textstate.Text + (char)10 + (char)10;
            Dados = Dados + "Distrito: " + textdistrict.Text;
            objImpressao.DrawString(Dados, new Font("Segoe Print", 12, FontStyle.Regular), Brushes.Black, 50, 50);  
        }
    }
}
