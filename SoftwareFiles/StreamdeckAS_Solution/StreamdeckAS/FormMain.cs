using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;

namespace StreamdeckAS
{
    public partial class FormMain : Form
    {
        SerialPort port;
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnInizia_Click(object sender, EventArgs e)
        {
            port = new SerialPort("COM3", 9600);
            port.DataReceived += Port_DataReceived;
            port.Open();

            MessageBox.Show("Connessione stabilita");
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string input = port.ReadLine().Trim();

            if (input == "1")
                Process.Start("chrome.exe", "https://randomuserolivero.altervista.org");
            else if (input == "2")
                Process.Start("D:\\Epic Games\\Launcher\\Portal\\Binaries\\Win64\\EpicGamesLauncher.exe");
        }

        private void btnTermina_Click(object sender, EventArgs e)
        {
            port.Close();
        }
    }
}
