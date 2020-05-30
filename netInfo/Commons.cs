using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace netInfo
{
	public partial class Form1 : Form
	{
		private Regex ipRegex = new Regex(
			"^(\\d{1,3})\\.(\\d{1,3})\\.(\\d{1,3})\\.(\\d{1,3})$"
		);

		protected int GetIpFromTextBox(TextBox tb)
		{
			var netAddrMatch = ipRegex.Match(tb.Text);

			if (!netAddrMatch.Success)
			{
				markFail(tb, false);
				return -1;
			}
			else
			{
				var x1 = int.Parse(netAddrMatch.Groups[1].Value);
				var x2 = int.Parse(netAddrMatch.Groups[2].Value);
				var x3 = int.Parse(netAddrMatch.Groups[3].Value);
				var x4 = int.Parse(netAddrMatch.Groups[4].Value);

				int iIp;
				try
				{
					iIp = convertToIp(x1, x2, x3, x4);
				}
				catch (Exception e)
				{
					markFail(tb, false);
					return -1;
				}

				markFail(tb, true);
				return iIp;
			}
		}
		
		private int convertToIp(int x1, int x2, int x3, int x4)
		{
			int i = 0;

			if (!isValidOcted(x1))
			{
				throw new Exception("Invalid octed");
			}
			if (!isValidOcted(x2))
			{
				throw new Exception("Invalid octed");
			}
			if (!isValidOcted(x3))
			{
				throw new Exception("Invalid octed");
			}
			if (!isValidOcted(x4))
			{
				throw new Exception("Invalid octed");
			}

			i = x4;
			i |= x3 << 8;
			i |= x2 << 16;
			i |= x1 << 24;

			return i;
		}

		private bool isValidOcted(int octet)
		{
			return octet >= 0 && octet <= 255;
		}

		private void markFail(TextBox tb, bool success)
		{
			var color = success ? Color.FromArgb(215, 255, 196) : Color.FromArgb(255, 196, 196);
			tb.BackColor = color;
		}

		private String convertToBinIp(int ip)
		{
			String ipBin = Convert.ToString(ip, 2);

			while (ipBin.Length < 32)
			{
				ipBin = "0" + ipBin;
			}

			string ipBin2 = "";
			int idx = 1;
			while (idx <= 32)
			{
				ipBin2 += ipBin[idx - 1];

				if (idx % 8 == 0 && idx < 32)
				{
					ipBin2 += ".";
				}

				idx++;
			}

			return ipBin2;
		}

		private int countZeros(string x)
		{
			int i = 0;
			for (int idx = 0; idx < x.Length; idx++)
			{
				if (x[idx] == '0')
					i++;
			}

			return i;
		}

		private string convertBinaryToReadable(string binIp)
		{
			binIp = binIp.Replace(".", "");

			string x = "";

			for (int i = 0; i < 4; i++)
			{
				if (i > 0)
					x += ".";

				x += Convert.ToInt32(binIp.Substring(8 * i, 8), 2).ToString();
			}

			return x;
		}
	}
}
