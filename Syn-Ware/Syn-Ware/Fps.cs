using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyExploits;

namespace Syn_Ware
{
    public partial class Fps : Form
    {
        EasyExploits.Module module =  new Module();
        public Fps()
        {
            InitializeComponent();
        }

        private void Fps_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.module.ExecuteScript(string.Concat("set_fps_cap(", this.siticoneTextBox1.Text, ")"));
        }
    }
}
