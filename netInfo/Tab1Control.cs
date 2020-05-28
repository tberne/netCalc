using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;

namespace netInfo
{
	public partial class Form1 : Form
	{
		private Regex ipRegex = new Regex(
			"^(\\d{1,3})\\.(\\d{1,3})\\.(\\d{1,3})\\.(\\d{1,3})$"
		);

		private void onNet1Changed(object sender, EventArgs args)
		{
			updateTab1();
		}

		private void updateTab1()
		{
			var netAddr = tbNetAddr.Text;
			var mask = tbNetMask.Text;

			var netAddrMatch = ipRegex.Match(netAddr);
			var maskMatch = ipRegex.Match(mask);
			int iIp = -1, iMask = -1;

			var success = true;
			if (!netAddrMatch.Success)
			{
				markFail(tbNetAddr, false);
				success = false;
			}
			else
			{
				var x1 = int.Parse(netAddrMatch.Groups[1].Value);
				var x2 = int.Parse(netAddrMatch.Groups[2].Value);
				var x3 = int.Parse(netAddrMatch.Groups[3].Value);
				var x4 = int.Parse(netAddrMatch.Groups[4].Value);

				try
				{
					iIp = convertToIp(x1, x2, x3, x4);
				}
				catch (Exception e)
				{
					iIp = -1;
				}

				if (iIp == -1)
				{
					markFail(tbNetAddr, false);
					success = false;
				}
				else
				{
					markFail(tbNetAddr, true);
				}
			}

			if (!maskMatch.Success)
			{
				markFail(tbNetMask, false);
				success = false;
			}
			else
			{
				var x1 = int.Parse(maskMatch.Groups[1].Value);
				var x2 = int.Parse(maskMatch.Groups[2].Value);
				var x3 = int.Parse(maskMatch.Groups[3].Value);
				var x4 = int.Parse(maskMatch.Groups[4].Value);

				try
				{
					iMask = convertToIp(x1, x2, x3, x4);
				}
				catch (Exception e)
				{
					iMask = -1;
				}

				if (iMask == -1)
				{
					markFail(tbNetMask, false);
					success = false;
				}
				else
				{
					string binMask = convertToBinIp(iMask);
					if (binMask.Contains("01") || binMask.Contains("0.1"))
					{
						markFail(tbNetMask, false);
						success = false;
					}
					else
					{
						markFail(tbNetMask, true);
					}
				}
			}

			clearTab1Data();
			if (success)
			{
				updateTab1Info(iIp, iMask);
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

		private void clearTab1Data()
		{
			lblFirstHost.Text
				= lblIpBin.Text
				= lblLastHost.Text
				= lblMaskBin.Text
				= lblNumHosts.Text
				= lblBroadcast.Text
				= lblNetAddr.Text
				= "";
		}

		private void updateTab1Info(int ip, int mask)
		{
			lblIpBin.Text = convertToBinIp(ip);
			lblMaskBin.Text = convertToBinIp(mask);

			int totalHosts = (int)Math.Pow(2, countZeros(lblMaskBin.Text));
			lblNumHosts.Text = (totalHosts - 2).ToString();

			var netHost = convertToBinIp(ip & mask);
			lblNetAddr.Text = netHost + " (" + convertBinaryToReadable(netHost) + ")";

			var firstHost = convertToBinIp(ip & mask + 1);
			lblFirstHost.Text = firstHost + " (" + convertBinaryToReadable(firstHost) + ")";

			var broadCastIp = (ip & mask) | ~mask;
			var broadCastIpStr = convertToBinIp(broadCastIp);
			lblBroadcast.Text = broadCastIpStr + " (" + convertBinaryToReadable(broadCastIpStr) + ")";

			var lastHostStr = convertToBinIp(broadCastIp - 1);
			lblLastHost.Text = lastHostStr + " (" + convertBinaryToReadable(lastHostStr) + ")";
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
