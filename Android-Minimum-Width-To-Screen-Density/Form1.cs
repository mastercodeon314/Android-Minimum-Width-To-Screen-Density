using AdvancedSharpAdbClient.Models;
using AdvancedSharpAdbClient;
using DarkControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedSharpAdbClient.Receivers;

namespace Density_To_MinWidth
{
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                // Activate double buffering at the form level.  All child controls will be double buffered as well.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        bool skip = false;
        AdbClient adbClient;
        DeviceData device;

        public Form1()
        {

            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(Utils.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            this.closeBtn.Region = Region.FromHrgn(Utils.CreateRoundRectRgn(0, 0, closeBtn.Width, closeBtn.Height, 10, 10));

            this.appIcon1.DragForm = this;

            if (!AdbServer.Instance.GetStatus().IsRunning)
            {
                AdbServer server = new AdbServer();

                // Replace C:\adb\adb.exe with the path to youor adb!!
                StartServerResult result = server.StartServer(@"C:\adb\adb.exe", false);
                if (result != StartServerResult.Started)
                {
                    Console.WriteLine("Can't start adb server");
                }
            }

            adbClient = new AdbClient();
            adbClient.Connect("127.0.0.1:62001");
            device = adbClient.GetDevices().FirstOrDefault(); // Get first connected device
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == Utils.WM_NCHITTEST)
                m.Result = (IntPtr)(Utils.HT_CAPTION);
        }

        private void densityBar_Scroll(object sender, EventArgs e)
        {
            int density = densityBar.Value;
            int minWidth = GetMinWidth_From_Density(int.Parse(widthBox.Text), int.Parse(heightBox.Text), density);
            densityLbl.Text = "Density Value: " + density.ToString();
            minWidthValueLbl.Text = "Minimum Width: " + minWidth.ToString();
            minWidthBar.Value = minWidth;
        }

        static int GetDensity_From_MinWidth(int screenWidth, int screenHeight, int minWidthDP)
        {
            return (int)Math.Max((Math.Min(screenWidth, screenHeight) * 160) / Math.Max(minWidthDP, 72), 72);
        }

        static int GetMinWidth_From_Density(int screenWidth, int screenHeight, int density)
        {
            // Ensurescreen density is at least 320
            density = Math.Max(density, 320);

            // Calculate screen midWidth (dp)
            int midWidth = (int)Math.Round((Math.Min(screenWidth, screenHeight) * 160.0) / density);

            // Ensure midWidth is at least 120 dpi
            midWidth = Math.Max(midWidth, 120);

            return midWidth;
        }

        private void minWidthBar_Scroll(object sender, EventArgs e)
        {
            int minWidth = minWidthBar.Value;
            int density = GetDensity_From_MinWidth(int.Parse(widthBox.Text), int.Parse(heightBox.Text), minWidth);

            densityLbl.Text = "Density Value: " + density.ToString();
            minWidthValueLbl.Text = "Minimum Width: " + minWidth.ToString();
            densityBar.Value = density;
        }

        private void resBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skip)
            {
                skip = false;
                return;
            }
            else
            {
                string obj = resBox.SelectedItem.ToString();

                string[] parts = obj.Split('x');

                widthBox.Text = parts[0];
                heightBox.Text = parts[1];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConsoleOutputReceiver receiver = new ConsoleOutputReceiver();
            adbClient.ExecuteRemoteCommand("wm size", device, receiver); // synchronously
            string value = getSize(receiver.ToString());

            resBox.SelectedItem = value;

            densityBar.Value = getDensity();

            densityBar_Scroll(this, null);
        }

        private int getDensity()
        {
            ConsoleOutputReceiver receiver = new ConsoleOutputReceiver();
            adbClient.ExecuteRemoteCommand("wm density", device, receiver); // synchronously
            string value = receiver.ToString();

            value = value.Replace("\r", "").Replace(": ", ":").Trim();
            string[] parts = value.Split('\n');

            foreach (string p in parts)
            {
                if (p.StartsWith("Override density"))
                {
                    string[] pts = p.Split(':');
                    return int.Parse(pts[1]);
                }
            }

            return 0;
        }

        private string getSize(string val)
        {
            val = val.Replace("\r", "").Replace(": ", ":").Trim();
            string[] parts = val.Split('\n');

            if (val.Contains("Override size:"))
            {
                foreach (string part in parts)
                {
                    if (part.StartsWith("Override size:"))
                    {
                        string[] pts = part.Split(':');
                        return pts[1];
                    }
                }
            }
            else
            {
                if (val.StartsWith("Physical size:"))
                {
                    string[] pts = val.Split(':');
                    return pts[1];
                }
            }

            return "";
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            ConsoleOutputReceiver receiver = new ConsoleOutputReceiver();
            adbClient.ExecuteRemoteCommand("wm density " + densityBar.Value.ToString(), device, receiver); // synchronously
        }
    }
}
