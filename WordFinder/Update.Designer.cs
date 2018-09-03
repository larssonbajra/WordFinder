namespace WordFinder
{
	partial class Update
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
			this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bunifuButton1
			// 
			this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
			this.bunifuButton1.ButtonText = "OK";
			this.bunifuButton1.ButtonTextMarginLeft = 0;
			this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Gray;
			this.bunifuButton1.DisabledForecolor = System.Drawing.Color.White;
			this.bunifuButton1.ForeColor = System.Drawing.Color.White;
			this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.bunifuButton1.IconPadding = 10;
			this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Empty;
			this.bunifuButton1.IdleBorderRadius = 1;
			this.bunifuButton1.IdleBorderThickness = 0;
			this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
			this.bunifuButton1.IdleIconLeftImage = null;
			this.bunifuButton1.IdleIconRightImage = null;
			this.bunifuButton1.Location = new System.Drawing.Point(76, 54);
			this.bunifuButton1.Name = "bunifuButton1";
			stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			stateProperties1.BorderRadius = 1;
			stateProperties1.BorderThickness = 1;
			stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			stateProperties1.IconLeftImage = null;
			stateProperties1.IconRightImage = null;
			this.bunifuButton1.onHoverState = stateProperties1;
			this.bunifuButton1.Size = new System.Drawing.Size(147, 45);
			this.bunifuButton1.TabIndex = 0;
			this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(227, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Data Updated Successfully";
			// 
			// Update
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 111);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bunifuButton1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Update";
			this.Text = "Update";

			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Updated_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
		private System.Windows.Forms.Label label1;
	}
}