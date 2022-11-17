
namespace YANKEE9
{
    partial class YANKEE9Usuar
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
            System.Windows.Forms.Label cd_usuarLabel;
            System.Windows.Forms.Label nm_usuarLabel;
            System.Windows.Forms.Label sg_levelLabel;
            System.Windows.Forms.Label nm_loginLabel;
            System.Windows.Forms.Label cd_passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YANKEE9Usuar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.textcodigo = new System.Windows.Forms.TextBox();
            this.tbUsuarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdYANKEE9DataSet = new YANKEE9.BdYANKEE9DataSet();
            this.textnome = new System.Windows.Forms.TextBox();
            this.textlevel = new System.Windows.Forms.TextBox();
            this.textlogin = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.tbUsuarTableAdapter = new YANKEE9.BdYANKEE9DataSetTableAdapters.tbUsuarTableAdapter();
            this.tableAdapterManager = new YANKEE9.BdYANKEE9DataSetTableAdapters.TableAdapterManager();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            cd_usuarLabel = new System.Windows.Forms.Label();
            nm_usuarLabel = new System.Windows.Forms.Label();
            sg_levelLabel = new System.Windows.Forms.Label();
            nm_loginLabel = new System.Windows.Forms.Label();
            cd_passwordLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdYANKEE9DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_usuarLabel
            // 
            cd_usuarLabel.AutoSize = true;
            cd_usuarLabel.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_usuarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            cd_usuarLabel.Location = new System.Drawing.Point(35, 16);
            cd_usuarLabel.Name = "cd_usuarLabel";
            cd_usuarLabel.Size = new System.Drawing.Size(92, 36);
            cd_usuarLabel.TabIndex = 0;
            cd_usuarLabel.Text = "Codigo:";
            cd_usuarLabel.Click += new System.EventHandler(this.cd_usuarLabel_Click);
            // 
            // nm_usuarLabel
            // 
            nm_usuarLabel.AutoSize = true;
            nm_usuarLabel.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_usuarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            nm_usuarLabel.Location = new System.Drawing.Point(30, 61);
            nm_usuarLabel.Name = "nm_usuarLabel";
            nm_usuarLabel.Size = new System.Drawing.Size(83, 36);
            nm_usuarLabel.TabIndex = 2;
            nm_usuarLabel.Text = "Nome:";
            nm_usuarLabel.Click += new System.EventHandler(this.nm_usuarLabel_Click);
            // 
            // sg_levelLabel
            // 
            sg_levelLabel.AutoSize = true;
            sg_levelLabel.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_levelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            sg_levelLabel.Location = new System.Drawing.Point(30, 106);
            sg_levelLabel.Name = "sg_levelLabel";
            sg_levelLabel.Size = new System.Drawing.Size(72, 36);
            sg_levelLabel.TabIndex = 4;
            sg_levelLabel.Text = "Nivel:";
            sg_levelLabel.Click += new System.EventHandler(this.sg_levelLabel_Click);
            // 
            // nm_loginLabel
            // 
            nm_loginLabel.AutoSize = true;
            nm_loginLabel.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            nm_loginLabel.Location = new System.Drawing.Point(30, 143);
            nm_loginLabel.Name = "nm_loginLabel";
            nm_loginLabel.Size = new System.Drawing.Size(78, 36);
            nm_loginLabel.TabIndex = 6;
            nm_loginLabel.Text = "Login:";
            nm_loginLabel.Click += new System.EventHandler(this.nm_loginLabel_Click);
            // 
            // cd_passwordLabel
            // 
            cd_passwordLabel.AutoSize = true;
            cd_passwordLabel.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            cd_passwordLabel.Location = new System.Drawing.Point(29, 182);
            cd_passwordLabel.Name = "cd_passwordLabel";
            cd_passwordLabel.Size = new System.Drawing.Size(84, 36);
            cd_passwordLabel.TabIndex = 8;
            cd_passwordLabel.Text = "Senha:";
            cd_passwordLabel.Click += new System.EventHandler(this.cd_passwordLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.groupBox1.Controls.Add(this.btsair);
            this.groupBox1.Controls.Add(this.btexcluir);
            this.groupBox1.Controls.Add(this.btimprimir);
            this.groupBox1.Controls.Add(this.btpesquisar);
            this.groupBox1.Controls.Add(this.btcancelar);
            this.groupBox1.Controls.Add(this.btsalvar);
            this.groupBox1.Controls.Add(this.btalterar);
            this.groupBox1.Controls.Add(this.btnovo);
            this.groupBox1.Controls.Add(this.btproximo);
            this.groupBox1.Controls.Add(this.btanterior);
            this.groupBox1.Controls.Add(cd_usuarLabel);
            this.groupBox1.Controls.Add(this.textcodigo);
            this.groupBox1.Controls.Add(nm_usuarLabel);
            this.groupBox1.Controls.Add(this.textnome);
            this.groupBox1.Controls.Add(sg_levelLabel);
            this.groupBox1.Controls.Add(this.textlevel);
            this.groupBox1.Controls.Add(nm_loginLabel);
            this.groupBox1.Controls.Add(this.textlogin);
            this.groupBox1.Controls.Add(cd_passwordLabel);
            this.groupBox1.Controls.Add(this.textpassword);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USERS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btsair
            // 
            this.btsair.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btsair.Location = new System.Drawing.Point(576, 351);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(93, 32);
            this.btsair.TabIndex = 19;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.Btsair_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btexcluir.Location = new System.Drawing.Point(576, 292);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(93, 32);
            this.btexcluir.TabIndex = 18;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.Btexcluir_Click);
            // 
            // btimprimir
            // 
            this.btimprimir.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btimprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btimprimir.Location = new System.Drawing.Point(457, 351);
            this.btimprimir.Name = "btimprimir";
            this.btimprimir.Size = new System.Drawing.Size(93, 32);
            this.btimprimir.TabIndex = 17;
            this.btimprimir.Text = "Imprimir";
            this.btimprimir.UseVisualStyleBackColor = true;
            this.btimprimir.Click += new System.EventHandler(this.Btimprimir_Click);
            // 
            // btpesquisar
            // 
            this.btpesquisar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btpesquisar.Location = new System.Drawing.Point(329, 351);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(93, 32);
            this.btpesquisar.TabIndex = 16;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.Btpesquisar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btcancelar.Location = new System.Drawing.Point(203, 351);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(93, 32);
            this.btcancelar.TabIndex = 15;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.Btcancelar_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btsalvar.Location = new System.Drawing.Point(83, 351);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(93, 32);
            this.btsalvar.TabIndex = 14;
            this.btsalvar.Text = "Salvar";
            this.btsalvar.UseVisualStyleBackColor = true;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // btalterar
            // 
            this.btalterar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btalterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btalterar.Location = new System.Drawing.Point(457, 292);
            this.btalterar.Name = "btalterar";
            this.btalterar.Size = new System.Drawing.Size(93, 32);
            this.btalterar.TabIndex = 13;
            this.btalterar.Text = "Alterar";
            this.btalterar.UseVisualStyleBackColor = true;
            this.btalterar.Click += new System.EventHandler(this.Btalterar_Click);
            // 
            // btnovo
            // 
            this.btnovo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btnovo.Location = new System.Drawing.Point(329, 292);
            this.btnovo.Name = "btnovo";
            this.btnovo.Size = new System.Drawing.Size(93, 32);
            this.btnovo.TabIndex = 12;
            this.btnovo.Text = "Novo";
            this.btnovo.UseVisualStyleBackColor = true;
            this.btnovo.Click += new System.EventHandler(this.btnovo_Click);
            // 
            // btproximo
            // 
            this.btproximo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btproximo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btproximo.Location = new System.Drawing.Point(203, 292);
            this.btproximo.Name = "btproximo";
            this.btproximo.Size = new System.Drawing.Size(93, 32);
            this.btproximo.TabIndex = 11;
            this.btproximo.Text = "Proximo";
            this.btproximo.UseVisualStyleBackColor = true;
            this.btproximo.Click += new System.EventHandler(this.Btproximo_Click);
            // 
            // btanterior
            // 
            this.btanterior.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btanterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btanterior.Location = new System.Drawing.Point(83, 292);
            this.btanterior.Name = "btanterior";
            this.btanterior.Size = new System.Drawing.Size(93, 32);
            this.btanterior.TabIndex = 10;
            this.btanterior.Text = "Anterior";
            this.btanterior.UseVisualStyleBackColor = true;
            this.btanterior.Click += new System.EventHandler(this.Btanterior_Click);
            // 
            // textcodigo
            // 
            this.textcodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarBindingSource, "cd_usuar", true));
            this.textcodigo.Location = new System.Drawing.Point(133, 28);
            this.textcodigo.Name = "textcodigo";
            this.textcodigo.Size = new System.Drawing.Size(61, 20);
            this.textcodigo.TabIndex = 1;
            this.textcodigo.TextChanged += new System.EventHandler(this.cd_usuarTextBox_TextChanged);
            // 
            // tbUsuarBindingSource
            // 
            this.tbUsuarBindingSource.DataMember = "tbUsuar";
            this.tbUsuarBindingSource.DataSource = this.bdYANKEE9DataSet;
            // 
            // bdYANKEE9DataSet
            // 
            this.bdYANKEE9DataSet.DataSetName = "BdYANKEE9DataSet";
            this.bdYANKEE9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textnome
            // 
            this.textnome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarBindingSource, "nm_usuar", true));
            this.textnome.Location = new System.Drawing.Point(119, 73);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(250, 20);
            this.textnome.TabIndex = 3;
            this.textnome.TextChanged += new System.EventHandler(this.nm_usuarTextBox_TextChanged);
            // 
            // textlevel
            // 
            this.textlevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarBindingSource, "sg_level", true));
            this.textlevel.Location = new System.Drawing.Point(119, 118);
            this.textlevel.Name = "textlevel";
            this.textlevel.Size = new System.Drawing.Size(75, 20);
            this.textlevel.TabIndex = 5;
            this.textlevel.TextChanged += new System.EventHandler(this.sg_levelTextBox_TextChanged);
            // 
            // textlogin
            // 
            this.textlogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarBindingSource, "nm_login", true));
            this.textlogin.Location = new System.Drawing.Point(119, 155);
            this.textlogin.Name = "textlogin";
            this.textlogin.Size = new System.Drawing.Size(230, 20);
            this.textlogin.TabIndex = 7;
            this.textlogin.TextChanged += new System.EventHandler(this.nm_loginTextBox_TextChanged);
            // 
            // textpassword
            // 
            this.textpassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarBindingSource, "cd_password", true));
            this.textpassword.Location = new System.Drawing.Point(119, 194);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(230, 20);
            this.textpassword.TabIndex = 9;
            this.textpassword.TextChanged += new System.EventHandler(this.cd_passwordTextBox_TextChanged);
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
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // YANKEE9Usuar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "YANKEE9Usuar";
            this.Text = "YANKEE9Usuar";
            this.Load += new System.EventHandler(this.YANKEE9Usuar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdYANKEE9DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BdYANKEE9DataSet bdYANKEE9DataSet;
        private System.Windows.Forms.BindingSource tbUsuarBindingSource;
        private BdYANKEE9DataSetTableAdapters.tbUsuarTableAdapter tbUsuarTableAdapter;
        private BdYANKEE9DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textcodigo;
        private System.Windows.Forms.TextBox textnome;
        private System.Windows.Forms.TextBox textlevel;
        private System.Windows.Forms.TextBox textlogin;
        private System.Windows.Forms.TextBox textpassword;
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
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}