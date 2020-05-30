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
		private Regex netSizeRegex = new Regex("^\\d+$");

		private void onNet2Changed(object sender, EventArgs args)
		{
			updateTab2();
		}

		private void updateTab2()
		{
			var netIp = GetIpFromTextBox(t2TbIp);
			int numBits = -1;
			bool success = netIp != -1;

			var bitsSizeStr = t2TbBits.Text;
			Match bsMatch = netSizeRegex.Match(bitsSizeStr);
			if(!bsMatch.Success)
			{
				success = false;
				markFail(t2TbBits, false);
			}
			else
			{
				if(!int.TryParse(bsMatch.Groups[0].Value, out numBits))
				{
					success = false;
					markFail(t2TbBits, false);
				}
				else
				{
					if(numBits < 1 || numBits > 31)
					{
						success = false;
						markFail(t2TbBits, false);
					}
					else
					{
						markFail(t2TbBits, true);
					}
				}
			}

			clearTab2Data();
			if(success)
			{
				updateTab2Info(netIp, numBits);
			}
		}

		private void clearTab2Data()
		{
			Label[] x = { 
				t2LblBroadcast,
				t2LblFirstHost,
				t2LblIpBin,
				t2LblLastHost,
				t2LblMaskBin,
				t2LblMaskDec,
				t2LblNetAddr,
				t2LblNumOfHosts
			};

			foreach(var l in x)
			{
				l.Text = "";
			}
		}

		private void updateTab2Info(int ip, int numMaskBits)
		{
			var netMaskTmp = new String('1', numMaskBits) + new string('0', 32 - numMaskBits);

			int iNetMask = 0;
			var netMask = "";
			var netMaskDec = "";
			for(int i = 0; i < 4; i++)
			{
				if(i > 0)
				{
					netMask += ".";
					netMaskDec += ".";
				}

				var netMaskPart = netMaskTmp.Substring(8 * i, 8);
				netMask += netMaskPart;
				var iNetMaskPart = Convert.ToInt32(netMaskPart, 2);
				iNetMask |= iNetMaskPart << (8 * (3 - i));
				netMaskDec += iNetMaskPart.ToString();
			}

			t2LblIpBin.Text = convertToBinIp(ip);
			t2LblMaskBin.Text = netMask;
			t2LblMaskDec.Text = netMaskDec;

			int totalHosts = (int)Math.Pow(2, 32 - numMaskBits) - 2;
			t2LblNumOfHosts.Text = totalHosts.ToString();

			var netHost = convertToBinIp(ip & iNetMask);
			t2LblNetAddr.Text = netHost + " (" + convertBinaryToReadable(netHost) + ")";

			var firstHost = convertToBinIp(ip & iNetMask + 1);
			t2LblFirstHost.Text = firstHost + " (" + convertBinaryToReadable(firstHost) + ")";

			var broadCastIp = (ip & iNetMask) | ~iNetMask;
			var broadCastIpStr = convertToBinIp(broadCastIp);
			t2LblBroadcast.Text = broadCastIpStr + " (" + convertBinaryToReadable(broadCastIpStr) + ")";

			var lastHostStr = convertToBinIp(broadCastIp - 1);
			t2LblLastHost.Text = lastHostStr + " (" + convertBinaryToReadable(lastHostStr) + ")";
		}
	}
}
