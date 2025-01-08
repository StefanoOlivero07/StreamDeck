using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Drawing;

namespace StreamdeckAS
{
    public partial class FormMain : Form
    {
        SerialPort port;
        bool isOn = false;
        string filePathA = "";
        string filePathB = "";

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
            NotConfiguredLabel(lblBtnA);
            NotConfiguredLabel(lblBtnB);
        }

        private void NotConfiguredLabel(Label lbl)
        {
            lbl.Text = "Not config";
            lbl.ForeColor = Color.Red;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
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
                //UpdateUI(input);
            }
        }

        private void UpdateUI(string input)
        {
            if (input == "acc")
                isOn = !isOn;

            if (isOn)
            {
                if (input == "1" && filePathA != "")
                    Process.Start(filePathA);
                else if (input == "2" && filePathB != "")
                    Process.Start(filePathB);
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

        private void btnProgram_Click(object sender, EventArgs e)
        {
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialogMain.FileName;
                Process.Start(filePath);
            }
        }

        private void btnCambiaA_Click(object sender, EventArgs e)
        {
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                filePathA = openFileDialogMain.FileName;
                ConfiguredLabel(lblBtnA);
            }
        }

        private void btnCambiaB_Click(object sender, EventArgs e)
        {
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                filePathB = openFileDialogMain.FileName;
                ConfiguredLabel(lblBtnB);
            }
        }

        private void ConfiguredLabel(Label lbl)
        {
            lbl.Text = "Config";
            lbl.ForeColor = Color.Green;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
