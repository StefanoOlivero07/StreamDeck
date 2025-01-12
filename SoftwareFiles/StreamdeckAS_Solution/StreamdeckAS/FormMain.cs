using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace StreamdeckAS
{
    public partial class FormMain : Form
    {
        SerialPort port;
        bool isOn = false;
        string filePathA = "";
        string filePathB = "";
        string filePathC = "";
        string filePathD = "";

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
            NotConfiguredLabel(lblBtnC);
            NotConfiguredLabel(lblBtnD);
            LoadConfiguration();
        }

        private void LoadConfiguration()
        {
            StreamReader sr = new StreamReader("configuration.csv");
            string[] s;

            while (!sr.EndOfStream)
            {
                s = sr.ReadLine().Trim().Split(';');
                if (s.Length >= 1 && s[0] != "")
                {
                    filePathA = s[0];
                    ConfiguredLabel(lblBtnA);
                }
                if (s.Length >= 2 && s[1] != "")
                {
                    filePathB = s[1];
                    ConfiguredLabel(lblBtnB);
                }
                if (s.Length >= 3 && s[2] != "")
                {
                    filePathC = s[2];
                    ConfiguredLabel(lblBtnC);
                }
                if (s.Length >= 4 && s[3] != "")
                {
                    filePathD = s[3];
                    ConfiguredLabel(lblBtnD);
                }
            }
            sr.Close();
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
                else if (input == "3" && filePathC != "")
                    Process.Start(filePathC);
                else if (input == "4" && filePathD != "")
                    Process.Start(filePathD);
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
            SalvaImpostazioni();
        }

        private void btnCambiaB_Click(object sender, EventArgs e)
        {
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                filePathB = openFileDialogMain.FileName;
                ConfiguredLabel(lblBtnB);
            }
            SalvaImpostazioni();
        }

        private void ConfiguredLabel(Label lbl)
        {
            lbl.Text = "Config";
            lbl.ForeColor = Color.Green;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnCambiaC_Click(object sender, EventArgs e)
        {
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                filePathC = openFileDialogMain.FileName;
                ConfiguredLabel(lblBtnC);
            }
            SalvaImpostazioni();
        }

        private void btnCambiaD_Click(object sender, EventArgs e)
        {
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                filePathD = openFileDialogMain.FileName;
                ConfiguredLabel(lblBtnD);
            }
            SalvaImpostazioni();
        }

        private void SalvaImpostazioni()
        {
            StreamWriter sw = new StreamWriter("configuration.csv");

            if (lblBtnA.Text == "Config")
                sw.Write(filePathA + ";");
            if (lblBtnB.Text == "Config")
                sw.Write(filePathB + ";");
            if (lblBtnC.Text == "Config")
                sw.Write(filePathC + ";");
            if (lblBtnD.Text == "Config")
                sw.Write(filePathD + ";");
            sw.Close();
        }
    }
}
