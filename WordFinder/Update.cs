using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordFinder
{
	public partial class Update : Form
	{
		public Update()
		{
			InitializeComponent();
		
		}

		private void bunifuButton1_Click(object sender, EventArgs e)
		{

			this.Close();
		}

		private void Updated_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.Close();
				bunifuButton1_Click(sender, e);
			}
		}

	
	}
}
