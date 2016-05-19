partial class frmMain
{
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            this.lblImageFileLocator = new System.Windows.Forms.Label();
            this.grpFileFormats = new System.Windows.Forms.GroupBox();
            this.grpDisplayOptions = new System.Windows.Forms.GroupBox();
            this.cbxBMP = new System.Windows.Forms.CheckBox();
            this.cbxGIF = new System.Windows.Forms.CheckBox();
            this.cbxJPG = new System.Windows.Forms.CheckBox();
            this.cbxPNG = new System.Windows.Forms.CheckBox();
            this.cbxTIFF = new System.Windows.Forms.CheckBox();
            this.cbxFileNameOnly = new System.Windows.Forms.CheckBox();
            this.lblDirectoryToSearch = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstDisplayFiles = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLocateFiles = new System.Windows.Forms.Button();
            this.grpFileFormats.SuspendLayout();
            this.grpDisplayOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblImageFileLocator
            // 
            this.lblImageFileLocator.AutoSize = true;
            this.lblImageFileLocator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageFileLocator.Location = new System.Drawing.Point(13, 13);
            this.lblImageFileLocator.Name = "lblImageFileLocator";
            this.lblImageFileLocator.Size = new System.Drawing.Size(137, 16);
            this.lblImageFileLocator.TabIndex = 0;
            this.lblImageFileLocator.Text = "Image File Locator";
            // 
            // grpFileFormats
            // 
            this.grpFileFormats.Controls.Add(this.cbxTIFF);
            this.grpFileFormats.Controls.Add(this.cbxPNG);
            this.grpFileFormats.Controls.Add(this.cbxJPG);
            this.grpFileFormats.Controls.Add(this.cbxGIF);
            this.grpFileFormats.Controls.Add(this.cbxBMP);
            this.grpFileFormats.Location = new System.Drawing.Point(16, 55);
            this.grpFileFormats.Name = "grpFileFormats";
            this.grpFileFormats.Size = new System.Drawing.Size(134, 166);
            this.grpFileFormats.TabIndex = 1;
            this.grpFileFormats.TabStop = false;
            this.grpFileFormats.Text = "File Formats:";
            // 
            // grpDisplayOptions
            // 
            this.grpDisplayOptions.Controls.Add(this.cbxFileNameOnly);
            this.grpDisplayOptions.Location = new System.Drawing.Point(16, 236);
            this.grpDisplayOptions.Name = "grpDisplayOptions";
            this.grpDisplayOptions.Size = new System.Drawing.Size(134, 65);
            this.grpDisplayOptions.TabIndex = 2;
            this.grpDisplayOptions.TabStop = false;
            this.grpDisplayOptions.Text = "Display Options";
            // 
            // cbxBMP
            // 
            this.cbxBMP.AutoSize = true;
            this.cbxBMP.Location = new System.Drawing.Point(21, 32);
            this.cbxBMP.Name = "cbxBMP";
            this.cbxBMP.Size = new System.Drawing.Size(49, 17);
            this.cbxBMP.TabIndex = 0;
            this.cbxBMP.Text = "BMP";
            this.cbxBMP.UseVisualStyleBackColor = true;
            // 
            // cbxGIF
            // 
            this.cbxGIF.AutoSize = true;
            this.cbxGIF.Location = new System.Drawing.Point(21, 56);
            this.cbxGIF.Name = "cbxGIF";
            this.cbxGIF.Size = new System.Drawing.Size(43, 17);
            this.cbxGIF.TabIndex = 1;
            this.cbxGIF.Text = "GIF";
            this.cbxGIF.UseVisualStyleBackColor = true;
            // 
            // cbxJPG
            // 
            this.cbxJPG.AutoSize = true;
            this.cbxJPG.Location = new System.Drawing.Point(21, 80);
            this.cbxJPG.Name = "cbxJPG";
            this.cbxJPG.Size = new System.Drawing.Size(46, 17);
            this.cbxJPG.TabIndex = 2;
            this.cbxJPG.Text = "JPG";
            this.cbxJPG.UseVisualStyleBackColor = true;
            // 
            // cbxPNG
            // 
            this.cbxPNG.AutoSize = true;
            this.cbxPNG.Location = new System.Drawing.Point(21, 104);
            this.cbxPNG.Name = "cbxPNG";
            this.cbxPNG.Size = new System.Drawing.Size(49, 17);
            this.cbxPNG.TabIndex = 3;
            this.cbxPNG.Text = "PNG";
            this.cbxPNG.UseVisualStyleBackColor = true;
            // 
            // cbxTIFF
            // 
            this.cbxTIFF.AutoSize = true;
            this.cbxTIFF.Location = new System.Drawing.Point(21, 128);
            this.cbxTIFF.Name = "cbxTIFF";
            this.cbxTIFF.Size = new System.Drawing.Size(48, 17);
            this.cbxTIFF.TabIndex = 4;
            this.cbxTIFF.Text = "TIFF";
            this.cbxTIFF.UseVisualStyleBackColor = true;
            // 
            // cbxFileNameOnly
            // 
            this.cbxFileNameOnly.AutoSize = true;
            this.cbxFileNameOnly.Location = new System.Drawing.Point(21, 26);
            this.cbxFileNameOnly.Name = "cbxFileNameOnly";
            this.cbxFileNameOnly.Size = new System.Drawing.Size(97, 17);
            this.cbxFileNameOnly.TabIndex = 0;
            this.cbxFileNameOnly.Text = "File Name Only";
            this.cbxFileNameOnly.UseVisualStyleBackColor = true;
            // 
            // lblDirectoryToSearch
            // 
            this.lblDirectoryToSearch.AutoSize = true;
            this.lblDirectoryToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectoryToSearch.Location = new System.Drawing.Point(16, 332);
            this.lblDirectoryToSearch.Name = "lblDirectoryToSearch";
            this.lblDirectoryToSearch.Size = new System.Drawing.Size(131, 16);
            this.lblDirectoryToSearch.TabIndex = 3;
            this.lblDirectoryToSearch.Text = "Directory To Search:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 331);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(527, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lstDisplayFiles
            // 
            this.lstDisplayFiles.FormattingEnabled = true;
            this.lstDisplayFiles.Location = new System.Drawing.Point(173, 63);
            this.lstDisplayFiles.Name = "lstDisplayFiles";
            this.lstDisplayFiles.Size = new System.Drawing.Size(527, 238);
            this.lstDisplayFiles.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(579, 361);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLocateFiles
            // 
            this.btnLocateFiles.Location = new System.Drawing.Point(432, 361);
            this.btnLocateFiles.Name = "btnLocateFiles";
            this.btnLocateFiles.Size = new System.Drawing.Size(121, 23);
            this.btnLocateFiles.TabIndex = 7;
            this.btnLocateFiles.Text = "Locate Files";
            this.btnLocateFiles.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(719, 407);
            this.Controls.Add(this.btnLocateFiles);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstDisplayFiles);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDirectoryToSearch);
            this.Controls.Add(this.grpDisplayOptions);
            this.Controls.Add(this.grpFileFormats);
            this.Controls.Add(this.lblImageFileLocator);
            this.Name = "frmMain";
            this.grpFileFormats.ResumeLayout(false);
            this.grpFileFormats.PerformLayout();
            this.grpDisplayOptions.ResumeLayout(false);
            this.grpDisplayOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    #endregion

    private System.Windows.Forms.Label lblImageFileLocator;
    private System.Windows.Forms.GroupBox grpFileFormats;
    private System.Windows.Forms.CheckBox cbxTIFF;
    private System.Windows.Forms.CheckBox cbxPNG;
    private System.Windows.Forms.CheckBox cbxJPG;
    private System.Windows.Forms.CheckBox cbxGIF;
    private System.Windows.Forms.CheckBox cbxBMP;
    private System.Windows.Forms.GroupBox grpDisplayOptions;
    private System.Windows.Forms.CheckBox cbxFileNameOnly;
    private System.Windows.Forms.Label lblDirectoryToSearch;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.ListBox lstDisplayFiles;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnLocateFiles;
}