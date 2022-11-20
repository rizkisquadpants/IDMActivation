using System;
using System.Drawing;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using NetFwTypeLib;
using System.Reflection.Emit;

namespace RTA_Activation_IDM
{
    public partial class Form1 : Form
    {

        #region -> Drag Form
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        ProcessStartInfo ps = new ProcessStartInfo();
        string scFile = Path.GetTempPath() + "\\WriteLines.cmd";

        Form2 FActivation = new Form2();
        Form3 FAbout = new Form3();

        private void btnActivation_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckConnection("https://www.google.com"))
                {
                    lblConnection.Text = "Internet Connected";
                    FActivation.ShowDialog();

                }
                else
                {
                    lblConnection.Text = "Internet Not Connected";
                }
            }
            catch
            {
                lblConnection.Text = "Internet Error";
            }
            
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FAbout.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckConnection("https://www.google.com"))
                {
                    lblConnection.Text = "Internet Connected";

                    if (rbId.Checked)
                    {
                        var result = MessageBox.Show("Klik OK Untuk Memproses,"
                    + "\n" + "Selama proses berlangsung,"
                    + "\n" + "command prompt akan muncul dan"
                    + "\n" + "jangan tutup aplikasi ini"
                    + "\n" + "sampai aktivasi"
                    + "\n" + "proses selesai", "RTA SERVER", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.OK)
                        {
                            var Log = MessageBox.Show("Munculkan Proses Log ?", "RTA SERVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (Log == DialogResult.Yes)
                            {
                                ps.FileName = Path.GetTempPath() + "\\WriteLines.cmd";
                                ps.WindowStyle = ProcessWindowStyle.Normal;
                                ps.Arguments = @"/c " + "@start WriteLines.cmd /res 1";
                                Process.Start(ps);
                            }
                            else
                            {
                                ps.FileName = Path.GetTempPath() + "\\WriteLines.cmd";
                                ps.WindowStyle = ProcessWindowStyle.Normal;
                                ps.Arguments = @"/c " + "@start WriteLines.cmd /res 1 /s 1";
                                Process.Start(ps);
                            }
                        }
                    }
                    else
                    {
                        var result = MessageBox.Show("Click OK To Process,"
                    + "\n" + "During the process,"
                    + "\n" + "a command prompt will appear and"
                    + "\n" + "don't close this application"
                    + "\n" + "until the activation"
                    + "\n" + "process is complete", "RTA SERVER", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        
                        if (result == DialogResult.OK)
                        {
                            var Log = MessageBox.Show("Show Log Progress ?", "RTA SERVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            
                            if (Log == DialogResult.Yes)
                            {
                                ps.FileName = Path.GetTempPath() + "\\WriteLines.cmd";
                                ps.WindowStyle = ProcessWindowStyle.Normal;
                                ps.Arguments = @"/c " + "@start WriteLines.cmd /res 1";
                                Process.Start(ps);
                            }
                            else
                            {
                                ps.FileName = Path.GetTempPath() + "\\WriteLines.cmd";
                                ps.WindowStyle = ProcessWindowStyle.Normal;
                                ps.Arguments = @"/c " + "@start WriteLines.cmd /res 1 /s 1";
                                Process.Start(ps);
                            }
                        }
                    }
                }
                else
                {
                    lblConnection.Text = "Internet Not Connected";
                }
            }
            catch
            {
                lblConnection.Text = "Internet Error";
            }
        }

        private bool CheckConnection(String URL)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                request.Timeout = 10000;
                request.Credentials = CredentialCache.DefaultNetworkCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FirewallStatusCheck();


            try
            {
                System.IO.File.WriteAllText(Path.GetTempPath() + "\\WriteLines.cmd", txtScript.Text);
                rbEng.Checked = true;
            }
            catch
            {

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.IO.File.Delete(scFile);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbEng_CheckedChanged(object sender, EventArgs e)
        {
            rbEng.ForeColor = Color.IndianRed;
            rbId.ForeColor = Color.White;
            lblRekomen.Text = "Recommendation to use IDM Official Software";
            btnActivation.Text = "Activation";
            btnReset.Text = "Reset Trial / Activation";
            lblConnection.Text = "Make sure the internet is connected";

            FActivation.TxtFN = "First Name";
            FActivation.TxtLN = "Last Name";
            FActivation.setMsgBox = "Click OK To Process Activation,"
                    + "\n" + "During the activation process,"
                    + "\n" + "a command prompt will appear and"
                    + "\n" + "don't close this application"
                    + "\n" + "until the activation"
                    + "\n" + "process is complete";

            FActivation.setFirstName = "First Name";
            FActivation.setLastName = "Last Name (Optional)";
            FActivation.setButtonAct = "Activation";
            FActivation.setButtonCancel = "Back";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rbId.ForeColor = Color.IndianRed;
            rbEng.ForeColor = Color.White;
            lblRekomen.Text = "Rekomendasi untuk menggunakan Software Resmi IDM";
            btnActivation.Text = "Aktivasi";
            btnReset.Text = "Reset Trial / Aktivasi";
            lblConnection.Text = "Pastikan internet Terkoneksi";

            FActivation.TxtFN = "Nama Depan";
            FActivation.TxtLN = "Nama Belakang";
            FActivation.setMsgBox = "Klik OK Untuk Memproses Aktivasi,"
                    + "\n" + "Selama proses aktivasi,"
                    + "\n" + "command prompt akan muncul dan"
                    + "\n" + "jangan tutup aplikasi ini"
                    + "\n" + "sampai aktivasi"
                    + "\n" + "proses selesai";

            FActivation.setFirstName = "Nama Depan";
            FActivation.setLastName = "Nama Belakang (Opsional)";
            FActivation.setButtonAct = "Aktivasi";
            FActivation.setButtonCancel = "Kembali";
        }

        private void lblDowIDM_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.internetdownloadmanager.com/");
        }

        private void FirewallStatusCheck()
        {
            Process proc = new Process();
            string top = "netsh.exe";
            proc.StartInfo.Arguments = "advfirewall show domain state";
            proc.StartInfo.FileName = top;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();
            proc.WaitForExit();
            string output = proc.StandardOutput.ReadToEnd();
            if (output.Contains("ON"))
            {
                lblFireWall.Text = "Firewall Status : ENABLE";
                lblValueFirewall.Text = "ENABLE";
                lblValueFirewall.ForeColor = Color.LightGreen;
                lblValueFirewall.Location = new Point(292, 155);
            }
            else
            {
                lblFireWall.Text = "Firewall Status : DISABLE";
                lblValueFirewall.Text = "DISABLE";
                lblValueFirewall.ForeColor = Color.Crimson;
                lblValueFirewall.Location = new Point(288, 155);
            }
        }
     
        private void btnFirewall_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblFireWall.Text == "Firewall Status : ENABLE")
                {
                    Process proc = new Process();
                    string top = "netsh.exe";
                    proc.StartInfo.Arguments = "AdvFirewall Set AllProfiles State Off";
                    proc.StartInfo.FileName = top;
                    proc.StartInfo.UseShellExecute = false;
                    proc.StartInfo.RedirectStandardOutput = true;
                    proc.StartInfo.CreateNoWindow = true;
                    proc.Start();
                    proc.WaitForExit();
                    FirewallStatusCheck();
                }
                else
                {
                    Process proc = new Process();
                    string top = "netsh.exe";
                    proc.StartInfo.Arguments = "AdvFirewall Set AllProfiles State On";
                    proc.StartInfo.FileName = top;
                    proc.StartInfo.UseShellExecute = false;
                    proc.StartInfo.RedirectStandardOutput = true;
                    proc.StartInfo.CreateNoWindow = true;
                    proc.Start();
                    proc.WaitForExit();
                    FirewallStatusCheck();
                }

            }
            catch
            {

            }
        }
    }
}
