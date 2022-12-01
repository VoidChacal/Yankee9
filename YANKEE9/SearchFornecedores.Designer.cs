namespace YANKEE9
{
    partial class SearchFornecedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchFornecedores));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbProviderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbProviderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdYANKEE9DataSet = new YANKEE9.BdYANKEE9DataSet();
            this.pesquisar = new System.Windows.Forms.Button();
            this.textname = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProviderTableAdapter = new YANKEE9.BdYANKEE9DataSetTableAdapters.tbProviderTableAdapter();
            this.tableAdapterManager = new YANKEE9.BdYANKEE9DataSetTableAdapters.TableAdapterManager();
            this.tbProviderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbProviderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProviderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProviderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdYANKEE9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProviderBindingNavigator)).BeginInit();
            this.tbProviderBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.groupBox1.Controls.Add(this.sair);
            this.groupBox1.Controls.Add(this.tbProviderDataGridView);
            this.groupBox1.Controls.Add(this.pesquisar);
            this.groupBox1.Controls.Add(this.textname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tbProviderDataGridView
            // 
            this.tbProviderDataGridView.AllowUserToAddRows = false;
            this.tbProviderDataGridView.AllowUserToDeleteRows = false;
            this.tbProviderDataGridView.AutoGenerateColumns = false;
            this.tbProviderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbProviderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.cd_telephone});
            this.tbProviderDataGridView.DataSource = this.tbProviderBindingSource;
            this.tbProviderDataGridView.Location = new System.Drawing.Point(22, 112);
            this.tbProviderDataGridView.Name = "tbProviderDataGridView";
            this.tbProviderDataGridView.ReadOnly = true;
            this.tbProviderDataGridView.Size = new System.Drawing.Size(525, 276);
            this.tbProviderDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nm_provider";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nm_address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cd_cellphone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // cd_telephone
            // 
            this.cd_telephone.DataPropertyName = "cd_telephone";
            this.cd_telephone.HeaderText = "Telefone";
            this.cd_telephone.Name = "cd_telephone";
            this.cd_telephone.ReadOnly = true;
            // 
            // tbProviderBindingSource
            // 
            this.tbProviderBindingSource.DataMember = "tbProvider";
            this.tbProviderBindingSource.DataSource = this.bdYANKEE9DataSet;
            // 
            // bdYANKEE9DataSet
            // 
            this.bdYANKEE9DataSet.DataSetName = "BdYANKEE9DataSet";
            this.bdYANKEE9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pesquisar
            // 
            this.pesquisar.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.pesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.pesquisar.Location = new System.Drawing.Point(449, 52);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(98, 35);
            this.pesquisar.TabIndex = 5;
            this.pesquisar.Text = "Pesquisar";
            this.pesquisar.UseVisualStyleBackColor = true;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(95, 53);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(345, 26);
            this.textname.TabIndex = 4;
            this.textname.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // tbProviderTableAdapter
            // 
            this.tbProviderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClientTableAdapter = null;
            this.tableAdapterManager.tbProductTableAdapter = null;
            this.tableAdapterManager.tbProviderTableAdapter = this.tbProviderTableAdapter;
            this.tableAdapterManager.tbUsuarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = YANKEE9.BdYANKEE9DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbProviderBindingNavigator
            // 
            this.tbProviderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbProviderBindingNavigator.BindingSource = this.tbProviderBindingSource;
            this.tbProviderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbProviderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbProviderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbProviderBindingNavigatorSaveItem});
            this.tbProviderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbProviderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbProviderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbProviderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbProviderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbProviderBindingNavigator.Name = "tbProviderBindingNavigator";
            this.tbProviderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbProviderBindingNavigator.Size = new System.Drawing.Size(616, 25);
            this.tbProviderBindingNavigator.TabIndex = 1;
            this.tbProviderBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbProviderBindingNavigatorSaveItem
            // 
            this.tbProviderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbProviderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbProviderBindingNavigatorSaveItem.Image")));
            this.tbProviderBindingNavigatorSaveItem.Name = "tbProviderBindingNavigatorSaveItem";
            this.tbProviderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbProviderBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tbProviderBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbProviderBindingNavigatorSaveItem_Click);
            // 
            // sair
            // 
            this.sair.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.sair.Location = new System.Drawing.Point(232, 404);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(98, 35);
            this.sair.TabIndex = 6;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            // 
            // SearchFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(616, 502);
            this.Controls.Add(this.tbProviderBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchFornecedores";
            this.Text = "SearchFornecedores";
            this.Load += new System.EventHandler(this.SearchFornecedores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProviderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProviderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdYANKEE9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProviderBindingNavigator)).EndInit();
            this.tbProviderBindingNavigator.ResumeLayout(false);
            this.tbProviderBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textname;
        private System.Windows.Forms.Button pesquisar;
        private BdYANKEE9DataSet bdYANKEE9DataSet;
        private System.Windows.Forms.BindingSource tbProviderBindingSource;
        private BdYANKEE9DataSetTableAdapters.tbProviderTableAdapter tbProviderTableAdapter;
        private BdYANKEE9DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbProviderBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbProviderBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tbProviderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_telephone;
        private System.Windows.Forms.Button sair;
    }
}