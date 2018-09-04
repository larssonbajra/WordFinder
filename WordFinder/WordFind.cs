using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WordFinder
{
    
	public partial class WordFind : Form
	{
		public List<string> files = new List<string>();
		public string fileSelected;
		public static string selectLine = "";
		public static string selectedLineFile = "";
        
		
		public WordFind()
		{
			InitializeComponent();
			
			//myPreloader1.Dispose();
		}
		
		public void searchData_Click(object sender, EventArgs e)
        {
            Program.search_string = textData.Text;
            //search_text = textData.Text;
            research_data(textData.Text);
           
            
        }
        public void research_data(string new_str)
        {
            textData.Text = new_str;
            int progVal = 0;
            bunifuProgressBar1.Visible = true;

            //myPreloader1.Visible = true;


            //System.Windows.Forms.MessageBox.Show("WORKS ))");
            label2.Text = "";
            fileSelected = null;
            int counter = 0;
            listData.Items.Clear();
            files.Clear();
            listFile.Items.Clear();
            try
            {
                string[] fileEntries = Directory.GetFiles(@"D:\Files");
                foreach (string fileName in fileEntries)
                {

                    Console.Write(fileName);
                    string wholetext = File.ReadAllText(fileName);
                    Console.Write(wholetext);
                    //String wholetext = File.ReadAllText(fileName, System.Text.Encoding.GetEncoding(1252));

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
                            if (textData.Text.Equals(""))
                            {
                                label1.Text = "";
                                System.Windows.Forms.MessageBox.Show("Cannot leave a blank for search");

                                goto Last;
                                //break;
                            }
                            string ast = textData.Text.Substring(textData.Text.Length - 1);

                            if (wholetext.Substring(s, t).IndexOf(textData.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                            //(record.Contains(textSearch.Text))
                            {
                                //colour change of the text in the string to be added

                                String WholeData = wholetext.Substring(s, t);




                                listData.Items.Add(WholeData);
                                files.Add(fileName);
                                counter++;
                                //listData.Items.Add(" ");


                                if (!listFile.Items.Contains(fileName))
                                {

                                    listFile.Items.Add(fileName);
                                }
                            }
                            // Display a horizontal scroll bar.
                            listData.HorizontalScrollbar = true;

                            //}


                            s = i + 1;
                            t = 0;

                        }

                    }
                    //listData.Items.Add(wholetext);
                    bunifuProgressBar1.Value = progVal;
                    progVal++;
                    if (progVal > 100)
                    {
                        progVal = 100;
                    }

                }




                if (counter == 0)
                {
                    System.Windows.Forms.MessageBox.Show("No matches found");

                }
                else
                {
                    label1.Text = counter.ToString() + " times Found";
                    //this.listData.MouseDoubleClick += new MouseEventHandler(listData_MouseDoubleClick);

                }
                Last: Console.Write("end");
                //myPreloader1.Visible = false;
                bunifuProgressBar1.Visible = false;

               

            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("No Folder Found in E:/Files");
            }

        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show("Version 1.0 ( Developed by Dept of ICT, Changwon National University (Larsson Bajracharya and Jeongjun Mun ))");
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void saveFile_Click(object sender, EventArgs e)
		{
			if (listData.Items.Count == 0)
			{
				System.Windows.Forms.MessageBox.Show("There is no data searched");

			}
			else
			{

				//System.IO.File.WriteAllText(@"C:\Word Search\searchData.txt", listData.Items.ToString());
				//System.Windows.Forms.MessageBox.Show("Data saved in C drive Word Search folder as searchData.txt");
				SaveFileDialog saveFileDialog1 = new SaveFileDialog();

				saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
				saveFileDialog1.FilterIndex = 2;
				saveFileDialog1.RestoreDirectory = true;

				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{


					System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.FileName.ToString());
					foreach (var item in listData.Items)
					{
						file.WriteLine(item.ToString());
					}
					//file.WriteLine(listData);
					file.Close();
					System.Windows.Forms.MessageBox.Show("SAVED");
				}
			}

		}

		private void listFile_SelectedIndexChanged(object sender, EventArgs e)
		{
			int counter = 0;
			listData.Items.Clear();
			files.Clear();
			fileSelected = listFile.Text;
			label2.Text = fileSelected;
			string wholetext = File.ReadAllText(listFile.Text);
			//string wholetext = File.ReadAllText(listFile.Text,Encoding.GetEncoding(ks_c_5601 - 1987));
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
					if (textData.Text.Equals(""))
					{
						System.Windows.Forms.MessageBox.Show("Cannot leave a blank for search");
						goto Last;
						//break;
					}
					string ast = textData.Text.Substring(textData.Text.Length - 1);

					if (wholetext.Substring(s, t).IndexOf(textData.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
					//(record.Contains(textSearch.Text))
					{
						//colour change of the text in the string to be added


						listData.Items.Add(wholetext.Substring(s, t));
						counter++;
						//listData.Items.Add(" ");



					}
					// Display a horizontal scroll bar.
					listData.HorizontalScrollbar = true;

					//}


					s = i + 1;
					t = 0;

				}

			}
			//listData.Items.Add(wholetext);



			Last: Console.Write("end");
			label1.Text = counter.ToString() + " times Found";



		}
		private void listData_SelectedIndexChanged(object sender, EventArgs e)
		{

			selectLine = listData.Text.ToString();


			if (fileSelected == null)
			{
				int indexData = listData.SelectedIndex;
				if (indexData < 0)
				{
					goto skiploop;
				}

				selectedLineFile = files[indexData].ToString();
			}
			else
			{
				selectedLineFile = fileSelected;
			}
			label2.Text = selectedLineFile;
			skiploop: Console.WriteLine("SKIPPED");



		}
		//void listData_MouseDoubleClick(object sender, EventArgs e)
		//{

		//	selectLine = listData.Text.ToString();
		//	int indexData = listData.SelectedIndex;
		//	if (indexData < 0)
		//	{
		//		goto out1;
		//	}

		//	if (fileSelected == null)
		//	{


		//		selectedLineFile = files[indexData].ToString();
		//	}
		//	else
		//	{

		//		selectedLineFile = fileSelected;
		//	}
		//	EditText f2 = new EditText();
			


		//	f2.ShowDialog();
  //          f2.Close();
  //          f2.Dispose();
		//	out1: Console.WriteLine("avoided");



		//}

		private void listFile_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			int counter = 0;
			listData.Items.Clear();
			files.Clear();
			fileSelected = listFile.Text;
			label2.Text = fileSelected;
			string wholetext = File.ReadAllText(listFile.Text);
			//string wholetext = File.ReadAllText(listFile.Text,Encoding.GetEncoding(ks_c_5601 - 1987));
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
					if (textData.Text.Equals(""))
					{
						System.Windows.Forms.MessageBox.Show("Cannot leave a blank for search");
						goto Last;
						//break;
					}
					string ast = textData.Text.Substring(textData.Text.Length - 1);

					if (wholetext.Substring(s, t).IndexOf(textData.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
					//(record.Contains(textSearch.Text))
					{
						//colour change of the text in the string to be added


						listData.Items.Add(wholetext.Substring(s, t));
						counter++;
						//listData.Items.Add(" ");



					}
					// Display a horizontal scroll bar.
					listData.HorizontalScrollbar = true;

					//}


					s = i + 1;
					t = 0;

				}

			}
			//listData.Items.Add(wholetext);



			Last: Console.Write("end");
			label1.Text = counter.ToString() + " times Found";


		}

		private void listData_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			
			selectLine = listData.Text.ToString();


			if (fileSelected == null)
			{
				int indexData = listData.SelectedIndex;
				if (indexData < 0)
				{
					goto skiploop;
				}

				selectedLineFile = files[indexData].ToString();
			}
			else
			{
				selectedLineFile = fileSelected;
			}
			label2.Text = selectedLineFile;
			skiploop: Console.WriteLine("SKIPPED");


		}

		private void searchData_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				searchData_Click(sender , e);
			}

		}

		private void myPreloader1_Load(object sender, EventArgs e)
		{

		}

        private void WordFind_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            EditText editText = new EditText();
            editText.Close();
            editText.Dispose();
        }

        //private void listData_MouseDoubleClick(object sender, MouseEventArgs e)
        //{

        //    selectLine = listData.Text.ToString();
        //    int indexData = listData.SelectedIndex;
        //    if (indexData < 0)
        //    {
        //        goto out1;
        //    }

        //    if (fileSelected == null)
        //    {


        //        selectedLineFile = files[indexData].ToString();
        //    }
        //    else
        //    {

        //        selectedLineFile = fileSelected;
        //    }
        //    EditText f2 = new EditText();



        //    f2.ShowDialog();
        //    f2.Close();
        //    f2.Dispose();
        //    out1: Console.WriteLine("avoided");

        //}

        private void listData_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            selectLine = listData.Text.ToString();
            int indexData = listData.SelectedIndex;
            if (indexData < 0)
            {
                goto out1;
            }

            if (fileSelected == null)
            {


                selectedLineFile = files[indexData].ToString();
            }
            else
            {

                selectedLineFile = fileSelected;
            }
            EditText f2 = new EditText();



            f2.ShowDialog();
            f2.Close();
            f2.Dispose();
            out1: Console.WriteLine("avoided");

        }
    }
}
