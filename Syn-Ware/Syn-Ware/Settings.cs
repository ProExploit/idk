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
using EasyExploits;

namespace Syn_Ware
{
    public partial class Settings : Form
    {
        EasyExploits.Module module = new Module();

        public static object Default { get; internal set; }

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            Process.Start("rbxfpsunlocker");
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Process[] roblox = Process.GetProcesses();
            foreach (Process openedroblox in roblox)
            {
                bool flag = openedroblox.ProcessName == "RobloxPlayerBeta";
                if (flag)
                {
                    openedroblox.Kill();
                }
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void siticoneCheckBox1_CheckedChangedAsync(object sender, EventArgs e)
        {

        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            Fps openform = new Fps();
            openform.Show();
        }
    }
}
