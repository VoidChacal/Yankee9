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
    public partial class Searchclients : Form
    {
        public Searchclients()
        {
            InitializeComponent();
        }

        private void tbClientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdYANKEE9DataSet);

        }

        private void Searchclients_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdYANKEE9DataSet.tbClient'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClientTableAdapter.Fill(this.bdYANKEE9DataSet.tbClient);

        }

        private void tbClientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
