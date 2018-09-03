namespace WordFinder
{
	partial class WordFind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordFind));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.listFile = new System.Windows.Forms.ListBox();
            this.saveFile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchData = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.textData = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listData = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(116, 0);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 0;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.panelLeft.Controls.Add(this.bunifuProgressBar1);
            this.panelLeft.Controls.Add(this.listFile);
            this.panelLeft.Controls.Add(this.saveFile);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Controls.Add(this.searchData);
            this.panelLeft.Controls.Add(this.textData);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 443);
            this.panelLeft.TabIndex = 1;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Snow;
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(6, 405);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.SteelBlue;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(185, 26);
            this.bunifuProgressBar1.TabIndex = 4;
            this.bunifuProgressBar1.Value = 5;
            this.bunifuProgressBar1.Visible = false;
            // 
            // listFile
            // 
            this.listFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFile.FormattingEnabled = true;
            this.listFile.ItemHeight = 16;
            this.listFile.Location = new System.Drawing.Point(6, 295);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(185, 100);
            this.listFile.TabIndex = 3;
            this.listFile.SelectedIndexChanged += new System.EventHandler(this.listFile_SelectedIndexChanged_1);
            // 
            // saveFile
            // 
            this.saveFile.Active = false;
            this.saveFile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveFile.BorderRadius = 0;
            this.saveFile.ButtonText = "Save to Txt ";
            this.saveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveFile.DisabledColor = System.Drawing.Color.Gray;
            this.saveFile.Iconcolor = System.Drawing.Color.Transparent;
            this.saveFile.Iconimage = ((System.Drawing.Image)(resources.GetObject("saveFile.Iconimage")));
            this.saveFile.Iconimage_right = null;
            this.saveFile.Iconimage_right_Selected = null;
            this.saveFile.Iconimage_Selected = null;
            this.saveFile.IconMarginLeft = 0;
            this.saveFile.IconMarginRight = 0;
            this.saveFile.IconRightVisible = true;
            this.saveFile.IconRightZoom = 0D;
            this.saveFile.IconVisible = true;
            this.saveFile.IconZoom = 90D;
            this.saveFile.IsTab = false;
            this.saveFile.Location = new System.Drawing.Point(6, 241);
            this.saveFile.Name = "saveFile";
            this.saveFile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveFile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.saveFile.OnHoverTextColor = System.Drawing.Color.White;
            this.saveFile.selected = false;
            this.saveFile.Size = new System.Drawing.Size(186, 48);
            this.saveFile.TabIndex = 2;
            this.saveFile.Text = "Save to Txt ";
            this.saveFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveFile.Textcolor = System.Drawing.Color.White;
            this.saveFile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 158);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // searchData
            // 
            this.searchData.BackColor = System.Drawing.Color.Transparent;
            this.searchData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchData.BackgroundImage")));
            this.searchData.ButtonText = "Search";
            this.searchData.ButtonTextMarginLeft = 0;
            this.searchData.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.searchData.DisabledFillColor = System.Drawing.Color.Gray;
            this.searchData.DisabledForecolor = System.Drawing.Color.White;
            this.searchData.ForeColor = System.Drawing.Color.White;
            this.searchData.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.searchData.IconPadding = 10;
            this.searchData.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.searchData.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.searchData.IdleBorderRadius = 1;
            this.searchData.IdleBorderThickness = 0;
            this.searchData.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.searchData.IdleIconLeftImage = null;
            this.searchData.IdleIconRightImage = null;
            this.searchData.Location = new System.Drawing.Point(5, 183);
            this.searchData.Name = "searchData";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.searchData.onHoverState = stateProperties1;
            this.searchData.Size = new System.Drawing.Size(187, 45);
            this.searchData.TabIndex = 1;
            this.searchData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchData.Click += new System.EventHandler(this.searchData_Click);
            // 
            // textData
            // 
            this.textData.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textData.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textData.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textData.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textData.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textData.HintForeColor = System.Drawing.Color.Empty;
            this.textData.HintText = "enter text here";
            this.textData.isPassword = false;
            this.textData.LineFocusedColor = System.Drawing.Color.Blue;
            this.textData.LineIdleColor = System.Drawing.Color.Gray;
            this.textData.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textData.LineThickness = 3;
            this.textData.Location = new System.Drawing.Point(4, 137);
            this.textData.Margin = new System.Windows.Forms.Padding(4);
            this.textData.MaxLength = 32767;
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(189, 33);
            this.textData.TabIndex = 0;
            this.textData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchData_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listData);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 443);
            this.panel1.TabIndex = 2;
            // 
            // listData
            // 
            this.listData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listData.FormattingEnabled = true;
            this.listData.ItemHeight = 16;
            this.listData.Location = new System.Drawing.Point(23, 40);
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(450, 308);
            this.listData.TabIndex = 4;
            this.listData.SelectedIndexChanged += new System.EventHandler(this.listData_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // WordFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.doubleBitmapControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WordFind";
            this.Text = "WordFinder";
            this.Load += new System.EventHandler(this.WordFind_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
		private System.Windows.Forms.Panel panelLeft;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private Bunifu.Framework.UI.BunifuMaterialTextbox textData;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton searchData;
		private Bunifu.Framework.UI.BunifuFlatButton saveFile;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listFile;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ListBox listData;
		private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
	}
}

