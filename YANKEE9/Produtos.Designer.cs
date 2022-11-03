namespace YANKEE9
{
    partial class Produtos
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
            System.Windows.Forms.Label cd_productLabel;
            System.Windows.Forms.Label nm_productLabel;
            System.Windows.Forms.Label sg_unityLabel;
            System.Windows.Forms.Label vl_priceLabel;
            System.Windows.Forms.Label vl_sellLabel;
            System.Windows.Forms.Label t;
            this.bdYANKEE9DataSet = new YANKEE9.BdYANKEE9DataSet();
            this.tbProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProductTableAdapter = new YANKEE9.BdYANKEE9DataSetTableAdapters.tbProductTableAdapter();
            this.tableAdapterManager = new YANKEE9.BdYANKEE9DataSetTableAdapters.TableAdapterManager();
            this.textcode = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textunity = new System.Windows.Forms.TextBox();
            this.textprice = new System.Windows.Forms.TextBox();
            this.textsell = new System.Windows.Forms.TextBox();
            this.textinventory = new System.Windows.Forms.TextBox();
            this.btsair = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btimprimir = new System.Windows.Forms.Button();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.btalterar = new System.Windows.Forms.Button();
            this.btnovo = new System.Windows.Forms.Button();
            this.btproximo = new System.Windows.Forms.Button();
            this.btanterior = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            cd_productLabel = new System.Windows.Forms.Label();
            nm_productLabel = new System.Windows.Forms.Label();
            sg_unityLabel = new System.Windows.Forms.Label();
            vl_priceLabel = new System.Windows.Forms.Label();
            vl_sellLabel = new System.Windows.Forms.Label();
            t = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdYANKEE9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdYANKEE9DataSet
            // 
            this.bdYANKEE9DataSet.DataSetName = "BdYANKEE9DataSet";
            this.bdYANKEE9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProductBindingSource
            // 
            this.tbProductBindingSource.DataMember = "tbProduct";
            this.tbProductBindingSource.DataSource = this.bdYANKEE9DataSet;
            // 
            // tbProductTableAdapter
            // 
            this.tbProductTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClientTableAdapter = null;
            this.tableAdapterManager.tbProductTableAdapter = this.tbProductTableAdapter;
            this.tableAdapterManager.tbProviderTableAdapter = null;
            this.tableAdapterManager.tbUsuarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = YANKEE9.BdYANKEE9DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cd_productLabel
            // 
            cd_productLabel.AutoSize = true;
            cd_productLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            cd_productLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            cd_productLabel.Location = new System.Drawing.Point(30, 59);
            cd_productLabel.Name = "cd_productLabel";
            cd_productLabel.Size = new System.Drawing.Size(86, 33);
            cd_productLabel.TabIndex = 1;
            cd_productLabel.Text = "Codigo:";
            // 
            // textcode
            // 
            this.textcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProductBindingSource, "cd_product", true));
            this.textcode.Location = new System.Drawing.Point(113, 69);
            this.textcode.Name = "textcode";
            this.textcode.Size = new System.Drawing.Size(66, 20);
            this.textcode.TabIndex = 2;
            // 
            // nm_productLabel
            // 
            nm_productLabel.AutoSize = true;
            nm_productLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            nm_productLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            nm_productLabel.Location = new System.Drawing.Point(30, 87);
            nm_productLabel.Name = "nm_productLabel";
            nm_productLabel.Size = new System.Drawing.Size(77, 33);
            nm_productLabel.TabIndex = 3;
            nm_productLabel.Text = "Nome:";
            // 
            // textname
            // 
            this.textname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProductBindingSource, "nm_product", true));
            this.textname.Location = new System.Drawing.Point(104, 97);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(188, 20);
            this.textname.TabIndex = 4;
            this.textname.TextChanged += new System.EventHandler(this.Nm_productTextBox_TextChanged);
            // 
            // sg_unityLabel
            // 
            sg_unityLabel.AutoSize = true;
            sg_unityLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            sg_unityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            sg_unityLabel.Location = new System.Drawing.Point(30, 115);
            sg_unityLabel.Name = "sg_unityLabel";
            sg_unityLabel.Size = new System.Drawing.Size(96, 33);
            sg_unityLabel.TabIndex = 5;
            sg_unityLabel.Text = "Unidade";
            // 
            // textunity
            // 
            this.textunity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProductBindingSource, "sg_unity", true));
            this.textunity.Location = new System.Drawing.Point(134, 125);
            this.textunity.Name = "textunity";
            this.textunity.Size = new System.Drawing.Size(132, 20);
            this.textunity.TabIndex = 6;
            // 
            // vl_priceLabel
            // 
            vl_priceLabel.AutoSize = true;
            vl_priceLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            vl_priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            vl_priceLabel.Location = new System.Drawing.Point(29, 145);
            vl_priceLabel.Name = "vl_priceLabel";
            vl_priceLabel.Size = new System.Drawing.Size(188, 33);
            vl_priceLabel.TabIndex = 7;
            vl_priceLabel.Text = "Valor de Compra:";
            // 
            // textprice
            // 
            this.textprice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProductBindingSource, "vl_price", true));
            this.textprice.Location = new System.Drawing.Point(219, 155);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(160, 20);
            this.textprice.TabIndex = 8;
            // 
            // vl_sellLabel
            // 
            vl_sellLabel.AutoSize = true;
            vl_sellLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            vl_sellLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            vl_sellLabel.Location = new System.Drawing.Point(385, 149);
            vl_sellLabel.Name = "vl_sellLabel";
            vl_sellLabel.Size = new System.Drawing.Size(172, 33);
            vl_sellLabel.TabIndex = 9;
            vl_sellLabel.Text = "Valor de Venda:";
            // 
            // textsell
            // 
            this.textsell.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProductBindingSource, "vl_sell", true));
            this.textsell.Location = new System.Drawing.Point(559, 158);
            this.textsell.Name = "textsell";
            this.textsell.Size = new System.Drawing.Size(160, 20);
            this.textsell.TabIndex = 10;
            // 
            // t
            // 
            t.AutoSize = true;
            t.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            t.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            t.Location = new System.Drawing.Point(30, 180);
            t.Name = "t";
            t.Size = new System.Drawing.Size(145, 33);
            t.TabIndex = 11;
            t.Text = "Armazenado:";
            // 
            // textinventory
            // 
            this.textinventory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProductBindingSource, "qt_inventory", true));
            this.textinventory.Location = new System.Drawing.Point(177, 190);
            this.textinventory.Name = "textinventory";
            this.textinventory.Size = new System.Drawing.Size(100, 20);
            this.textinventory.TabIndex = 12;
            // 
            // btsair
            // 
            this.btsair.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btsair.Location = new System.Drawing.Point(606, 338);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(93, 32);
            this.btsair.TabIndex = 50;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.Btsair_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btexcluir.Location = new System.Drawing.Point(606, 279);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(93, 32);
            this.btexcluir.TabIndex = 49;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.Btexcluir_Click);
            // 
            // btimprimir
            // 
            this.btimprimir.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btimprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btimprimir.Location = new System.Drawing.Point(487, 338);
            this.btimprimir.Name = "btimprimir";
            this.btimprimir.Size = new System.Drawing.Size(93, 32);
            this.btimprimir.TabIndex = 48;
            this.btimprimir.Text = "Imprimir";
            this.btimprimir.UseVisualStyleBackColor = true;
            // 
            // btpesquisar
            // 
            this.btpesquisar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btpesquisar.Location = new System.Drawing.Point(359, 338);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(93, 32);
            this.btpesquisar.TabIndex = 47;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = true;
            // 
            // btcancelar
            // 
            this.btcancelar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btcancelar.Location = new System.Drawing.Point(233, 338);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(93, 32);
            this.btcancelar.TabIndex = 46;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.Btcancelar_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btsalvar.Location = new System.Drawing.Point(113, 338);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(93, 32);
            this.btsalvar.TabIndex = 45;
            this.btsalvar.Text = "Salvar";
            this.btsalvar.UseVisualStyleBackColor = true;
            this.btsalvar.Click += new System.EventHandler(this.Btsalvar_Click);
            // 
            // btalterar
            // 
            this.btalterar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btalterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btalterar.Location = new System.Drawing.Point(487, 279);
            this.btalterar.Name = "btalterar";
            this.btalterar.Size = new System.Drawing.Size(93, 32);
            this.btalterar.TabIndex = 44;
            this.btalterar.Text = "Alterar";
            this.btalterar.UseVisualStyleBackColor = true;
            this.btalterar.Click += new System.EventHandler(this.Btalterar_Click);
            // 
            // btnovo
            // 
            this.btnovo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btnovo.Location = new System.Drawing.Point(359, 279);
            this.btnovo.Name = "btnovo";
            this.btnovo.Size = new System.Drawing.Size(93, 32);
            this.btnovo.TabIndex = 43;
            this.btnovo.Text = "Novo";
            this.btnovo.UseVisualStyleBackColor = true;
            this.btnovo.Click += new System.EventHandler(this.Btnovo_Click);
            // 
            // btproximo
            // 
            this.btproximo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btproximo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btproximo.Location = new System.Drawing.Point(233, 279);
            this.btproximo.Name = "btproximo";
            this.btproximo.Size = new System.Drawing.Size(93, 32);
            this.btproximo.TabIndex = 42;
            this.btproximo.Text = "Proximo";
            this.btproximo.UseVisualStyleBackColor = true;
            this.btproximo.Click += new System.EventHandler(this.Btproximo_Click);
            // 
            // btanterior
            // 
            this.btanterior.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btanterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btanterior.Location = new System.Drawing.Point(113, 279);
            this.btanterior.Name = "btanterior";
            this.btanterior.Size = new System.Drawing.Size(93, 32);
            this.btanterior.TabIndex = 41;
            this.btanterior.Text = "Anterior";
            this.btanterior.UseVisualStyleBackColor = true;
            this.btanterior.Click += new System.EventHandler(this.Btanterior_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.groupBox1.Controls.Add(cd_productLabel);
            this.groupBox1.Controls.Add(this.btsair);
            this.groupBox1.Controls.Add(this.textinventory);
            this.groupBox1.Controls.Add(this.btexcluir);
            this.groupBox1.Controls.Add(t);
            this.groupBox1.Controls.Add(this.btimprimir);
            this.groupBox1.Controls.Add(this.textsell);
            this.groupBox1.Controls.Add(this.btpesquisar);
            this.groupBox1.Controls.Add(vl_sellLabel);
            this.groupBox1.Controls.Add(this.btcancelar);
            this.groupBox1.Controls.Add(this.textprice);
            this.groupBox1.Controls.Add(this.btsalvar);
            this.groupBox1.Controls.Add(vl_priceLabel);
            this.groupBox1.Controls.Add(this.btalterar);
            this.groupBox1.Controls.Add(this.textunity);
            this.groupBox1.Controls.Add(this.btnovo);
            this.groupBox1.Controls.Add(sg_unityLabel);
            this.groupBox1.Controls.Add(this.btproximo);
            this.groupBox1.Controls.Add(this.textname);
            this.groupBox1.Controls.Add(this.btanterior);
            this.groupBox1.Controls.Add(nm_productLabel);
            this.groupBox1.Controls.Add(this.textcode);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 412);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Produtos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdYANKEE9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BdYANKEE9DataSet bdYANKEE9DataSet;
        private System.Windows.Forms.BindingSource tbProductBindingSource;
        private BdYANKEE9DataSetTableAdapters.tbProductTableAdapter tbProductTableAdapter;
        private BdYANKEE9DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textcode;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textunity;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.TextBox textsell;
        private System.Windows.Forms.TextBox textinventory;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btimprimir;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.Button btalterar;
        private System.Windows.Forms.Button btnovo;
        private System.Windows.Forms.Button btproximo;
        private System.Windows.Forms.Button btanterior;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}