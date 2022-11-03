namespace YANKEE9
{
    partial class clients
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
            System.Windows.Forms.Label cd_clientLabel;
            System.Windows.Forms.Label nm_clientLabel;
            System.Windows.Forms.Label cd_cellphoneLabel;
            System.Windows.Forms.Label nm_districtLabel;
            System.Windows.Forms.Label nm_cityLabel;
            System.Windows.Forms.Label sg_stateLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label cd_telephoneLabel;
            System.Windows.Forms.Label cd_cpfLabel;
            System.Windows.Forms.Label cd_rgLabel;
            this.bdYANKEE9DataSet = new YANKEE9.BdYANKEE9DataSet();
            this.tbClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClientTableAdapter = new YANKEE9.BdYANKEE9DataSetTableAdapters.tbClientTableAdapter();
            this.tableAdapterManager = new YANKEE9.BdYANKEE9DataSetTableAdapters.TableAdapterManager();
            this.textcode = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textcellphone = new System.Windows.Forms.TextBox();
            this.textdistrict = new System.Windows.Forms.TextBox();
            this.textcity = new System.Windows.Forms.TextBox();
            this.textstate = new System.Windows.Forms.TextBox();
            this.textcep = new System.Windows.Forms.TextBox();
            this.texttelephone = new System.Windows.Forms.TextBox();
            this.textcpf = new System.Windows.Forms.TextBox();
            this.textrg = new System.Windows.Forms.TextBox();
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
            cd_clientLabel = new System.Windows.Forms.Label();
            nm_clientLabel = new System.Windows.Forms.Label();
            cd_cellphoneLabel = new System.Windows.Forms.Label();
            nm_districtLabel = new System.Windows.Forms.Label();
            nm_cityLabel = new System.Windows.Forms.Label();
            sg_stateLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            cd_telephoneLabel = new System.Windows.Forms.Label();
            cd_cpfLabel = new System.Windows.Forms.Label();
            cd_rgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdYANKEE9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cd_clientLabel
            // 
            cd_clientLabel.AutoSize = true;
            cd_clientLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_clientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            cd_clientLabel.Location = new System.Drawing.Point(21, 41);
            cd_clientLabel.Name = "cd_clientLabel";
            cd_clientLabel.Size = new System.Drawing.Size(86, 33);
            cd_clientLabel.TabIndex = 1;
            cd_clientLabel.Text = "Codigo:";
            // 
            // nm_clientLabel
            // 
            nm_clientLabel.AutoSize = true;
            nm_clientLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            nm_clientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            nm_clientLabel.Location = new System.Drawing.Point(21, 75);
            nm_clientLabel.Name = "nm_clientLabel";
            nm_clientLabel.Size = new System.Drawing.Size(77, 33);
            nm_clientLabel.TabIndex = 3;
            nm_clientLabel.Text = "Nome:";
            // 
            // cd_cellphoneLabel
            // 
            cd_cellphoneLabel.AutoSize = true;
            cd_cellphoneLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            cd_cellphoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            cd_cellphoneLabel.Location = new System.Drawing.Point(391, 75);
            cd_cellphoneLabel.Name = "cd_cellphoneLabel";
            cd_cellphoneLabel.Size = new System.Drawing.Size(87, 33);
            cd_cellphoneLabel.TabIndex = 5;
            cd_cellphoneLabel.Text = "Celular:";
            // 
            // nm_districtLabel
            // 
            nm_districtLabel.AutoSize = true;
            nm_districtLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            nm_districtLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            nm_districtLabel.Location = new System.Drawing.Point(21, 110);
            nm_districtLabel.Name = "nm_districtLabel";
            nm_districtLabel.Size = new System.Drawing.Size(95, 33);
            nm_districtLabel.TabIndex = 7;
            nm_districtLabel.Text = "Distrito:";
            // 
            // nm_cityLabel
            // 
            nm_cityLabel.AutoSize = true;
            nm_cityLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            nm_cityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            nm_cityLabel.Location = new System.Drawing.Point(283, 110);
            nm_cityLabel.Name = "nm_cityLabel";
            nm_cityLabel.Size = new System.Drawing.Size(87, 33);
            nm_cityLabel.TabIndex = 9;
            nm_cityLabel.Text = "Cidade:";
            // 
            // sg_stateLabel
            // 
            sg_stateLabel.AutoSize = true;
            sg_stateLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            sg_stateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            sg_stateLabel.Location = new System.Drawing.Point(21, 137);
            sg_stateLabel.Name = "sg_stateLabel";
            sg_stateLabel.Size = new System.Drawing.Size(72, 33);
            sg_stateLabel.TabIndex = 11;
            sg_stateLabel.Text = "State:";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            cd_cepLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            cd_cepLabel.Location = new System.Drawing.Point(255, 139);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(60, 33);
            cd_cepLabel.TabIndex = 13;
            cd_cepLabel.Text = "CEP:";
            // 
            // cd_telephoneLabel
            // 
            cd_telephoneLabel.AutoSize = true;
            cd_telephoneLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            cd_telephoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            cd_telephoneLabel.Location = new System.Drawing.Point(21, 167);
            cd_telephoneLabel.Name = "cd_telephoneLabel";
            cd_telephoneLabel.Size = new System.Drawing.Size(100, 33);
            cd_telephoneLabel.TabIndex = 15;
            cd_telephoneLabel.Text = "Telefone:";
            // 
            // cd_cpfLabel
            // 
            cd_cpfLabel.AutoSize = true;
            cd_cpfLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            cd_cpfLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            cd_cpfLabel.Location = new System.Drawing.Point(21, 193);
            cd_cpfLabel.Name = "cd_cpfLabel";
            cd_cpfLabel.Size = new System.Drawing.Size(58, 33);
            cd_cpfLabel.TabIndex = 17;
            cd_cpfLabel.Text = "CPF:";
            // 
            // cd_rgLabel
            // 
            cd_rgLabel.AutoSize = true;
            cd_rgLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            cd_rgLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            cd_rgLabel.Location = new System.Drawing.Point(21, 219);
            cd_rgLabel.Name = "cd_rgLabel";
            cd_rgLabel.Size = new System.Drawing.Size(50, 33);
            cd_rgLabel.TabIndex = 19;
            cd_rgLabel.Text = "RG:";
            // 
            // bdYANKEE9DataSet
            // 
            this.bdYANKEE9DataSet.DataSetName = "BdYANKEE9DataSet";
            this.bdYANKEE9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbClientBindingSource
            // 
            this.tbClientBindingSource.DataMember = "tbClient";
            this.tbClientBindingSource.DataSource = this.bdYANKEE9DataSet;
            // 
            // tbClientTableAdapter
            // 
            this.tbClientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClientTableAdapter = this.tbClientTableAdapter;
            this.tableAdapterManager.tbProductTableAdapter = null;
            this.tableAdapterManager.tbProviderTableAdapter = null;
            this.tableAdapterManager.tbUsuarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = YANKEE9.BdYANKEE9DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textcode
            // 
            this.textcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientBindingSource, "cd_client", true));
            this.textcode.Location = new System.Drawing.Point(106, 51);
            this.textcode.Name = "textcode";
            this.textcode.Size = new System.Drawing.Size(72, 20);
            this.textcode.TabIndex = 2;
            // 
            // textname
            // 
            this.textname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientBindingSource, "nm_client", true));
            this.textname.Location = new System.Drawing.Point(97, 85);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(287, 20);
            this.textname.TabIndex = 4;
            // 
            // textcellphone
            // 
            this.textcellphone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientBindingSource, "cd_cellphone", true));
            this.textcellphone.Location = new System.Drawing.Point(481, 83);
            this.textcellphone.Name = "textcellphone";
            this.textcellphone.Size = new System.Drawing.Size(190, 20);
            this.textcellphone.TabIndex = 6;
            // 
            // textdistrict
            // 
            this.textdistrict.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientBindingSource, "nm_district", true));
            this.textdistrict.Location = new System.Drawing.Point(115, 118);
            this.textdistrict.Name = "textdistrict";
            this.textdistrict.Size = new System.Drawing.Size(159, 20);
            this.textdistrict.TabIndex = 8;
            // 
            // textcity
            // 
            this.textcity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientBindingSource, "nm_city", true));
            this.textcity.Location = new System.Drawing.Point(372, 117);
            this.textcity.Name = "textcity";
            this.textcity.Size = new System.Drawing.Size(168, 20);
            this.textcity.TabIndex = 10;
            // 
            // textstate
            // 
            this.textstate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientBindingSource, "sg_state", true));
            this.textstate.Location = new System.Drawing.Point(94, 146);
            this.textstate.Name = "textstate";
            this.textstate.Size = new System.Drawing.Size(154, 20);
            this.textstate.TabIndex = 12;
            // 
            // textcep
            // 
            this.textcep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientBindingSource, "cd_cep", true));
            this.textcep.Location = new System.Drawing.Point(315, 148);
            this.textcep.Name = "textcep";
            this.textcep.Size = new System.Drawing.Size(180, 20);
            this.textcep.TabIndex = 14;
            // 
            // texttelephone
            // 
            this.texttelephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientBindingSource, "cd_telephone", true));
            this.texttelephone.Location = new System.Drawing.Point(121, 175);
            this.texttelephone.Name = "texttelephone";
            this.texttelephone.Size = new System.Drawing.Size(311, 20);
            this.texttelephone.TabIndex = 16;
            this.texttelephone.TextChanged += new System.EventHandler(this.Cd_telephoneTextBox_TextChanged);
            // 
            // textcpf
            // 
            this.textcpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientBindingSource, "cd_cpf", true));
            this.textcpf.Location = new System.Drawing.Point(77, 201);
            this.textcpf.Name = "textcpf";
            this.textcpf.Size = new System.Drawing.Size(346, 20);
            this.textcpf.TabIndex = 18;
            // 
            // textrg
            // 
            this.textrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientBindingSource, "cd_rg", true));
            this.textrg.Location = new System.Drawing.Point(68, 228);
            this.textrg.Name = "textrg";
            this.textrg.Size = new System.Drawing.Size(232, 20);
            this.textrg.TabIndex = 20;
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
            this.groupBox1.Controls.Add(cd_clientLabel);
            this.groupBox1.Controls.Add(this.textrg);
            this.groupBox1.Controls.Add(this.textcode);
            this.groupBox1.Controls.Add(cd_rgLabel);
            this.groupBox1.Controls.Add(nm_clientLabel);
            this.groupBox1.Controls.Add(this.textcpf);
            this.groupBox1.Controls.Add(this.textname);
            this.groupBox1.Controls.Add(cd_cpfLabel);
            this.groupBox1.Controls.Add(cd_cellphoneLabel);
            this.groupBox1.Controls.Add(this.texttelephone);
            this.groupBox1.Controls.Add(this.textcellphone);
            this.groupBox1.Controls.Add(cd_telephoneLabel);
            this.groupBox1.Controls.Add(nm_districtLabel);
            this.groupBox1.Controls.Add(this.textcep);
            this.groupBox1.Controls.Add(this.textdistrict);
            this.groupBox1.Controls.Add(cd_cepLabel);
            this.groupBox1.Controls.Add(nm_cityLabel);
            this.groupBox1.Controls.Add(this.textstate);
            this.groupBox1.Controls.Add(this.textcity);
            this.groupBox1.Controls.Add(sg_stateLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 415);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // btsair
            // 
            this.btsair.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btsair.Location = new System.Drawing.Point(578, 341);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(93, 32);
            this.btsair.TabIndex = 30;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.Btsair_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btexcluir.Location = new System.Drawing.Point(578, 282);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(93, 32);
            this.btexcluir.TabIndex = 29;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.Btexcluir_Click);
            // 
            // btimprimir
            // 
            this.btimprimir.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btimprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btimprimir.Location = new System.Drawing.Point(459, 341);
            this.btimprimir.Name = "btimprimir";
            this.btimprimir.Size = new System.Drawing.Size(93, 32);
            this.btimprimir.TabIndex = 28;
            this.btimprimir.Text = "Imprimir";
            this.btimprimir.UseVisualStyleBackColor = true;
            // 
            // btpesquisar
            // 
            this.btpesquisar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btpesquisar.Location = new System.Drawing.Point(331, 341);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(93, 32);
            this.btpesquisar.TabIndex = 27;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.Btpesquisar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btcancelar.Location = new System.Drawing.Point(205, 341);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(93, 32);
            this.btcancelar.TabIndex = 26;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.Btcancelar_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btsalvar.Location = new System.Drawing.Point(85, 341);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(93, 32);
            this.btsalvar.TabIndex = 25;
            this.btsalvar.Text = "Salvar";
            this.btsalvar.UseVisualStyleBackColor = true;
            this.btsalvar.Click += new System.EventHandler(this.Btsalvar_Click);
            // 
            // btalterar
            // 
            this.btalterar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btalterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btalterar.Location = new System.Drawing.Point(459, 282);
            this.btalterar.Name = "btalterar";
            this.btalterar.Size = new System.Drawing.Size(93, 32);
            this.btalterar.TabIndex = 24;
            this.btalterar.Text = "Alterar";
            this.btalterar.UseVisualStyleBackColor = true;
            this.btalterar.Click += new System.EventHandler(this.Btalterar_Click);
            // 
            // btnovo
            // 
            this.btnovo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btnovo.Location = new System.Drawing.Point(331, 282);
            this.btnovo.Name = "btnovo";
            this.btnovo.Size = new System.Drawing.Size(93, 32);
            this.btnovo.TabIndex = 23;
            this.btnovo.Text = "Novo";
            this.btnovo.UseVisualStyleBackColor = true;
            this.btnovo.Click += new System.EventHandler(this.Btnovo_Click);
            // 
            // btproximo
            // 
            this.btproximo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btproximo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btproximo.Location = new System.Drawing.Point(205, 282);
            this.btproximo.Name = "btproximo";
            this.btproximo.Size = new System.Drawing.Size(93, 32);
            this.btproximo.TabIndex = 22;
            this.btproximo.Text = "Proximo";
            this.btproximo.UseVisualStyleBackColor = true;
            this.btproximo.Click += new System.EventHandler(this.Btproximo_Click);
            // 
            // btanterior
            // 
            this.btanterior.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btanterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btanterior.Location = new System.Drawing.Point(85, 282);
            this.btanterior.Name = "btanterior";
            this.btanterior.Size = new System.Drawing.Size(93, 32);
            this.btanterior.TabIndex = 21;
            this.btanterior.Text = "Anterior";
            this.btanterior.UseVisualStyleBackColor = true;
            this.btanterior.Click += new System.EventHandler(this.Btanterior_Click);
            // 
            // clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "clients";
            this.Text = "clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdYANKEE9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BdYANKEE9DataSet bdYANKEE9DataSet;
        private System.Windows.Forms.BindingSource tbClientBindingSource;
        private BdYANKEE9DataSetTableAdapters.tbClientTableAdapter tbClientTableAdapter;
        private BdYANKEE9DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textcode;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textcellphone;
        private System.Windows.Forms.TextBox textdistrict;
        private System.Windows.Forms.TextBox textcity;
        private System.Windows.Forms.TextBox textstate;
        private System.Windows.Forms.TextBox textcep;
        private System.Windows.Forms.TextBox texttelephone;
        private System.Windows.Forms.TextBox textcpf;
        private System.Windows.Forms.TextBox textrg;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}