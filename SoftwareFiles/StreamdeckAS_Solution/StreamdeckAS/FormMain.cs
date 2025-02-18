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

        const int NBUTTONS = 8;

        string[] filePaths = new string[NBUTTONS];

        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            port = new SerialPort("COM3", 9600);
            port.DataReceived += Port_DataReceived;
            port.Open();
            //MessageBox.Show("Connessione stabilita");
            NotConfiguredLabel(lblBtnA);
            NotConfiguredLabel(lblBtnB);
            NotConfiguredLabel(lblBtnC);
            NotConfiguredLabel(lblBtnD);
            NotConfiguredLabel(lblBtnE);
            NotConfiguredLabel(lblBtnF);
            NotConfiguredLabel(lblBtnG);
            NotConfiguredLabel(lblBtnH);
            LoadConfiguration();
        }

        private void LoadConfiguration()
        {
            try
            {
                StreamReader sr = new StreamReader("configuration.csv");
                string[] s;

                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine().Trim().Split(';');
                    if (s.Length >= 1 && s[0] != "")
                    {
                        filePaths[0] = s[0];
                        ConfiguredLabel(lblBtnA);
                    }
                    if (s.Length >= 2 && s[1] != "")
                    {
                        filePaths[1] = s[1];
                        ConfiguredLabel(lblBtnB);
                    }
                    if (s.Length >= 3 && s[2] != "")
                    {
                        filePaths[2] = s[2];
                        ConfiguredLabel(lblBtnC);
                    }
                    if (s.Length >= 4 && s[3] != "")
                    {
                        filePaths[3] = s[3];
                        ConfiguredLabel(lblBtnD);
                    }
                    if (s.Length >= 5 && s[4] != "")
                    {
                        filePaths[4] = s[4];
                        ConfiguredLabel(lblBtnE);
                    }
                    if (s.Length >= 6 && s[5] != "")
                    {
                        filePaths[5] = s[5];
                        ConfiguredLabel(lblBtnF);
                    }
                    if (s.Length >= 7 && s[6] != "")
                    {
                        filePaths[6] = s[6];
                        ConfiguredLabel(lblBtnG);
                    }
                    if (s.Length >= 8 && s[7] != "")
                    {
                        filePaths[7] = s[7];
                        ConfiguredLabel(lblBtnH);
                    }
                }
                sr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Benvenuto in StreamdeckAS! Il software per la configurazione del tuo" +
                    "Streamdeck personale", "BENVENUTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NotConfiguredLabel(Label lbl)
        {
            lbl.Text = "Not config";
            lbl.ForeColor = Color.Red;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnInizia_Click(object sender, EventArgs e)
        {
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
            if (input == "1" && filePaths[0] != null)
                Process.Start(filePaths[0]);
            else if (input == "2" && filePaths[1] != null)
                Process.Start(filePaths[1]);
            else if (input == "3" && filePaths[2] != null)
                Process.Start(filePaths[2]);
            else if (input == "4" && filePaths[3] != null)
                Process.Start(filePaths[3]);
            else if (input == "5" && filePaths[4] != null)
                Process.Start(filePaths[4]);
            else if (input == "6" && filePaths[5] != null)
                Process.Start(filePaths[5]);
            else if (input == "7" && filePaths[6] != null)
                Process.Start(filePaths[6]);
            else if (input == "8" && filePaths[7] != null)
                Process.Start(filePaths[7]);
        }


        private void btnTermina_Click(object sender, EventArgs e)
        {
            ManageButtons();
        }

        private void ManageButtons()
        {
            if (btnInizia.Enabled)
            {
                btnTermina.Enabled = true;
                btnInizia.Enabled = false;
            }
            else
            {
                btnInizia.Enabled = true;
                btnTermina.Enabled = false;
            }
        }

        private void btnCambia_Click(object sender, EventArgs e)
        {
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                Button btnClicked = sender as Button;
                int index = Convert.ToInt32(btnClicked.Tag);
                filePaths[index] = openFileDialogMain.FileName;
                ConfiguredLabel
                (
                    index == 0 ? lblBtnA : index == 1 ? lblBtnB :
                    index == 2 ? lblBtnC : index == 3 ? lblBtnD :
                    index == 4 ? lblBtnE : index == 5 ? lblBtnF :
                    index == 6 ? lblBtnG : lblBtnH
                );
            }
        }

        private void ConfiguredLabel(Label lbl)
        {
            lbl.Text = "Config";
            lbl.ForeColor = Color.Green;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SalvaImpostazioni();
        }

        private void SalvaImpostazioni()
        {
            StreamWriter sw = new StreamWriter("configuration.csv");

            if (lblBtnA.Text == "Config")
                sw.Write(filePaths[0] + ";");
            if (lblBtnB.Text == "Config")
                sw.Write(filePaths[1] + ";");
            if (lblBtnC.Text == "Config")
                sw.Write(filePaths[2] + ";");
            if (lblBtnD.Text == "Config")
                sw.Write(filePaths[3] + ";");
            if (lblBtnE.Text == "Config")
                sw.Write(filePaths[4] + ";");
            if (lblBtnF.Text == "Config")
                sw.Write(filePaths[5] + ";");
            if (lblBtnG.Text == "Config")
                sw.Write(filePaths[6] + ";");
            if (lblBtnH.Text == "Config")
                sw.Write(filePaths[7] + ";");
            sw.Close();
        }
    }
}
