using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using file_transfer;

public partial class Main : Form
{
    private Listener listener;
    private TransferClient transferClient;
    private string outputFolder;
    private Timer tmpOverallProg;

    public Main()
    {
        InitializeComponent();
        listener = new Listener();
        listener.Accepted += listener_Accepted;
 
        tmpOverallProg = new Timer();
        tmpOverallProg.Interval = 1000;
        tmpOverallProg.Tick += tmpOverallProg_Tick;

        outputFolder = "Transfers";

        if (!Directory.Exists(outputFolder))
        {
            Directory.CreateDirectory(outputFolder);
        }

        btnConnect.Click += new EventHandler(btnConnect_Click);
        btnStartServer.Click += new EventHandler(btnStartServer_Click);
        btnStopServer.Click += new EventHandler(btnStopServer_Click);
        btnSendFile.Click += new EventHandler(btnSendFile_Click);
        btnPauseTransfer.Click += new EventHandler(btnPauseTransfer_Click);
        btnStopTransfer.Click += new EventHandler(btnStopTransfer_Click);
        btnOpenDir.Click += new EventHandler(btnOpenDir_Click);
        btnClearComplete.Click += new EventHandler(btnClearComplete_Click);

        btnStopServer.Enabled = false;
    }

    void tmpOverallProg_Tick(object sender, EventArgs e)
    {

    }                                                           

    void listener_Accepted(object sender, SocketAcceptedEventArgs e)
    {

    }

    private void btnConnect_Click(object sender, EventArgs e)
    {
		if (transferClient == null)
        {
            transferClient = new TransferClient();
            transferClient.Connect(txtCntHost.Text.Trim(), int.Parse(txtCntPort.Text.Trim()), connectCallback);
            Enabled = false;
        }
        else
        {
            transferClient.Close();
            transferClient = null;
        }
    }

    private void connectCallback(object sender, string error)
    {
        if (InvokeRequired)
        {
            Invoke(new ConnectCallback(connectCallback), sender, error);
            return;
        }
        Enabled = true;
        if (error != null)
        {
            transferClient.Close();
            transferClient = null;
            MessageBox.Show(error, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
        }
    }

    private void registerEvents()
    {

    }

    private void deregisterEvents()
    {

    }

    private void btnStartServer_Click(object sender, EventArgs e)
    {
		
    }

    private void btnStopServer_Click(object sender, EventArgs e)
    {
		
    }

    private void btnClearComplete_Click(object sender, EventArgs e)
    {
		
    }

    private void btnOpenDir_Click(object sender, EventArgs e)
    {
		
    }

    private void btnSendFile_Click(object sender, EventArgs e)
    {
		
    }

    private void btnPauseTransfer_Click(object sender, EventArgs e)
    {
		
    }

    private void btnStopTransfer_Click(object sender, EventArgs e)
    {
		
    }
}