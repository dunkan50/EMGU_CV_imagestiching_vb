namespace stitching2
{
    partial class frmMain
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
            this.tblOuter = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btSaveImage = new System.Windows.Forms.Button();
            this.ibFinalImage = new Emgu.CV.UI.ImageBox();
            this.dgvSourceImage = new System.Windows.Forms.DataGridView();
            this.ofdOpenfile = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaving = new System.Windows.Forms.SaveFileDialog();
            this.samplePictureColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.fileNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOuter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibFinalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSourceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tblOuter
            // 
            this.tblOuter.ColumnCount = 2;
            this.tblOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOuter.Controls.Add(this.btnOpenFile, 0, 0);
            this.tblOuter.Controls.Add(this.btSaveImage, 1, 0);
            this.tblOuter.Controls.Add(this.ibFinalImage, 1, 1);
            this.tblOuter.Controls.Add(this.dgvSourceImage, 0, 1);
            this.tblOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblOuter.Location = new System.Drawing.Point(0, 0);
            this.tblOuter.Name = "tblOuter";
            this.tblOuter.RowCount = 2;
            this.tblOuter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblOuter.Size = new System.Drawing.Size(849, 515);
            this.tblOuter.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(3, 3);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btSaveImage
            // 
            this.btSaveImage.Location = new System.Drawing.Point(427, 3);
            this.btSaveImage.Name = "btSaveImage";
            this.btSaveImage.Size = new System.Drawing.Size(75, 23);
            this.btSaveImage.TabIndex = 1;
            this.btSaveImage.Text = " Save ";
            this.btSaveImage.UseVisualStyleBackColor = true;
            this.btSaveImage.Click += new System.EventHandler(this.btSaveImage_Click);
            // 
            // ibFinalImage
            // 
            this.ibFinalImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ibFinalImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibFinalImage.Location = new System.Drawing.Point(427, 32);
            this.ibFinalImage.Name = "ibFinalImage";
            this.ibFinalImage.Size = new System.Drawing.Size(419, 480);
            this.ibFinalImage.TabIndex = 2;
            this.ibFinalImage.TabStop = false;
            // 
            // dgvSourceImage
            // 
            this.dgvSourceImage.AllowUserToAddRows = false;
            this.dgvSourceImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSourceImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSourceImage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.samplePictureColumn,
            this.fileNameColumn});
            this.dgvSourceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSourceImage.Location = new System.Drawing.Point(3, 32);
            this.dgvSourceImage.Name = "dgvSourceImage";
            this.dgvSourceImage.ReadOnly = true;
            this.dgvSourceImage.Size = new System.Drawing.Size(418, 480);
            this.dgvSourceImage.TabIndex = 3;
            // 
            // ofdOpenfile
            // 
            this.ofdOpenfile.FileName = "openFileDialog1";
            // 
            // samplePictureColumn
            // 
            this.samplePictureColumn.HeaderText = "Sample Picture";
            this.samplePictureColumn.Name = "samplePictureColumn";
            this.samplePictureColumn.ReadOnly = true;
            this.samplePictureColumn.FillWeight = 200F;
            this.samplePictureColumn.Width = 200;

            // 
            // fileNameColumn
            // 
            this.fileNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fileNameColumn.HeaderText = "FIle Name";
            this.fileNameColumn.Name = "fileNameColumn";
            this.fileNameColumn.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 515);
            this.Controls.Add(this.tblOuter);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.tblOuter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ibFinalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSourceImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblOuter;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btSaveImage;
        private Emgu.CV.UI.ImageBox ibFinalImage;
        private System.Windows.Forms.DataGridView dgvSourceImage;
        private System.Windows.Forms.DataGridViewImageColumn samplePictureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameColumn;
        private System.Windows.Forms.OpenFileDialog ofdOpenfile;
        private System.Windows.Forms.SaveFileDialog sfdSaving;
    }
}

