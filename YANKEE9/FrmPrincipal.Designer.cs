
namespace YANKEE9
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relátoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btcliente = new System.Windows.Forms.Button();
            this.btusuar = new System.Windows.Forms.Button();
            this.produtos = new System.Windows.Forms.Button();
            this.btfornecedores = new System.Windows.Forms.Button();
            this.relprodutos = new System.Windows.Forms.Button();
            this.relfornecedores = new System.Windows.Forms.Button();
            this.relcliente = new System.Windows.Forms.Button();
            this.relusuarios = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relátoriosToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.toolStripSeparator1,
            this.clienteToolStripMenuItem,
            this.toolStripSeparator2,
            this.fornecedoresToolStripMenuItem,
            this.toolStripSeparator3,
            this.produtosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.cadastroToolStripMenuItem.Text = "Usuarios";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // relátoriosToolStripMenuItem
            // 
            this.relátoriosToolStripMenuItem.Name = "relátoriosToolStripMenuItem";
            this.relátoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relátoriosToolStripMenuItem.Text = "Relátorios";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // btcliente
            // 
            this.btcliente.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btcliente.Location = new System.Drawing.Point(76, 209);
            this.btcliente.Name = "btcliente";
            this.btcliente.Size = new System.Drawing.Size(133, 32);
            this.btcliente.TabIndex = 11;
            this.btcliente.Text = "Cliente";
            this.btcliente.UseVisualStyleBackColor = true;
            // 
            // btusuar
            // 
            this.btusuar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btusuar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btusuar.Location = new System.Drawing.Point(76, 153);
            this.btusuar.Name = "btusuar";
            this.btusuar.Size = new System.Drawing.Size(133, 32);
            this.btusuar.TabIndex = 12;
            this.btusuar.Text = "Usuarios";
            this.btusuar.UseVisualStyleBackColor = true;
            this.btusuar.Click += new System.EventHandler(this.Btusuar_Click);
            // 
            // produtos
            // 
            this.produtos.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.produtos.Location = new System.Drawing.Point(76, 323);
            this.produtos.Name = "produtos";
            this.produtos.Size = new System.Drawing.Size(133, 32);
            this.produtos.TabIndex = 13;
            this.produtos.Text = "Produtos";
            this.produtos.UseVisualStyleBackColor = true;
            // 
            // btfornecedores
            // 
            this.btfornecedores.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfornecedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btfornecedores.Location = new System.Drawing.Point(76, 265);
            this.btfornecedores.Name = "btfornecedores";
            this.btfornecedores.Size = new System.Drawing.Size(133, 32);
            this.btfornecedores.TabIndex = 14;
            this.btfornecedores.Text = "Fornecedores";
            this.btfornecedores.UseVisualStyleBackColor = true;
            // 
            // relprodutos
            // 
            this.relprodutos.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relprodutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.relprodutos.Location = new System.Drawing.Point(595, 323);
            this.relprodutos.Name = "relprodutos";
            this.relprodutos.Size = new System.Drawing.Size(133, 32);
            this.relprodutos.TabIndex = 15;
            this.relprodutos.Text = "Produtos";
            this.relprodutos.UseVisualStyleBackColor = true;
            // 
            // relfornecedores
            // 
            this.relfornecedores.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relfornecedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.relfornecedores.Location = new System.Drawing.Point(595, 265);
            this.relfornecedores.Name = "relfornecedores";
            this.relfornecedores.Size = new System.Drawing.Size(133, 32);
            this.relfornecedores.TabIndex = 16;
            this.relfornecedores.Text = "Fornecedores";
            this.relfornecedores.UseVisualStyleBackColor = true;
            // 
            // relcliente
            // 
            this.relcliente.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relcliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.relcliente.Location = new System.Drawing.Point(595, 209);
            this.relcliente.Name = "relcliente";
            this.relcliente.Size = new System.Drawing.Size(133, 32);
            this.relcliente.TabIndex = 17;
            this.relcliente.Text = "Cliente";
            this.relcliente.UseVisualStyleBackColor = true;
            // 
            // relusuarios
            // 
            this.relusuarios.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relusuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.relusuarios.Location = new System.Drawing.Point(595, 153);
            this.relusuarios.Name = "relusuarios";
            this.relusuarios.Size = new System.Drawing.Size(133, 32);
            this.relusuarios.TabIndex = 18;
            this.relusuarios.Text = "Usuarios";
            this.relusuarios.UseVisualStyleBackColor = true;
            // 
            // btsair
            // 
            this.btsair.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(103)))));
            this.btsair.Location = new System.Drawing.Point(344, 395);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(93, 32);
            this.btsair.TabIndex = 19;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(85, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cadastros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(599, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 36);
            this.label2.TabIndex = 21;
            this.label2.Text = "Relátorios";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.relusuarios);
            this.Controls.Add(this.relcliente);
            this.Controls.Add(this.relfornecedores);
            this.Controls.Add(this.relprodutos);
            this.Controls.Add(this.btfornecedores);
            this.Controls.Add(this.produtos);
            this.Controls.Add(this.btusuar);
            this.Controls.Add(this.btcliente);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmPrincipal";
            this.Text = "YANKEE9";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem relátoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.Button btcliente;
        private System.Windows.Forms.Button btusuar;
        private System.Windows.Forms.Button produtos;
        private System.Windows.Forms.Button btfornecedores;
        private System.Windows.Forms.Button relprodutos;
        private System.Windows.Forms.Button relfornecedores;
        private System.Windows.Forms.Button relcliente;
        private System.Windows.Forms.Button relusuarios;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

