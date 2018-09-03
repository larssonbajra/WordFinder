namespace WordFinder
{
	partial class MyPreloader
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPreloader));
			this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
			this.stretch = new System.Windows.Forms.Timer(this.components);
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.SuspendLayout();
			// 
			// bunifuCircleProgressbar1
			// 
			this.bunifuCircleProgressbar1.animated = true;
			this.bunifuCircleProgressbar1.animationIterval = 2;
			this.bunifuCircleProgressbar1.animationSpeed = 1;
			this.bunifuCircleProgressbar1.AutoSize = true;
			this.bunifuCircleProgressbar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
			this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
			this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
			this.bunifuCircleProgressbar1.LabelVisible = false;
			this.bunifuCircleProgressbar1.LineProgressThickness = 15;
			this.bunifuCircleProgressbar1.LineThickness = 15;
			this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(10, 9);
			this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
			this.bunifuCircleProgressbar1.MaxValue = 100;
			this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
			this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.SystemColors.Control;
			this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
			this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(48, 48);
			this.bunifuCircleProgressbar1.TabIndex = 0;
			this.bunifuCircleProgressbar1.Value = 30;
			// 
			// stretch
			// 
			this.stretch.Enabled = true;
			this.stretch.Tick += new System.EventHandler(this.stretch_Tick);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			// 
			// MyPreloader
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Controls.Add(this.bunifuCircleProgressbar1);
			this.Name = "MyPreloader";
			this.Size = new System.Drawing.Size(67, 66);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
		private System.Windows.Forms.Timer stretch;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}
