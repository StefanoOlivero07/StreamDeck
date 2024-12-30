using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;

namespace StreamdeckAS
{
    public partial class FormMain : Form
    {
        SerialPort port;
        bool isOn = false;

        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            port = new SerialPort("COM3", 9600);
            port.DataReceived += Port_DataReceived;
            port.Open();
            MessageBox.Show("Connessione stabilita");

        }

        private void btnInizia_Click(object sender, EventArgs e)
        {
            isOn = true;
            ManageButtons();
        }

        // Per terminare tutti i processi relativi ad un programma
        //foreach (var process in Process.GetProcessesByName("chrome"))
        //{
        //     process.Kill();
        //}

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string input = port.ReadLine().Trim();

            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateUI(input)));
            }
            else
            {
                UpdateUI(input);
            }
        }

        private void UpdateUI(string input)
        {
            if (input == "acc")
                isOn = !isOn;

            if (isOn)
            {
                if (input == "1")
                    Process.Start("chrome.exe", "https://randomuserolivero.altervista.org");
                else if (input == "2")
                    Process.Start("notepad.exe");
            }

            ManageButtons();
        }


        private void btnTermina_Click(object sender, EventArgs e)
        {
            isOn = false;
            ManageButtons();
        }

        private void ManageButtons()
        {
            btnInizia.Enabled = !isOn;
            btnTermina.Enabled = isOn;
        }
    }
}
