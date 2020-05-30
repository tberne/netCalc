using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace netInfo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			tbNetAddr.TextChanged += onNet1Changed;
			tbNetMask.TextChanged += onNet1Changed;

			updateTab1();

			t2TbIp.TextChanged += onNet2Changed;
			t2TbBits.TextChanged += onNet2Changed;

			updateTab2();
		}

		private void label21_Click(object sender, EventArgs e)
		{

		}
	}
}
