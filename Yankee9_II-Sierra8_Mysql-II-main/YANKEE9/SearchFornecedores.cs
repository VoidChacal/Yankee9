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
    public partial class SearchFornecedores : Form
    {
        public SearchFornecedores()
        {
            InitializeComponent();
        }

        private void tbProviderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbProviderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdYANKEE9DataSet);

        }

        private void SearchFornecedores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdYANKEE9DataSet.tbProvider'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProviderTableAdapter.Fill(this.bdYANKEE9DataSet.tbProvider);

        }
    }
}
