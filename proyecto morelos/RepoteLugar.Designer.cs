namespace proyecto_morelos
{
    partial class RepoteLugar
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepoteLugar));
            this.LugaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatabaseDataSet = new proyecto_morelos.DatabaseDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LugaresTableAdapter = new proyecto_morelos.DatabaseDataSetTableAdapters.LugaresTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lugaresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LugaresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // LugaresBindingSource
            // 
            this.LugaresBindingSource.DataMember = "Lugares";
            this.LugaresBindingSource.DataSource = this.DatabaseDataSet;
            // 
            // DatabaseDataSet
            // 
            this.DatabaseDataSet.DataSetName = "DatabaseDataSet";
            this.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.LugaresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "proyecto_morelos.Formularios.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 37);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(986, 691);
            this.reportViewer1.TabIndex = 0;
            // 
            // LugaresTableAdapter
            // 
            this.LugaresTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(952, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lugaresBindingSource1
            // 
            this.lugaresBindingSource1.DataMember = "Lugares";
            this.lugaresBindingSource1.DataSource = this.DatabaseDataSet;
            // 
            // RepoteLugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1011, 740);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RepoteLugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepoteLugar";
            this.Load += new System.EventHandler(this.RepoteLugar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LugaresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LugaresBindingSource;
        private DatabaseDataSet DatabaseDataSet;
        private DatabaseDataSetTableAdapters.LugaresTableAdapter LugaresTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource lugaresBindingSource1;
    }
}