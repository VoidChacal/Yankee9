
namespace YANKEE9
{
    partial class frmRelatorioUsuario
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BdYANKEE9DataSet = new YANKEE9.BdYANKEE9DataSet();
            this.tbUsuarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsuarTableAdapter = new YANKEE9.BdYANKEE9DataSetTableAdapters.tbUsuarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BdYANKEE9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbUsuarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YANKEE9.relatorioUsuario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // BdYANKEE9DataSet
            // 
            this.BdYANKEE9DataSet.DataSetName = "BdYANKEE9DataSet";
            this.BdYANKEE9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUsuarBindingSource
            // 
            this.tbUsuarBindingSource.DataMember = "tbUsuar";
            this.tbUsuarBindingSource.DataSource = this.BdYANKEE9DataSet;
            // 
            // tbUsuarTableAdapter
            // 
            this.tbUsuarTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioUsuario";
            this.Text = "frmRelatorioUsuario";
            this.Load += new System.EventHandler(this.frmRelatorioUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BdYANKEE9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbUsuarBindingSource;
        private BdYANKEE9DataSet BdYANKEE9DataSet;
        private BdYANKEE9DataSetTableAdapters.tbUsuarTableAdapter tbUsuarTableAdapter;
    }
}