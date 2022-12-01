namespace YANKEE9
{
    partial class Fornecedores
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
            System.Windows.Forms.Label cd_providerLabel;
            System.Windows.Forms.Label nm_providerLabel;
            System.Windows.Forms.Label nm_addressLabel;
            System.Windows.Forms.Label cd_cellphoneLabel;
            System.Windows.Forms.Label nm_districtLabel;
            System.Windows.Forms.Label nm_cityLabel;
            System.Windows.Forms.Label sg_stateLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label cd_telephoneLabel;
            System.Windows.Forms.Label cd_cnpjLabel;
            System.Windows.Forms.Label cd_ieLabel;
            this.bdYANKEE9DataSet = new YANKEE9.BdYANKEE9DataSet();
            this.tbProviderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProviderTableAdapter = new YANKEE9.BdYANKEE9DataSetTableAdapters.tbProviderTableAdapter();
            this.tableAdapterManager = new YANKEE9.BdYANKEE9DataSetTableAdapters.TableAdapterManager();
            this.textcode = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textaddress = new System.Windows.Forms.TextBox();
            this.textcellphone = new System.Windows.Forms.TextBox();
            this.textdistrict = new System.Windows.Forms.TextBox();
            this.textcity = new System.Windows.Forms.TextBox();
            this.textstate = new System.Windows.Forms.TextBox();
            this.textcep = new System.Windows.Forms.TextBox();
            this.texttelephone = new System.Windows.Forms.TextBox();
            this.textcnpj = new System.Windows.Forms.TextBox();
            this.textie = new System.Windows.Forms.TextBox();
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            cd_providerLabel = new System.Windows.Forms.Label();
            nm_providerLabel = new System.Windows.Forms.Label();
            nm_addressLabel = new System.Windows.Forms.Label();
            cd_cellphoneLabel = new System.Windows.Forms.Label();
            nm_districtLabel = new System.Windows.Forms.Label();
            nm_cityLabel = new System.Windows.Forms.Label();
            sg_stateLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            cd_telephoneLabel = new System.Windows.Forms.Label();
            cd_cnpjLabel = new System.Windows.Forms.Label();
            cd_ieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdYANKEE9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProviderBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cd_providerLabel
            // 
            cd_providerLabel.AutoSize = true;
            cd_providerLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            cd_providerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            cd_providerLabel.Location = new System.Drawing.Point(25, 29);
            cd_providerLabel.Name = "cd_providerLabel";
            cd_providerLabel.Size = new System.Drawing.Size(86, 33);
            cd_providerLabel.TabIndex = 1;
            cd_providerLabel.Text = "Codigo:";
            cd_providerLabel.Click += new System.EventHandler(this.Cd_providerLabel_Click);
            // 
            // nm_providerLabel
            // 
            nm_providerLabel.AutoSize = true;
            nm_providerLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            nm_providerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            nm_providerLabel.Location = new System.Drawing.Point(24, 59);
            nm_providerLabel.Name = "nm_providerLabel";
            nm_providerLabel.Size = new System.Drawing.Size(77, 33);
            nm_providerLabel.TabIndex = 3;
            nm_providerLabel.Text = "Nome:";
            nm_providerLabel.Click += new System.EventHandler(this.Nm_providerLabel_Click);
            // 
            // nm_addressLabel
            // 
            nm_addressLabel.AutoSize = true;
            nm_addressLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            nm_addressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            nm_addressLabel.Location = new System.Drawing.Point(24, 91);
            nm_addressLabel.Name = "nm_addressLabel";
            nm_addressLabel.Size = new System.Drawing.Size(111, 33);
            nm_addressLabel.TabIndex = 5;
            nm_addressLabel.Text = "Endereço:";
            nm_addressLabel.Click += new System.EventHandler(this.Nm_addressLabel_Click);
            // 
            // cd_cellphoneLabel
            // 
            cd_cellphoneLabel.AutoSize = true;
            cd_cellphoneLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            cd_cellphoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            cd_cellphoneLabel.Location = new System.Drawing.Point(24, 118);
            cd_cellphoneLabel.Name = "cd_cellphoneLabel";
            cd_cellphoneLabel.Size = new System.Drawing.Size(87, 33);
            cd_cellphoneLabel.TabIndex = 7;
            cd_cellphoneLabel.Text = "Celular:";
            cd_cellphoneLabel.Click += new System.EventHandler(this.Cd_cellphoneLabel_Click);
            // 
            // nm_districtLabel
            // 
            nm_districtLabel.AutoSize = true;
            nm_districtLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            nm_districtLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            nm_districtLabel.Location = new System.Drawing.Point(276, 152);
            nm_districtLabel.Name = "nm_districtLabel";
            nm_districtLabel.Size = new System.Drawing.Size(95, 33);
            nm_districtLabel.TabIndex = 9;
            nm_districtLabel.Text = "Distrito:";
            nm_districtLabel.Click += new System.EventHandler(this.Nm_districtLabel_Click);
            // 
            // nm_cityLabel
            // 
            nm_cityLabel.AutoSize = true;
            nm_cityLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            nm_cityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            nm_cityLabel.Location = new System.Drawing.Point(22, 148);
            nm_cityLabel.Name = "nm_cityLabel";
            nm_cityLabel.Size = new System.Drawing.Size(87, 33);
            nm_cityLabel.TabIndex = 11;
            nm_cityLabel.Text = "Cidade:";
            nm_cityLabel.Click += new System.EventHandler(this.Nm_cityLabel_Click);
            // 
            // sg_stateLabel
            // 
            sg_stateLabel.AutoSize = true;
            sg_stateLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            sg_stateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            sg_stateLabel.Location = new System.Drawing.Point(24, 181);
            sg_stateLabel.Name = "sg_stateLabel";
            sg_stateLabel.Size = new System.Drawing.Size(72, 33);
            sg_stateLabel.TabIndex = 13;
            sg_stateLabel.Text = "State:";
            sg_stateLabel.Click += new System.EventHandler(this.Sg_stateLabel_Click);
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            cd_cepLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            cd_cepLabel.Location = new System.Drawing.Point(333, 185);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(60, 33);
            cd_cepLabel.TabIndex = 15;
            cd_cepLabel.Text = "CEP:";
            cd_cepLabel.Click += new System.EventHandler(this.Cd_cepLabel_Click);
            // 
            // cd_telephoneLabel
            // 
            cd_telephoneLabel.AutoSize = true;
            cd_telephoneLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            cd_telephoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            cd_telephoneLabel.Location = new System.Drawing.Point(333, 123);
            cd_telephoneLabel.Name = "cd_telephoneLabel";
            cd_telephoneLabel.Size = new System.Drawing.Size(100, 33);
            cd_telephoneLabel.TabIndex = 17;
            cd_telephoneLabel.Text = "Telefone:";
            cd_telephoneLabel.Click += new System.EventHandler(this.Cd_telephoneLabel_Click);
            // 
            // cd_cnpjLabel
            // 
            cd_cnpjLabel.AutoSize = true;
            cd_cnpjLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            cd_cnpjLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            cd_cnpjLabel.Location = new System.Drawing.Point(339, 215);
            cd_cnpjLabel.Name = "cd_cnpjLabel";
            cd_cnpjLabel.Size = new System.Drawing.Size(73, 33);
            cd_cnpjLabel.TabIndex = 19;
            cd_cnpjLabel.Text = "CNPJ:";
            cd_cnpjLabel.Click += new System.EventHandler(this.Cd_cnpjLabel_Click);
            // 
            // cd_ieLabel
            // 
            cd_ieLabel.AutoSize = true;
            cd_ieLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            cd_ieLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            cd_ieLabel.Location = new System.Drawing.Point(21, 215);
            cd_ieLabel.Name = "cd_ieLabel";
            cd_ieLabel.Size = new System.Drawing.Size(113, 33);
            cd_ieLabel.TabIndex = 21;
            cd_ieLabel.Text = "Codigo IE:";
            cd_ieLabel.Click += new System.EventHandler(this.Cd_ieLabel_Click);
            // 
            // bdYANKEE9DataSet
            // 
            this.bdYANKEE9DataSet.DataSetName = "BdYANKEE9DataSet";
            this.bdYANKEE9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProviderBindingSource
            // 
            this.tbProviderBindingSource.DataMember = "tbProvider";
            this.tbProviderBindingSource.DataSource = this.bdYANKEE9DataSet;
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
            // textcode
            // 
            this.textcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProviderBindingSource, "cd_provider", true));
            this.textcode.Location = new System.Drawing.Point(107, 39);
            this.textcode.Name = "textcode";
            this.textcode.Size = new System.Drawing.Size(72, 20);
            this.textcode.TabIndex = 2;
            this.textcode.TextChanged += new System.EventHandler(this.Cd_providerTextBox_TextChanged);
            // 
            // textname
            // 
            this.textname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProviderBindingSource, "nm_provider", true));
            this.textname.Location = new System.Drawing.Point(95, 69);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(238, 20);
            this.textname.TabIndex = 4;
            this.textname.TextChanged += new System.EventHandler(this.Nm_providerTextBox_TextChanged);
            // 
            // textaddress
            // 
            this.textaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProviderBindingSource, "nm_address", true));
            this.textaddress.Location = new System.Drawing.Point(134, 102);
            this.textaddress.Name = "textaddress";
            this.textaddress.Size = new System.Drawing.Size(247, 20);
            this.textaddress.TabIndex = 6;
            this.textaddress.TextChanged += new System.EventHandler(this.Nm_addressTextBox_TextChanged);
            // 
            // textcellphone
            // 
            this.textcellphone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProviderBindingSource, "cd_cellphone", true));
            this.textcellphone.Location = new System.Drawing.Point(111, 128);
            this.textcellphone.Name = "textcellphone";
            this.textcellphone.Size = new System.Drawing.Size(222, 20);
            this.textcellphone.TabIndex = 8;
            this.textcellphone.TextChanged += new System.EventHandler(this.Cd_cellphoneTextBox_TextChanged);
            // 
            // textdistrict
            // 
            this.textdistrict.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProviderBindingSource, "nm_district", true));
            this.textdistrict.Location = new System.Drawing.Point(370, 161);
            this.textdistrict.Name = "textdistrict";
            this.textdistrict.Size = new System.Drawing.Size(221, 20);
            this.textdistrict.TabIndex = 10;
            this.textdistrict.TextChanged += new System.EventHandler(this.Nm_districtTextBox_TextChanged);
            // 
            // textcity
            // 
            this.textcity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProviderBindingSource, "nm_city", true));
            this.textcity.Location = new System.Drawing.Point(111, 158);
            this.textcity.Name = "textcity";
            this.textcity.Size = new System.Drawing.Size(165, 20);
            this.textcity.TabIndex = 12;
            this.textcity.TextChanged += new System.EventHandler(this.Nm_cityTextBox_TextChanged);
            // 
            // textstate
            // 
            this.textstate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProviderBindingSource, "sg_state", true));
            this.textstate.Location = new System.Drawing.Point(101, 191);
            this.textstate.Name = "textstate";
            this.textstate.Size = new System.Drawing.Size(228, 20);
            this.textstate.TabIndex = 14;
            this.textstate.TextChanged += new System.EventHandler(this.Sg_stateTextBox_TextChanged);
            // 
            // textcep
            // 
            this.textcep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProviderBindingSource, "cd_cep", true));
            this.textcep.Location = new System.Drawing.Point(393, 193);
            this.textcep.Name = "textcep";
            this.textcep.Size = new System.Drawing.Size(214, 20);
            this.textcep.TabIndex = 16;
            this.textcep.TextChanged += new System.EventHandler(this.Cd_cepTextBox_TextChanged);
            // 
            // texttelephone
            // 
            this.texttelephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProviderBindingSource, "cd_telephone", true));
            this.texttelephone.Location = new System.Drawing.Point(428, 132);
            this.texttelephone.Name = "texttelephone";
            this.texttelephone.Size = new System.Drawing.Size(280, 20);
            this.texttelephone.TabIndex = 18;
            this.texttelephone.TextChanged += new System.EventHandler(this.Cd_telephoneTextBox_TextChanged);
            // 
            // textcnpj
            // 
            this.textcnpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProviderBindingSource, "cd_cnpj", true));
            this.textcnpj.Location = new System.Drawing.Point(414, 220);
            this.textcnpj.Name = "textcnpj";
            this.textcnpj.Size = new System.Drawing.Size(177, 20);
            this.textcnpj.TabIndex = 20;
            this.textcnpj.TextChanged += new System.EventHandler(this.Cd_cnpjTextBox_TextChanged);
            // 
            // textie
            // 
            this.textie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProviderBindingSource, "cd_ie", true));
            this.textie.Location = new System.Drawing.Point(140, 224);
            this.textie.Name = "textie";
            this.textie.Size = new System.Drawing.Size(193, 20);
            this.textie.TabIndex = 22;
            this.textie.TextChanged += new System.EventHandler(this.Cd_ieTextBox_TextChanged);
            // 
            // btsair
            // 
            this.btsair.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btsair.Location = new System.Drawing.Point(588, 361);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(93, 32);
            this.btsair.TabIndex = 40;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.Btsair_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btexcluir.Location = new System.Drawing.Point(588, 302);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(93, 32);
            this.btexcluir.TabIndex = 39;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.Btexcluir_Click);
            // 
            // btimprimir
            // 
            this.btimprimir.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btimprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btimprimir.Location = new System.Drawing.Point(469, 361);
            this.btimprimir.Name = "btimprimir";
            this.btimprimir.Size = new System.Drawing.Size(93, 32);
            this.btimprimir.TabIndex = 38;
            this.btimprimir.Text = "Imprimir";
            this.btimprimir.UseVisualStyleBackColor = true;
            // 
            // btpesquisar
            // 
            this.btpesquisar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btpesquisar.Location = new System.Drawing.Point(341, 361);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(93, 32);
            this.btpesquisar.TabIndex = 37;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = true;
            // 
            // btcancelar
            // 
            this.btcancelar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btcancelar.Location = new System.Drawing.Point(215, 361);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(93, 32);
            this.btcancelar.TabIndex = 36;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.Btcancelar_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btsalvar.Location = new System.Drawing.Point(95, 361);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(93, 32);
            this.btsalvar.TabIndex = 35;
            this.btsalvar.Text = "Salvar";
            this.btsalvar.UseVisualStyleBackColor = true;
            this.btsalvar.Click += new System.EventHandler(this.Btsalvar_Click);
            // 
            // btalterar
            // 
            this.btalterar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btalterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btalterar.Location = new System.Drawing.Point(469, 302);
            this.btalterar.Name = "btalterar";
            this.btalterar.Size = new System.Drawing.Size(93, 32);
            this.btalterar.TabIndex = 34;
            this.btalterar.Text = "Alterar";
            this.btalterar.UseVisualStyleBackColor = true;
            this.btalterar.Click += new System.EventHandler(this.Btalterar_Click);
            // 
            // btnovo
            // 
            this.btnovo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btnovo.Location = new System.Drawing.Point(341, 302);
            this.btnovo.Name = "btnovo";
            this.btnovo.Size = new System.Drawing.Size(93, 32);
            this.btnovo.TabIndex = 33;
            this.btnovo.Text = "Novo";
            this.btnovo.UseVisualStyleBackColor = true;
            this.btnovo.Click += new System.EventHandler(this.Btnovo_Click);
            // 
            // btproximo
            // 
            this.btproximo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btproximo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btproximo.Location = new System.Drawing.Point(215, 302);
            this.btproximo.Name = "btproximo";
            this.btproximo.Size = new System.Drawing.Size(93, 32);
            this.btproximo.TabIndex = 32;
            this.btproximo.Text = "Proximo";
            this.btproximo.UseVisualStyleBackColor = true;
            this.btproximo.Click += new System.EventHandler(this.Btproximo_Click);
            // 
            // btanterior
            // 
            this.btanterior.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btanterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btanterior.Location = new System.Drawing.Point(95, 302);
            this.btanterior.Name = "btanterior";
            this.btanterior.Size = new System.Drawing.Size(93, 32);
            this.btanterior.TabIndex = 31;
            this.btanterior.Text = "Anterior";
            this.btanterior.UseVisualStyleBackColor = true;
            this.btanterior.Click += new System.EventHandler(this.Btanterior_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.groupBox1.Controls.Add(cd_providerLabel);
            this.groupBox1.Controls.Add(this.btsair);
            this.groupBox1.Controls.Add(this.textie);
            this.groupBox1.Controls.Add(this.btexcluir);
            this.groupBox1.Controls.Add(cd_ieLabel);
            this.groupBox1.Controls.Add(this.btimprimir);
            this.groupBox1.Controls.Add(this.textcnpj);
            this.groupBox1.Controls.Add(this.btpesquisar);
            this.groupBox1.Controls.Add(cd_cnpjLabel);
            this.groupBox1.Controls.Add(this.btcancelar);
            this.groupBox1.Controls.Add(this.texttelephone);
            this.groupBox1.Controls.Add(this.btsalvar);
            this.groupBox1.Controls.Add(cd_telephoneLabel);
            this.groupBox1.Controls.Add(this.btalterar);
            this.groupBox1.Controls.Add(this.textcep);
            this.groupBox1.Controls.Add(this.btnovo);
            this.groupBox1.Controls.Add(cd_cepLabel);
            this.groupBox1.Controls.Add(this.btproximo);
            this.groupBox1.Controls.Add(this.textstate);
            this.groupBox1.Controls.Add(this.btanterior);
            this.groupBox1.Controls.Add(sg_stateLabel);
            this.groupBox1.Controls.Add(this.textcity);
            this.groupBox1.Controls.Add(this.textcode);
            this.groupBox1.Controls.Add(nm_cityLabel);
            this.groupBox1.Controls.Add(nm_providerLabel);
            this.groupBox1.Controls.Add(this.textdistrict);
            this.groupBox1.Controls.Add(this.textname);
            this.groupBox1.Controls.Add(nm_districtLabel);
            this.groupBox1.Controls.Add(nm_addressLabel);
            this.groupBox1.Controls.Add(this.textcellphone);
            this.groupBox1.Controls.Add(this.textaddress);
            this.groupBox1.Controls.Add(cd_cellphoneLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 417);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fornecedores";
            // 
            // Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.groupBox1);
            this.Name = "Fornecedores";
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.Fornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdYANKEE9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProviderBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BdYANKEE9DataSet bdYANKEE9DataSet;
        private System.Windows.Forms.BindingSource tbProviderBindingSource;
        private BdYANKEE9DataSetTableAdapters.tbProviderTableAdapter tbProviderTableAdapter;
        private BdYANKEE9DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textcode;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textaddress;
        private System.Windows.Forms.TextBox textcellphone;
        private System.Windows.Forms.TextBox textdistrict;
        private System.Windows.Forms.TextBox textcity;
        private System.Windows.Forms.TextBox textstate;
        private System.Windows.Forms.TextBox textcep;
        private System.Windows.Forms.TextBox texttelephone;
        private System.Windows.Forms.TextBox textcnpj;
        private System.Windows.Forms.TextBox textie;
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
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}