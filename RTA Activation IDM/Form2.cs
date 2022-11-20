using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RTA_Activation_IDM
{
    public partial class Form2 : Form
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

        ProcessStartInfo ps = new ProcessStartInfo();
        string scFile = Path.GetTempPath() + "\\WriteLines.cmd";

        public Form2()
        {
            InitializeComponent();
        }

        string MsgBox;
        string txtFN;
        string txtLN;

        public string TxtFN
        {
            get
            {
                return this.txtFN;
            }
            set
            {
                this.txtFN = value;
            }
        }

        public string TxtLN
        {
            get
            {
                return this.txtLN;
            }
            set
            {
                this.txtLN = value;
            }
        }
        public string setMsgBox
        {
            get
            {
                return this.MsgBox;
            }
            set
            {
                this.MsgBox = value;
            }
        }

        public string setFirstName
        {
            get
            {
                return this.lblFirst.Text;
            }
            set
            {
                this.lblFirst.Text = value;
            }
        }

        public string setLastName
        {
            get
            {
                return this.lblLast.Text;
            }
            set
            {
                this.lblLast.Text = value;
            }
        }

        public string setButtonAct
        {
            get
            {
                return this.btnActivation.Text;
            }
            set
            {
                this.btnActivation.Text = value;
            }
        }

        public string setButtonCancel
        {
            get
            {
                return this.btnCancel.Text;
            }
            set
            {
                this.btnCancel.Text = value;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActivation_Click(object sender, EventArgs e)
        {
            if (txtfirstName.Text != "")
            {
                if (txtEmail.Text != "")
                {
                    if (IsValidEmail(txtEmail.Text))
                    {
                        var result = MessageBox.Show("========= Activation IDM ========="
                        + "\n" + $"{TxtFN} : {txtfirstName.Text}"
                        + "\n" + $"{TxtLN} : {txtLastName.Text}"
                        + "\n" + $"Email : {txtEmail.Text}"
                        + "\n" + "========= Activation IDM ========="
                        + "\n" + ""
                        + "\n" + ""
                        + "\n" + MsgBox, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        if (result == DialogResult.OK)
                        {
                            string SCRIPT1 =
                                "\n" + "@setlocal DisableDelayedExpansion"
                                + "\n" + "@echo off"
                                + "\n" + ""
                                + "\n" + $"set name={txtfirstName.Text}";

                            string SCRIPT2 =
                                "\n" + "If not defined name set name=RTA SERVER"
                                + "\n" + "set \"reg=HKCU\\SOFTWARE\\DownloadManager /v FName /t REG_SZ /d \"%name%\"\" & call :_rcont"
                                + "\n" + $"set \"reg=HKCU\\SOFTWARE\\DownloadManager /v LName /t REG_SZ /d \"{txtLastName.Text}\"\" & call :_rcont"
                                + "\n" + $"set \"reg=HKCU\\SOFTWARE\\DownloadManager /v Email /t REG_SZ /d \"{txtEmail.Text}\"\" & call :_rcont"
                                + "\n" + $"set \"reg=HKCU\\SOFTWARE\\DownloadManager /v Serial /t REG_SZ /d \"{txtSerial.Text}\"\" & call :_rcont"; //FOX6H-3KWH4-7TSIN-Q4US7

                            File.WriteAllText(Path.GetTempPath() + "\\WriteLines.cmd", SCRIPT1 + "\n" + txtScript1.Text + "\n" + SCRIPT2 + "\n" + txtScript2.Text);

                            var Log = MessageBox.Show("Show Log Progress ?", "RTA SERVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (Log == DialogResult.Yes)
                            {
                                ps.FileName = Path.GetTempPath() + "\\WriteLines.cmd";
                                ps.WindowStyle = ProcessWindowStyle.Normal;
                                ps.Arguments = @"/c " + "@start WriteLines.cmd /act 1";
                                Process.Start(ps);
                                this.Close();
                            }
                            else
                            {
                                ps.FileName = Path.GetTempPath() + "\\WriteLines.cmd";
                                ps.WindowStyle = ProcessWindowStyle.Normal;
                                ps.Arguments = @"/c " + "@start WriteLines.cmd /act 1 /s 1";
                                Process.Start(ps);
                                this.Close();
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter Your Email", "RTA SERVER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrGenerate_Tick(object sender, EventArgs e)
        {
            if (txtfirstName.Text != "")
            {
                if (txtEmail.Text != "")
                {
                    string productIdentifier = (txtfirstName.Text + "-" + txtEmail.Text).ToLower();
                    txtSerial.Text = GenerateLicenseKey(productIdentifier).ToString();
                }    
            }
        }


        static string GenerateLicenseKey(string productIdentifier)
        {
            return FormatLicenseKey(GetMd5Sum(productIdentifier));
        }

        static string GetMd5Sum(string productIdentifier)
        {
            System.Text.Encoder enc = System.Text.Encoding.Unicode.GetEncoder();
            byte[] unicodeText = new byte[productIdentifier.Length * 5];
            enc.GetBytes(productIdentifier.ToCharArray(), 0, 3, unicodeText, 0, true);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(unicodeText);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString("X2"));
            }
            return sb.ToString();
        }

        static string FormatLicenseKey(string productIdentifier)
        {
            productIdentifier = productIdentifier.Substring(0, 28).ToUpper();
            char[] serialArray = productIdentifier.ToCharArray();
            StringBuilder licenseKey = new StringBuilder();

            int j = 0;
            for (int i = 0; i < 20; i++)
            {
                for (j = i; j < 5 + i; j++)
                {
                    licenseKey.Append(serialArray[j]);
                }
                if (j == 20)
                {
                    break;
                }
                else
                {
                    i = (j) - 1;
                    licenseKey.Append("-");
                }
            }
            return licenseKey.ToString();
        }

        bool IsValidEmail(string eMail)
        {
            bool Result = false;

            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);

                Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                Result = false;
            };

            return Result;
        }

        private void txtfirstName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
