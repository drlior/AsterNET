using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AsterNET.Manager;
using AsterNET.Manager.Event;
using System.Diagnostics;

namespace AsterNET.WinForm
{
	public partial class FormMain : Form
	{
        public delegate void AddListItem(Object item);
        public AddListItem myAddListItem;


        public void AddListItemMethod(Object item)
        {
                listBox1.Items.Add(item);
                listBox1.Update();
        }

        public FormMain()
		{
            myAddListItem = new AddListItem(AddListItemMethod);
            InitializeComponent();
        }

		private ManagerConnection manager = null;
		private void btnConnect_Click(object sender, EventArgs e)
		{
			string address = this.tbAddress.Text;
			int port = int.Parse(this.tbPort.Text);
			string user = this.tbUser.Text;
			string password = this.tbPassword.Text;

			btnConnect.Enabled = false;
			manager = new ManagerConnection(address, port, user, password);
			manager.UnhandledEvent += new ManagerEventHandler(manager_Events);
            manager.AgentCalled += new AgentCalledEventHandler(manager_AgentCalled);
            manager.NewChannel += new NewChannelEventHandler(manager_NewChannel);
			try
			{
				// Uncomment next 2 line comments to Disable timeout (debug mode)
				// manager.DefaultResponseTimeout = 0;
				// manager.DefaultEventTimeout = 0;
				manager.Login();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error connect\n" + ex.Message);
				manager.Logoff();
				this.Close();
			}
			btnDisconnect.Enabled = true;
		}

        void manager_NewChannel(object sender, NewChannelEvent e)
        {
            Debug.WriteLine("Event : " + e.GetType().Name);

            this.Invoke(myAddListItem, e);        
        }

        void manager_AgentCalled(object sender, AgentCalledEvent e) {
            Debug.WriteLine("Event : " + e.GetType().Name);
            this.Invoke(myAddListItem, e);
        }

		void manager_Events(object sender, ManagerEvent e)
		{
			Debug.WriteLine("Event : " + e.GetType().Name);
            this.Invoke(myAddListItem, e);
        }

		private void btnDisconnect_Click(object sender, EventArgs e)
		{
			btnConnect.Enabled = true;
			if (this.manager != null)
			{
				manager.Logoff();
				this.manager = null;
			}
			btnDisconnect.Enabled = false;
		}
	}
}
