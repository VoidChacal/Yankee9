namespace YANKEE9
{
    partial class search
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
            this.label1 = new System.Windows.Forms.Label();
            this.bdYANKEE9DataSet = new YANKEE9.BdYANKEE9DataSet();
            this.tbUsuarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsuarTableAdapter = new YANKEE9.BdYANKEE9DataSetTableAdapters.tbUsuarTableAdapter();
            this.tableAdapterManager = new YANKEE9.BdYANKEE9DataSetTableAdapters.TableAdapterManager();
            this.tbUsuarDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textname = new System.Windows.Forms.RichTextBox();
            this.pesquisar = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdYANKEE9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // bdYANKEE9DataSet
            // 
            this.bdYANKEE9DataSet.DataSetName = "BdYANKEE9DataSet";
            this.bdYANKEE9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUsuarBindingSource
            // 
            this.tbUsuarBindingSource.DataMember = "tbUsuar";
            this.tbUsuarBindingSource.DataSource = this.bdYANKEE9DataSet;
            this.tbUsuarBindingSource.CurrentChanged += new System.EventHandler(this.TbUsuarBindingSource_CurrentChanged);
            // 
            // tbUsuarTableAdapter
            // 
            this.tbUsuarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClientTableAdapter = null;
            this.tableAdapterManager.tbProductTableAdapter = null;
            this.tableAdapterManager.tbProviderTableAdapter = null;
            this.tableAdapterManager.tbUsuarTableAdapter = this.tbUsuarTableAdapter;
            this.tableAdapterManager.UpdateOrder = YANKEE9.BdYANKEE9DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbUsuarDataGridView
            // 
            this.tbUsuarDataGridView.AllowUserToAddRows = false;
            this.tbUsuarDataGridView.AllowUserToDeleteRows = false;
            this.tbUsuarDataGridView.AutoGenerateColumns = false;
            this.tbUsuarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbUsuarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tbUsuarDataGridView.DataSource = this.tbUsuarBindingSource;
            this.tbUsuarDataGridView.Location = new System.Drawing.Point(31, 115);
            this.tbUsuarDataGridView.Name = "tbUsuarDataGridView";
            this.tbUsuarDataGridView.ReadOnly = true;
            this.tbUsuarDataGridView.Size = new System.Drawing.Size(540, 344);
            this.tbUsuarDataGridView.TabIndex = 2;
            this.tbUsuarDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TbUsuarDataGridView_CellContentClick);
            this.tbUsuarDataGridView.DoubleClick += new System.EventHandler(this.TbUsuarDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_usuar";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nm_usuar";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 380;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(114, 61);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(345, 26);
            this.textname.TabIndex = 3;
            this.textname.Text = "";
            this.textname.TextChanged += new System.EventHandler(this.textname_TextChanged);
            // 
            // pesquisar
            // 
            this.pesquisar.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.pesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.pesquisar.Location = new System.Drawing.Point(473, 55);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(98, 35);
            this.pesquisar.TabIndex = 4;
            this.pesquisar.Text = "Pesquisar";
            this.pesquisar.UseVisualStyleBackColor = true;
            this.pesquisar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // sair
            // 
            this.sair.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.sair.Location = new System.Drawing.Point(256, 465);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(98, 35);
            this.sair.TabIndex = 5;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(626, 515);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.pesquisar);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.tbUsuarDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "search";
            this.Text = "search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdYANKEE9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BdYANKEE9DataSet bdYANKEE9DataSet;
        private System.Windows.Forms.BindingSource tbUsuarBindingSource;
        private BdYANKEE9DataSetTableAdapters.tbUsuarTableAdapter tbUsuarTableAdapter;
        private BdYANKEE9DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbUsuarDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.RichTextBox textname;
        private System.Windows.Forms.Button pesquisar;
        private System.Windows.Forms.Button sair;
    }
}