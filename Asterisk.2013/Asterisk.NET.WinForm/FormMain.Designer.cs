namespace AsterNET.WinForm
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.lable1 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(12, 46);
            this.lable1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(56, 25);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Host";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(188, 37);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(6);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(196, 31);
            this.tbAddress.TabIndex = 1;
            this.tbAddress.Text = "192.168.2.51";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbUser);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPort);
            this.groupBox1.Controls.Add(this.lable1);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(400, 288);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters connection";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(188, 237);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(6);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(200, 44);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(18, 237);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(150, 44);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "User";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(188, 137);
            this.tbUser.Margin = new System.Windows.Forms.Padding(6);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(196, 31);
            this.tbUser.TabIndex = 5;
            this.tbUser.Text = "admin";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(188, 187);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(6);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(196, 31);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.Text = "123Test";
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(188, 87);
            this.tbPort.Margin = new System.Windows.Forms.Padding(6);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(196, 31);
            this.tbPort.TabIndex = 3;
            this.tbPort.Text = "5038";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(19, 314);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(899, 229);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(617, 39);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(285, 31);
            this.txtExtension.TabIndex = 4;
            this.txtExtension.TextChanged += new System.EventHandler(this.txtExtension_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Extension";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client for Asterisk";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lable1;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbUser;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbPort;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label label1;
    }
}

