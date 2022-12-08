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
    public partial class search : Form
    {
        private int Codigo;
        public int getCodigo()
        {
            return Codigo;
        }
        public search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdYANKEE9DataSet.tbUsuar'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarTableAdapter.Fill(this.bdYANKEE9DataSet.tbUsuar);

        }

        private void TbUsuarBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void TbUsuarBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textname.Text == "")
            {
                this.tbUsuarTableAdapter.Fill(this.bdYANKEE9DataSet.tbUsuar);
            }
            else
            {
                this.tbUsuarTableAdapter.FillByname(this.bdYANKEE9DataSet.tbUsuar, "%" + textname.Text + "%");
            }
        }

        private void TbUsuarDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TbUsuarDataGridView_DoubleClick(object sender, EventArgs e)
        {
            Codigo = int.Parse(tbUsuarDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Codigo = 0;
            Close();
        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
