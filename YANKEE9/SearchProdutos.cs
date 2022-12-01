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
    public partial class SearchProdutos : Form
    {
        public SearchProdutos()
        {
            InitializeComponent();
        }

        private void tbProductBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbProductBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdYANKEE9DataSet);

        }

        private void SearchProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdYANKEE9DataSet.tbProduct'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProductTableAdapter.Fill(this.bdYANKEE9DataSet.tbProduct);

        }
    }
}
