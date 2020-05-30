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
		private void onNet1Changed(object sender, EventArgs args)
		{
			updateTab1();
		}

		private void updateTab1()
		{
			var netIp = GetIpFromTextBox(tbNetAddr);
			var maskIp = GetIpFromTextBox(tbNetMask);

			clearTab1Data();
			if (netIp != -1 && maskIp != -1)
			{
				updateTab1Info(netIp, maskIp);
			}
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

			var firstHost = convertToBinIp((ip & mask) + 1);
			lblFirstHost.Text = firstHost + " (" + convertBinaryToReadable(firstHost) + ")";

			var broadCastIp = (ip & mask) | ~mask;
			var broadCastIpStr = convertToBinIp(broadCastIp);
			lblBroadcast.Text = broadCastIpStr + " (" + convertBinaryToReadable(broadCastIpStr) + ")";

			var lastHostStr = convertToBinIp(broadCastIp - 1);
			lblLastHost.Text = lastHostStr + " (" + convertBinaryToReadable(lastHostStr) + ")";
		}
	}
}
