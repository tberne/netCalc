namespace netInfo
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tbNetAddr = new System.Windows.Forms.TextBox();
			this.tbNetMask = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblIpBin = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblMaskBin = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblNumHosts = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblFirstHost = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblLastHost = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblNetAddr = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblBroadcast = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(776, 426);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.lblBroadcast);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.lblNetAddr);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.lblLastHost);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.lblFirstHost);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.lblNumHosts);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.lblMaskBin);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.lblIpBin);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.tbNetMask);
			this.tabPage1.Controls.Add(this.tbNetAddr);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(768, 400);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Net / Mask";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Net Addr";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(768, 400);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Net / Bits";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tbNetAddr
			// 
			this.tbNetAddr.Location = new System.Drawing.Point(71, 16);
			this.tbNetAddr.Name = "tbNetAddr";
			this.tbNetAddr.Size = new System.Drawing.Size(194, 20);
			this.tbNetAddr.TabIndex = 1;
			// 
			// tbNetMask
			// 
			this.tbNetMask.Location = new System.Drawing.Point(71, 52);
			this.tbNetMask.Name = "tbNetMask";
			this.tbNetMask.Size = new System.Drawing.Size(194, 20);
			this.tbNetMask.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Net Mask";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Ip Binary";
			// 
			// lblIpBin
			// 
			this.lblIpBin.AutoSize = true;
			this.lblIpBin.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIpBin.Location = new System.Drawing.Point(121, 99);
			this.lblIpBin.Name = "lblIpBin";
			this.lblIpBin.Size = new System.Drawing.Size(49, 14);
			this.lblIpBin.TabIndex = 5;
			this.lblIpBin.Text = "label4";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Net Mask Binary";
			// 
			// lblMaskBin
			// 
			this.lblMaskBin.AutoSize = true;
			this.lblMaskBin.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaskBin.Location = new System.Drawing.Point(121, 131);
			this.lblMaskBin.Name = "lblMaskBin";
			this.lblMaskBin.Size = new System.Drawing.Size(49, 14);
			this.lblMaskBin.TabIndex = 7;
			this.lblMaskBin.Text = "label5";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 163);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "# Hosts";
			// 
			// lblNumHosts
			// 
			this.lblNumHosts.AutoSize = true;
			this.lblNumHosts.Location = new System.Drawing.Point(121, 163);
			this.lblNumHosts.Name = "lblNumHosts";
			this.lblNumHosts.Size = new System.Drawing.Size(35, 13);
			this.lblNumHosts.TabIndex = 9;
			this.lblNumHosts.Text = "label6";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 194);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "1st Host";
			// 
			// lblFirstHost
			// 
			this.lblFirstHost.AutoSize = true;
			this.lblFirstHost.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFirstHost.Location = new System.Drawing.Point(121, 194);
			this.lblFirstHost.Name = "lblFirstHost";
			this.lblFirstHost.Size = new System.Drawing.Size(49, 14);
			this.lblFirstHost.TabIndex = 11;
			this.lblFirstHost.Text = "label7";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(19, 225);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Last Host";
			// 
			// lblLastHost
			// 
			this.lblLastHost.AutoSize = true;
			this.lblLastHost.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLastHost.Location = new System.Drawing.Point(124, 225);
			this.lblLastHost.Name = "lblLastHost";
			this.lblLastHost.Size = new System.Drawing.Size(49, 14);
			this.lblLastHost.TabIndex = 13;
			this.lblLastHost.Text = "label8";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(22, 252);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(49, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Net Addr";
			// 
			// lblNetAddr
			// 
			this.lblNetAddr.AutoSize = true;
			this.lblNetAddr.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNetAddr.Location = new System.Drawing.Point(127, 252);
			this.lblNetAddr.Name = "lblNetAddr";
			this.lblNetAddr.Size = new System.Drawing.Size(49, 14);
			this.lblNetAddr.TabIndex = 15;
			this.lblNetAddr.Text = "label9";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(19, 277);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "Broadcast Addr";
			// 
			// lblBroadcast
			// 
			this.lblBroadcast.AutoSize = true;
			this.lblBroadcast.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBroadcast.Location = new System.Drawing.Point(124, 277);
			this.lblBroadcast.Name = "lblBroadcast";
			this.lblBroadcast.Size = new System.Drawing.Size(56, 14);
			this.lblBroadcast.TabIndex = 17;
			this.lblBroadcast.Text = "label10";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbNetMask;
		private System.Windows.Forms.TextBox tbNetAddr;
		private System.Windows.Forms.Label lblMaskBin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblIpBin;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblNumHosts;
		private System.Windows.Forms.Label lblFirstHost;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblLastHost;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblNetAddr;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblBroadcast;
		private System.Windows.Forms.Label label9;
	}
}

