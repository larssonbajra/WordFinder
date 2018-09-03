using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordFinder
{
	public partial class MyPreloader : UserControl
	{
		List<Color> colors = new List<Color>();
		int cur_color = 0;
		public MyPreloader()
		{
			InitializeComponent();
			colors.Add(Color.FromArgb(0, 150, 136));
			colors.Add(Color.FromArgb(0, 188, 212));
			colors.Add(Color.FromArgb(63, 81, 181));
			colors.Add(Color.FromArgb(156, 39, 176));
			bunifuCircleProgressbar1.ProgressColor = colors[cur_color];
		}
		int dir = 1;
		private void stretch_Tick(object sender, EventArgs e)
		{
			if (bunifuCircleProgressbar1.Value==70)
			{
				dir = -1;
				bunifuCircleProgressbar1.animationSpeed = 1;

			}
			else if (bunifuCircleProgressbar1.Value==30)
			{
				dir = +1;
				bunifuCircleProgressbar1.animationSpeed = 2;

			}
			bunifuCircleProgressbar1.Value += dir;
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{

		}
	}
}
