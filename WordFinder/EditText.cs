using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordFinder
{
	public partial class EditText : Form
	{
		public int a = 0;
		public EditText()
		{
			InitializeComponent();
		}
		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				bunifuButton1_Click(sender, e);
			}

		}
		private void EditText_Load(object sender, EventArgs e)
		{
			label1.Text = WordFind.selectedLineFile;
			textBox1.Text = WordFind.selectLine;

		}
		//private void buttonCancel_Click(object sender, EventArgs e)
		//{
		//	WordFind master = (WordFind)Application.OpenForms["WordFinder"];
		//	//master.searchData.PerformClick();
		//	this.Dispose();
  //          this.Close();
		//}
		private void bunifuButton1_Click(object sender, EventArgs e)
		{
			string wholetext = File.ReadAllText(WordFind.selectedLineFile);

			char[] textbreak = wholetext.ToCharArray();
			//Console.Write(textbreak[1].ToString());
			int s = 0;
			int t = 0;
			int countLines = 0;

			for (int i = 0; i < textbreak.Length; i++)
			{
				t++;
				string tester = textbreak[i].ToString();
				//Console.Write(textbreak[i]);
				if (tester.Equals("."))
				{
					//breakdown[countLines] = wholetext.Substring(s, i);
					countLines++;



					if (wholetext.Substring(s, t).IndexOf(WordFind.selectLine, StringComparison.CurrentCultureIgnoreCase) >= 0)
					//(record.Contains(textSearch.Text))
					{
						//colour change of the text in the string to be added

						//	String WholeData = wholetext.Substring(s, t);

						var aStringBuilder = new StringBuilder(wholetext);
						aStringBuilder.Remove(s, t);
						aStringBuilder.Insert(s, textBox1.Text);
						wholetext = aStringBuilder.ToString();
						goto getOut;


					}


					//}


					s = s + t;
					t = 0;

				}

			}
			getOut: Console.WriteLine("DONE");
			File.WriteAllText(WordFind.selectedLineFile, wholetext);
			//System.Windows.Forms.MessageBox.Show("UPDATED");
			Update t2 = new Update();
			t2.ShowDialog();

            //WordFind master = (WordFind)Application.OpenForms["WordFinder"];
            //master.searchData.PerformClick();


          

			this.Dispose();
		}

		private void buttonCancel_Click_1(object sender, EventArgs e)
		{
            //WordFind master = (WordFind)Application.OpenForms["WordFinder"];
            
            this.Close();
			//this.Dispose();
		}
	}
}
