namespace WordFinder
{
	partial class EditText
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditText));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
			this.textBox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.bunifuEditLabel = new Bunifu.UI.WinForms.BunifuLabel();
			this.buttonSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.buttonCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.textBox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.textBox1.HintForeColor = System.Drawing.Color.Empty;
			this.textBox1.HintText = "";
			this.textBox1.isPassword = false;
			this.textBox1.LineFocusedColor = System.Drawing.Color.SlateGray;
			this.textBox1.LineIdleColor = System.Drawing.Color.Gray;
			this.textBox1.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.textBox1.LineThickness = 3;
			this.textBox1.Location = new System.Drawing.Point(145, 35);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.MaxLength = 32767;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(379, 33);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.bunifuEditLabel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(130, 166);
			this.panel1.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(14, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 90);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// bunifuEditLabel
			// 
			this.bunifuEditLabel.AutoEllipsis = false;
			this.bunifuEditLabel.CursorType = null;
			this.bunifuEditLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuEditLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bunifuEditLabel.Location = new System.Drawing.Point(0, 102);
			this.bunifuEditLabel.Name = "bunifuEditLabel";
			this.bunifuEditLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bunifuEditLabel.Size = new System.Drawing.Size(131, 34);
			this.bunifuEditLabel.TabIndex = 0;
			this.bunifuEditLabel.Text = "Edit the sentence \r\n    selected here";
			this.bunifuEditLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
			// 
			// buttonSave
			// 
			this.buttonSave.BackColor = System.Drawing.Color.Transparent;
			this.buttonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave.BackgroundImage")));
			this.buttonSave.ButtonText = "Save";
			this.buttonSave.ButtonTextMarginLeft = 0;
			this.buttonSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.buttonSave.DisabledFillColor = System.Drawing.Color.Gray;
			this.buttonSave.DisabledForecolor = System.Drawing.Color.White;
			this.buttonSave.ForeColor = System.Drawing.Color.White;
			this.buttonSave.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.buttonSave.IconPadding = 10;
			this.buttonSave.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.buttonSave.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
			this.buttonSave.IdleBorderRadius = 1;
			this.buttonSave.IdleBorderThickness = 0;
			this.buttonSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
			this.buttonSave.IdleIconLeftImage = null;
			this.buttonSave.IdleIconRightImage = null;
			this.buttonSave.Location = new System.Drawing.Point(145, 102);
			this.buttonSave.Name = "buttonSave";
			stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			stateProperties1.BorderRadius = 1;
			stateProperties1.BorderThickness = 1;
			stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			stateProperties1.IconLeftImage = null;
			stateProperties1.IconRightImage = null;
			this.buttonSave.onHoverState = stateProperties1;
			this.buttonSave.Size = new System.Drawing.Size(121, 45);
			this.buttonSave.TabIndex = 2;
			this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonSave.Click += new System.EventHandler(this.bunifuButton1_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
			this.buttonCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancel.BackgroundImage")));
			this.buttonCancel.ButtonText = "Cancel";
			this.buttonCancel.ButtonTextMarginLeft = 0;
			this.buttonCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.buttonCancel.DisabledFillColor = System.Drawing.Color.Gray;
			this.buttonCancel.DisabledForecolor = System.Drawing.Color.White;
			this.buttonCancel.ForeColor = System.Drawing.Color.White;
			this.buttonCancel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.buttonCancel.IconPadding = 10;
			this.buttonCancel.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.buttonCancel.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
			this.buttonCancel.IdleBorderRadius = 1;
			this.buttonCancel.IdleBorderThickness = 0;
			this.buttonCancel.IdleFillColor = System.Drawing.Color.Red;
			this.buttonCancel.IdleIconLeftImage = null;
			this.buttonCancel.IdleIconRightImage = null;
			this.buttonCancel.Location = new System.Drawing.Point(295, 102);
			this.buttonCancel.Name = "buttonCancel";
			stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			stateProperties2.BorderRadius = 1;
			stateProperties2.BorderThickness = 1;
			stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			stateProperties2.IconLeftImage = null;
			stateProperties2.IconRightImage = null;
			this.buttonCancel.onHoverState = stateProperties2;
			this.buttonCancel.Size = new System.Drawing.Size(121, 45);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(145, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "label1";
			// 
			// EditText
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(547, 166);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EditText";
			this.Text = "EditText";
			this.Load += new System.EventHandler(this.EditText_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuMaterialTextbox textBox1;
		private System.Windows.Forms.Panel panel1;
		private Bunifu.UI.WinForms.BunifuLabel bunifuEditLabel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton buttonSave;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton buttonCancel;
		private System.Windows.Forms.Label label1;
	}
}