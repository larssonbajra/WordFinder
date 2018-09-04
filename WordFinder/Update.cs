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
            FormCollection fc = Application.OpenForms;

            if (fc != null && fc.Count > 0)

            {

                for (int i = 1; i < fc.Count; i++)

                {
                    
                    if (fc[i] != null && fc[i].IsDisposed != true)

                    {

                        fc[i].Dispose();

                    }

                }
               

            }
            WordFind master = (WordFind)Application.OpenForms["WordFind"];
            master.research_data(Program.search_string);
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
