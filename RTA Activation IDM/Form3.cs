using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTA_Activation_IDM
{
    public partial class Form3 : Form
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
        public Form3()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTelegram_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/rtacode");
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCgBXH4Vd04E6tl40Ffbc_CA");
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            Process.Start("https://sociabuzz.com/rizkikotet/tribe");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
